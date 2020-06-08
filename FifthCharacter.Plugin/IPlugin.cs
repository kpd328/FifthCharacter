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
        /// Add all races to this collection to expose them to the App.
        /// </summary>
        RaceDictionary Races { get; }
        /// <summary>
        /// Add all magic to this collection to expose them to the App.
        /// </summary>
        MagicDictionary Magic { get; }
        /// <summary>
        /// Add all attacks to this collection to expose them to the App.
        /// </summary>
        AttackDictionary Attacks { get; }
        /// <summary>
        /// Add all feats to this collection to expose them to the App.
        /// Note, features such as those found in classes or races do not need to be added here if they are properly
        /// used in the respective class/race/etc. Only feats obtained by foregoing an Ability Score Improvement feature
        /// are added here.
        /// </summary>
        FeatureDictionary Feats { get; }
        /// <summary>
        /// Add all subclasses to this collection to expose them to the App.
        /// Note, subclasses are features that extend each player class' abstract subclass feature which will be used to
        /// identify each subclass' parent class
        /// </summary>
        FeatureDictionary Subclasses { get; }
        /// <summary>
        /// Add all player classes to this collection to expose them to the App.
        /// </summary>
        PlayerClassDictionary PlayerClasses { get; }
        /// <summary>
        /// Add all backgrounds to this collection to expose them to the App.
        /// </summary>
        BackgroundDictionary Backgrounds { get; }
        /// <summary>
        /// Add all proficiencies to this collection to expose them to the App.
        /// </summary>
        ProficiencyDictionary Proficiencies { get; }
        /// <summary>
        /// Add all armors (incl. shields) to this collection to expose them to the App.
        /// </summary>
        ArmorDictionary Armors { get; }
    }
}
