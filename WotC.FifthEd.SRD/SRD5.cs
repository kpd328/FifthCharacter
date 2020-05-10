using FifthCharacter.Plugin;
using FifthCharacter.Plugin.Tools;
using WotC.FifthEd.SRD.Attacks.MartialMeleeWeapon;
using WotC.FifthEd.SRD.Attacks.MartialRangedWeapon;
using WotC.FifthEd.SRD.Attacks.SimpleMeleeWeapon;
using WotC.FifthEd.SRD.Attacks.SimpleRangedWeapon;
using WotC.FifthEd.SRD.Backgrounds;
using WotC.FifthEd.SRD.PlayerClass;
using WotC.FifthEd.SRD.Race;
using WotC.FifthEd.SRD.Spells.Abjuration;
using WotC.FifthEd.SRD.Spells.Conjuration;
using WotC.FifthEd.SRD.Spells.Enchantment;
using WotC.FifthEd.SRD.Spells.Evocation;
using WotC.FifthEd.SRD.Spells.Transmutation;

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

        public RaceDictionary Races => new RaceDictionary() {
            new HillDwarf(),
            new HighElf(),
            new LightfootHalfling(),
            new Human(),
            new Dragonborn(),
            new RockGnome(),
            new HalfElf(),
            new HalfOrc(),
            new Tiefling()
        };
        public MagicDictionary Magic => new MagicDictionary() {
            //Abjuration Spells
            new Aid(),
            new Alarm(),

            //Conjuration Spells
            new AcidSplash(),

            //Divination Spells

            //Enchantment Spells
            new AnimalFriendship(),

            //Evocation Spells
            new FireBolt(),

            //Illusion Spells

            //Necromancy Spells

            //Transmutation Spells
            new AlterSelf()
        };
        public AttackDictionary Attacks => new AttackDictionary() {
            new MMWBattleaxe(),
            new MMWFlail(),
            new MMWGlaive(),
            new MMWGreataxe(),
            new MMWGreatsword(),
            new MMWHalberd(),
            new MMWLance(),
            new MMWLongsword(),
            new MMWMaul(),
            new MMWMorningstar(),
            new MMWPike(),
            new MMWRapier(),
            new MMWScimitar(),
            new MMWShortsword(),
            new MMWTrident(),
            new MMWWarPick(),
            new MMWWarhammer(),
            new MMWWhip(),
            new MRWBlowgun(),
            new MRWHandCrossbow(),
            new MRWHeavyCrossbow(),
            new MRWLongbow(),
            new MRWNet(),
            new SMWClub(),
            new SMWDagger(),
            new SMWGreatclub(),
            new SMWHandaxe(),
            new SMWJavelin(),
            new SMWLightHammer(),
            new SMWMace(),
            new SMWQuarterstaff(),
            new SMWSickle(),
            new SMWSpear(),
            new SRWDart(),
            new SRWLightCrossbow(),
            new SRWShortbow(),
            new SRWSling()
        };
        public FeatureDictionary Feats => new FeatureDictionary() {
        };
        public PlayerClassDictionary PlayerClasses => new PlayerClassDictionary() {
            new Barbarian(),
            new Bard(),
            new Cleric(),
            new Druid(),
            new Fighter(),
            new Monk(),
            new Paladin(),
            new Ranger(),
            new Rogue(),
            new Sorcerer(),
            new Warlock(),
            new Wizard()
        };

        public BackgroundDictionary Backgrounds => new BackgroundDictionary() {
            new Acolyte()
        };
    }
}
