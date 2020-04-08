using FifthCharacter.Plugin.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace FifthCharacter.Plugin {
    public class PluginLoader {
        public static List<IPlugin> Plugins { get; private set; }
        public RaceDictionary Races { get; private set; }
        public MagicDictionary Magic { get; private set; }
        public AttackDictionary Attacks { get; private set; }
        public FeatureDictionary Features { get; private set; }
        public PlayerClassDictionary PlayerClasses { get; private set; }

        public void LoadPlugins() {
            Plugins = new List<IPlugin>();

            if (Directory.Exists(Constants.FolderName)) {
                string[] files = Directory.GetFiles(Constants.FolderName);
                foreach(string file in files) {
                    if (file.EndsWith(".dll")) {
                        Assembly.LoadFile(Path.GetFullPath(file));
                    }
                }
            }

            Type interfaceType = typeof(IPlugin);
            Type[] types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(p => interfaceType.IsAssignableFrom(p) && p.IsClass)
                .ToArray();
            foreach(Type type in types) {
                Plugins.Add((IPlugin)Activator.CreateInstance(type));
            }

            foreach(IPlugin plugin in Plugins) {
                Races.AddAll(plugin.Races);
                Magic.AddAll(plugin.Magic);
                Attacks.AddAll(plugin.Attacks);
                Features.AddAll(plugin.Features);
                PlayerClasses.AddAll(plugin.PlayerClasses);
            }
        }
    }
}
