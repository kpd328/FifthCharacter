using FifthCharacter.Plugin;
using FifthCharacter.Plugin.Tools;
using WotC.FifthEd.SRD.Attacks.MartialMeleeWeapon;
using WotC.FifthEd.SRD.Attacks.MartialRangedWeapon;
using WotC.FifthEd.SRD.Attacks.SimpleMeleeWeapon;
using WotC.FifthEd.SRD.Attacks.SimpleRangedWeapon;
using WotC.FifthEd.SRD.Backgrounds;
using WotC.FifthEd.SRD.Features.Feat;
using WotC.FifthEd.SRD.Features.PlayerClass.Barbarian.PathOfTheBerserker;
using WotC.FifthEd.SRD.Features.PlayerClass.Bard.CollegeOfLore;
using WotC.FifthEd.SRD.Features.PlayerClass.Cleric.LifeDomain;
using WotC.FifthEd.SRD.Features.PlayerClass.Druid.CircleOfTheLand;
using WotC.FifthEd.SRD.Features.PlayerClass.Fighter.Champion;
using WotC.FifthEd.SRD.Features.PlayerClass.Monk.WayOfTheOpenHand;
using WotC.FifthEd.SRD.Features.PlayerClass.Paladin;
using WotC.FifthEd.SRD.Features.PlayerClass.Paladin.OathOfDevotion;
using WotC.FifthEd.SRD.Features.PlayerClass.Ranger.Hunter;
using WotC.FifthEd.SRD.Features.PlayerClass.Rogue;
using WotC.FifthEd.SRD.Features.PlayerClass.Rogue.Thief;
using WotC.FifthEd.SRD.Features.PlayerClass.Sorcerer;
using WotC.FifthEd.SRD.Features.PlayerClass.Sorcerer.DraconicBloodline;
using WotC.FifthEd.SRD.PlayerClass;
using WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon;
using WotC.FifthEd.SRD.Proficiencies.Attacks.MartialRangedWeapon;
using WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleMeleeWeapon;
using WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleRangedWeapon;
using WotC.FifthEd.SRD.Proficiencies.Languages;
using WotC.FifthEd.SRD.Proficiencies.Tools;
using WotC.FifthEd.SRD.Proficiencies.Tools.ArtisansTools;
using WotC.FifthEd.SRD.Proficiencies.Tools.GamingSet;
using WotC.FifthEd.SRD.Proficiencies.Tools.MusicalInstrument;
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
            new FeatGrappler()
        };
        public FeatureDictionary Subclasses => new FeatureDictionary() {
            new FBarbarianPrimalPathPathOfTheBerserker(),
            new FBardBardCollegeCollegeOfLore(),
            new FClericDivineDomainLifeDomain(),
            new FDruidDruidCircleCircleOfTheLand(),
            new FFighterMartialArchetypeChampion(),
            new FMonkMonasticTraditionWayOfTheOpenHand(),
            new FPaladinSacredOathOathOfDevotion(),
            new FRangerRangerArchetypeHunter(),
            new FRogueRoguishArchetypeThief(),
            new FSorcererSorcerousOriginDraconicBloodline()
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
            new NoBackground(),
            new Acolyte()
        };

        public ProficiencyDictionary Proficiencies => new ProficiencyDictionary() {
            new ProfMMWBattleaxe(),
            new ProfMMWFlail(),
            new ProfMMWGlaive(),
            new ProfMMWGreataxe(),
            new ProfMMWGreatsword(),
            new ProfMMWHalberd(),
            new ProfMMWLance(),
            new ProfMMWLongsword(),
            new ProfMMWMaul(),
            new ProfMMWMorningstar(),
            new ProfMMWPike(),
            new ProfMMWRapier(),
            new ProfMMWScimitar(),
            new ProfMMWShortsword(),
            new ProfMMWTrident(),
            new ProfMMWWarhammer(),
            new ProfMMWWarPick(),
            new ProfMMWWhip(),
            new ProfMRWBlowgun(),
            new ProfMRWHandCrossbow(),
            new ProfMRWHeavyCrossbow(),
            new ProfMRWLongbow(),
            new ProfMRWNet(),
            new ProfSMWClub(),
            new ProfSMWDagger(),
            new ProfSMWGreatclub(),
            new ProfSMWHandaxe(),
            new ProfSMWJavelin(),
            new ProfSMWLightHammer(),
            new ProfSMWMace(),
            new ProfSMWQuarterstaff(),
            new ProfSMWSickle(),
            new ProfSMWSpear(),
            new ProfSRWDart(),
            new ProfSRWLightCrossbow(),
            new ProfSRWShortbow(),
            new ProfSRWSling(),
            new ProfLangCommon(),
            new ProfLangDraconic(),
            new ProfLangDwarvish(),
            new ProfLangElvish(),
            new ProfLangGnomish(),
            new ProfLangHalfling(),
            new ProfLangInfernal(),
            new ProfLangOrc(),
            new ProfLangGiant(),
            new ProfLangGoblin(),
            new ProfLangAbyssal(),
            new ProfLangCelestial(),
            new ProfLangDeepSpeech(),
            new ProfLangPrimordial(),
            new ProfLangSylvan(),
            new ProfLangUndercommon(),
            new ProfAlchemistsSupplies(),
            new ProfBrewersSupplies(),
            new ProfCalligraphersSupplies(),
            new ProfCarpentersTools(),
            new ProfCartographersTools(),
            new ProfCobblersTools(),
            new ProfCooksUtensils(),
            new ProfGlassblowersTools(),
            new ProfJewelersTools(),
            new ProfLeatherworkersTools(),
            new ProfMasonsTools(),
            new ProfPaintersSupplies(),
            new ProfPottersTools(),
            new ProfSmithsTools(),
            new ProfTinkersTools(),
            new ProfWeaversTools(),
            new ProfWoodcarversTools(),
            new ProfDesguiseKit(),
            new ProfForgeryKit(),
            new ProfDiceSet(),
            new ProfPlayingCardSet(),
            new ProfHerbalismKit(),
            new ProfBagpipes(),
            new ProfDrum(),
            new ProfDulcimer(),
            new ProfFlute(),
            new ProfLute(),
            new ProfLyre(),
            new ProfHorn(),
            new ProfPanFlute(),
            new ProfShawm(),
            new ProfViol(),
            new ProfNavigatorsTools(),
            new ProfPoisonersKit(),
            new ProfThievesTools()
        };
    }
}
