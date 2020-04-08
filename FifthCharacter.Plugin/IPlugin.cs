using FifthCharacter.Plugin.Tools;

namespace FifthCharacter.Plugin {
    public interface IPlugin {
        string PluginName { get; }
        string PluginDescription { get; }
        string PluginAuthor { get; }
        /// <summary>
        /// This property is for personal use, use whichever versioning scheme you want.
        /// </summary>
        string PluginVersion { get; }
        /// <summary>
        /// Please initialize with <c>IDGen.GetID(string.Format("{0}.{1}.{2}", Author, Name, Version))</c> preferably from an internal static context.
        /// </summary>
        string PluginID { get; }

        /// <summary>
        /// Add all races to this collection using the <c>Add(IRace)</c> method to expose them to the App.
        /// </summary>
        RaceDictionary Races { get; }
        /// <summary>
        /// Add all magic to this collection using the <c>Add(IMagic)</c> method to expose them to the App.
        /// </summary>
        MagicDictionary Magic { get; }
        /// <summary>
        /// Add all attacks to this collection using the <c>Add(IAttack)</c> method to expose them to the App.
        /// </summary>
        AttackDictionary Attacks { get; }
        /// <summary>
        /// Add all features to this collection using the <c>Add(IFeature)</c> method to expose them to the App.
        /// </summary>
        FeatureDictionary Features { get; }
        /// <summary>
        /// Add all player classes to this collection using the <c>Add(PlayerClass)</c> method to expose them to the App.
        /// </summary>
        PlayerClassDictionary PlayerClasses { get; }
    }
}
