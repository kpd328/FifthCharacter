using FifthCharacter.Plugin.Proficiencies.Armor;
using FifthCharacter.Plugin.Proficiencies.Attacks;
using FifthCharacter.Plugin.Proficiencies.SavingThrows;
using FifthCharacter.Plugin.Proficiencies.Skills;
using FifthCharacter.Plugin.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace FifthCharacter.Plugin {
    public class PluginLoader {
        public static List<IPlugin> Plugins { get; private set; }
        internal static PluginLoader Instance { get; private set; } = null;
        public RaceDictionary Races { get; private set; } = new RaceDictionary();
        public MagicDictionary Magic { get; private set; } = new MagicDictionary();
        public AttackDictionary Attacks { get; private set; } = new AttackDictionary();
        public FeatureDictionary Feats { get; private set; } = new FeatureDictionary();
        public FeatureDictionary Subclasses { get; private set; } = new FeatureDictionary();
        public PlayerClassDictionary PlayerClasses { get; private set; } = new PlayerClassDictionary();
        public BackgroundDictionary Backgrounds { get; private set; } = new BackgroundDictionary();
        public ProficiencyDictionary Proficiencies { get; private set; } = new ProficiencyDictionary() {
            new ProfArmor(),
            new ProfArmorHeavy(),
            new ProfArmorLight(),
            new ProfArmorMedium(),
            new ProfArmorShield(),
            new ProfMartialMeleeWeapon(),
            new ProfMartialRangedWeapon(),
            new ProfMartialWeapon(),
            new ProfSimpleMeleeWeapon(),
            new ProfSimpleRangedWeapon(),
            new ProfSimpleWeapon(),
            new ProfCharismaSave(),
            new ProfConstitutionSave(),
            new ProfDexteritySave(),
            new ProfIntelligenceSave(),
            new ProfStrengthSave(),
            new ProfWisdomSave(),
            new ProfAcrobatics(),
            new ProfAnimalHandling(),
            new ProfArcana(),
            new ProfAthletics(),
            new ProfDeception(),
            new ProfHistory(),
            new ProfInsight(),
            new ProfIntimidation(),
            new ProfInvestigation(),
            new ProfMedicine(),
            new ProfNature(),
            new ProfPerception(),
            new ProfPerformance(),
            new ProfPersuasion(),
            new ProfReligion(),
            new ProfSleightOfHand(),
            new ProfStealth(),
            new ProfSurvival()
        };
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
                    Feats.AddAll(plugin.Feats);
                    Subclasses.AddAll(plugin.Subclasses);
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
