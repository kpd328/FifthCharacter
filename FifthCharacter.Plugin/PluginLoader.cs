using FifthCharacter.Plugin.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Xamarin.Forms;

namespace FifthCharacter.Plugin {
    public class PluginLoader {
        public static List<IPlugin> Plugins { get; private set; }
        internal static PluginLoader Instance { get; private set; } = null;
        public RaceDictionary Races { get; private set; } = new RaceDictionary();
        public MagicDictionary Magic { get; private set; } = new MagicDictionary();
        public AttackDictionary Attacks { get; private set; } = new AttackDictionary();
        public FeatureDictionary Features { get; private set; } = new FeatureDictionary();
        public PlayerClassDictionary PlayerClasses { get; private set; } = new PlayerClassDictionary();
        public BackgroundDictionary Backgrounds { get; private set; } = new BackgroundDictionary();
        public ProficiencyDictionary Proficiencies { get; private set; } = new ProficiencyDictionary();
        private bool loaded = false;

        private PluginLoader() { }

        public void LoadPlugins() {
            if (!loaded) {
                Plugins = new List<IPlugin>();

                if (Directory.Exists(Constants.FolderName)) {
                    string[] files = Directory.GetFiles(Constants.FolderName);
                    foreach (string file in files) {
                        if (file.EndsWith(".dll")) {
                            Assembly.UnsafeLoadFrom(Path.GetFullPath(file));
                        }
                    }
                }

                Type interfaceType = typeof(IPlugin);
                Type[] types = AppDomain.CurrentDomain.GetAssemblies()
                    .SelectMany(a => a.GetTypes())
                    .Where(p => interfaceType.IsAssignableFrom(p) && p.IsClass)
                    .ToArray();
                foreach (Type type in types) {
                    Plugins.Add((IPlugin)Activator.CreateInstance(type));
                }

                foreach (IPlugin plugin in Plugins) {
                    Races.AddAll(plugin.Races);
                    Magic.AddAll(plugin.Magic);
                    Attacks.AddAll(plugin.Attacks);
                    Features.AddAll(plugin.Feats);
                    PlayerClasses.AddAll(plugin.PlayerClasses);
                    Backgrounds.AddAll(plugin.Backgrounds);
                    Proficiencies.AddAll(plugin.Proficiencies);
                }
                loaded = true;
            }
        }

        public static PluginLoader GetLoader() {
            if(Instance == null) {
                Instance = new PluginLoader();
            }
            return Instance;
        }
    }
}
