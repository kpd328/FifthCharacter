using FifthCharacter.Plugin;
using FifthCharacter.Plugin.Tools;

namespace WotC.FifthEd.SRD {
    public class SRD5 : IPlugin {
        internal static string Name => "SRD5";
        internal static string Description => "The Systems Reference Document 5.1 for Dungeons and Dragons";
        internal static string Author => "Wizards of the Coast";
        internal static string Version => "1.0";
        internal static string ID => IDGen.GetID(string.Format("{0}.{1}.{2}", Author, Name, Version));

        public string PluginName => Name;
        public string PluginDescription => Description;
        public string PluginAuthor => Author;
        public string PluginVersion => Version;
        public string PluginID => ID;

        public RaceDictionary Races => throw new System.NotImplementedException();
        public MagicDictionary Magic => throw new System.NotImplementedException();
        public AttackDictionary Attacks => throw new System.NotImplementedException();
        public FeatureDictionary Features => throw new System.NotImplementedException();
        public PlayerClassDictionary PlayerClasses => throw new System.NotImplementedException();
    }
}
