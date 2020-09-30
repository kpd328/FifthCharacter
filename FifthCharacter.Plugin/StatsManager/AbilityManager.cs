using System;

namespace FifthCharacter.Plugin.StatsManager {
    public static class AbilityManager {
        //TODO: Save scores to static location

        //Raw Ability Scores
        public static int StrengthScore { get; set; }
        public static int DexterityScore { get; set; }
        public static int ConstitutionScore { get; set; }
        public static int IntelligenceScore { get; set; }
        public static int WisdomScore { get; set; }
        public static int CharismaScore { get; set; }
        public static int ProficiencyBonus => 1 + (int)Math.Ceiling(ClassManager.TotalLevel / 4.0);

        //Ability Score Modifiers
        public static int StrengthMod => (int)Math.Floor((StrengthScore - 10.0) / 2.0);
        public static int DexterityMod => (int)Math.Floor((DexterityScore - 10.0) / 2.0);
        public static int ConstitutionMod => (int)Math.Floor((ConstitutionScore - 10.0) / 2.0);
        public static int IntelligenceMod => (int)Math.Floor((IntelligenceScore - 10.0) / 2.0);
        public static int WisdomMod => (int)Math.Floor((WisdomScore - 10.0) / 2.0);
        public static int CharismaMod => (int)Math.Floor((CharismaScore - 10.0) / 2.0);

        public static string StrengthModifier => StrengthMod.ToString("+0;-#");
        public static string DexterityModifier => DexterityMod.ToString("+0;-#");
        public static string ConstitutionModifier => ConstitutionMod.ToString("+0;-#");
        public static string IntelligenceModifier => IntelligenceMod.ToString("+0;-#");
        public static string WisdomModifier => WisdomMod.ToString("+0;-#");
        public static string CharismaModifier => CharismaMod.ToString("+0;-#");

        //Saving Throws
        public static bool StrengthSaveProficiency => ProficiencyManager.CheckByName("Strength Saving Throws", Interface.ProficiencyType.SAVING_THROW);
        public static bool DexteritySaveProficiency => ProficiencyManager.CheckByName("Dexterity Saving Throws", Interface.ProficiencyType.SAVING_THROW);
        public static bool ConstitutionSaveProficiency => ProficiencyManager.CheckByName("Constitution Saving Throws", Interface.ProficiencyType.SAVING_THROW);
        public static bool IntelligenceSaveProficiency => ProficiencyManager.CheckByName("Intelligence Saving Throws", Interface.ProficiencyType.SAVING_THROW);
        public static bool WisdomSaveProficiency => ProficiencyManager.CheckByName("Wisdom Saving Throws", Interface.ProficiencyType.SAVING_THROW);
        public static bool CharismaSaveProficiency => ProficiencyManager.CheckByName("Charisma Saving Throw", Interface.ProficiencyType.SAVING_THROW);

        private static int StrengthSaveVal => StrengthSaveProficiency ? StrengthMod + ProficiencyBonus : StrengthMod;
        private static int DexteritySaveVal => DexteritySaveProficiency ? DexterityMod + ProficiencyBonus : DexterityMod;
        private static int ConstitutionSaveVal => ConstitutionSaveProficiency ? ConstitutionMod + ProficiencyBonus : ConstitutionMod;
        private static int IntelligenceSaveVal => IntelligenceSaveProficiency ? IntelligenceMod + ProficiencyBonus : IntelligenceMod;
        private static int WisdomSaveVal => WisdomSaveProficiency ? WisdomMod + ProficiencyBonus : WisdomMod;
        private static int CharismaSaveVal => CharismaSaveProficiency ? CharismaMod + ProficiencyBonus : CharismaMod;

        public static string StrengthSave => StrengthSaveVal.ToString("+0;-#");
        public static string DexteritySave => DexteritySaveVal.ToString("+0;-#");
        public static string ConstitutionSave => ConstitutionSaveVal.ToString("+0;-#");
        public static string IntelligenceSave => IntelligenceSaveVal.ToString("+0;-#");
        public static string WisdomSave => WisdomSaveVal.ToString("+0;-#");
        public static string CharismaSave => CharismaSaveVal.ToString("+0;-#");

        //Skills
        public static bool AthleticsProficiency => ProficiencyManager.CheckByName("Athletics", Interface.ProficiencyType.SKILL);
        private static int AthleticsModifier => AthleticsProficiency ? StrengthMod + ProficiencyBonus : StrengthMod;
        public static string Athletics => AthleticsModifier.ToString("+0;-#");

        public static bool AcrobaticsProficiency => ProficiencyManager.CheckByName("Acrobatics", Interface.ProficiencyType.SKILL);
        public static bool SleightOfHandProficiency => ProficiencyManager.CheckByName("Sleight of Hand", Interface.ProficiencyType.SKILL);
        public static bool StealthProficiency => ProficiencyManager.CheckByName("Stealth", Interface.ProficiencyType.SKILL);
        private static int AcrobaticsModifier => AcrobaticsProficiency ? DexterityMod + ProficiencyBonus : DexterityMod;
        private static int SleightOfHandModifier => SleightOfHandProficiency ? DexterityMod + ProficiencyBonus : DexterityMod;
        private static int StealthModifier => StealthProficiency ? DexterityMod + ProficiencyBonus : DexterityMod;
        public static string Acrobatics => AcrobaticsModifier.ToString("+0;-#");
        public static string SleightOfHand => SleightOfHandModifier.ToString("+0;-#");
        public static string Stealth => StealthModifier.ToString("+0;-#");

        public static bool ArcanaProficiency => ProficiencyManager.CheckByName("Arcana", Interface.ProficiencyType.SKILL);
        public static bool HistoryProficiency => ProficiencyManager.CheckByName("History", Interface.ProficiencyType.SKILL);
        public static bool InvestigationProficiency => ProficiencyManager.CheckByName("Investigation", Interface.ProficiencyType.SKILL);
        public static bool NatureProficiency => ProficiencyManager.CheckByName("Nature", Interface.ProficiencyType.SKILL);
        public static bool ReligionProficiency => ProficiencyManager.CheckByName("Religion", Interface.ProficiencyType.SKILL);
        private static int ArcanaModifier => ArcanaProficiency ? IntelligenceMod + ProficiencyBonus : IntelligenceMod;
        private static int HistoryModifier => HistoryProficiency ? IntelligenceMod + ProficiencyBonus : IntelligenceMod;
        private static int InvestigationModifier => InvestigationProficiency ? IntelligenceMod + ProficiencyBonus : IntelligenceMod;
        private static int NatureModifier => NatureProficiency ? IntelligenceMod + ProficiencyBonus : IntelligenceMod;
        private static int ReligionModifier => ReligionProficiency ? IntelligenceMod + ProficiencyBonus : IntelligenceMod;
        public static string Arcana => ArcanaModifier.ToString("+0;-#");
        public static string History => HistoryModifier.ToString("+0;-#");
        public static string Investigation => InvestigationModifier.ToString("+0;-#");
        public static string Nature => NatureModifier.ToString("+0;-#");
        public static string Religion => ReligionModifier.ToString("+0;-#");


        public static bool AnimalHandlingProficiency => ProficiencyManager.CheckByName("Animal Handling", Interface.ProficiencyType.SKILL);
        public static bool InsightProficiency => ProficiencyManager.CheckByName("Insight", Interface.ProficiencyType.SKILL);
        public static bool MedicineProficiency => ProficiencyManager.CheckByName("Medicine", Interface.ProficiencyType.SKILL);
        public static bool PerceptionProficiency => ProficiencyManager.CheckByName("Perception", Interface.ProficiencyType.SKILL);
        public static bool SurvivalProficiency => ProficiencyManager.CheckByName("Survival", Interface.ProficiencyType.SKILL);
        private static int AnimalHandlingModifier => AnimalHandlingProficiency ? WisdomMod + ProficiencyBonus : WisdomMod;
        private static int InsightModifier => InsightProficiency ? WisdomMod + ProficiencyBonus : WisdomMod;
        private static int MedicineModifier => MedicineProficiency ? WisdomMod + ProficiencyBonus : WisdomMod;
        private static int PerceptionModifier => PerceptionProficiency ? WisdomMod + ProficiencyBonus : WisdomMod;
        private static int SurvivalModifier => SurvivalProficiency ? WisdomMod + ProficiencyBonus : WisdomMod;
        public static string AnimalHandling => AnimalHandlingModifier.ToString("+0;-#");
        public static string Insight => InsightModifier.ToString("+0;-#");
        public static string Medicine => MedicineModifier.ToString("+0;-#");
        public static string Perception => PerceptionModifier.ToString("+0;-#");
        public static string Survival => SurvivalModifier.ToString("+0;-#");

        public static bool DeceptionProficiency => ProficiencyManager.CheckByName("Deception", Interface.ProficiencyType.SKILL);
        public static bool IntimidationProficiency => ProficiencyManager.CheckByName("Intimidation", Interface.ProficiencyType.SKILL);
        public static bool PerformanceProficiency => ProficiencyManager.CheckByName("Performance", Interface.ProficiencyType.SKILL);
        public static bool PersuasionProficiency => ProficiencyManager.CheckByName("Persuasion", Interface.ProficiencyType.SKILL);
        private static int DeceptionModifier => DeceptionProficiency ? CharismaMod + ProficiencyBonus : CharismaMod;
        private static int IntimidationModifier => IntimidationProficiency ? CharismaMod + ProficiencyBonus : CharismaMod;
        private static int PerformanceModifier => PerformanceProficiency ? CharismaMod + ProficiencyBonus : CharismaMod;
        private static int PersuasionModifier => PersuasionProficiency ? CharismaMod + ProficiencyBonus : CharismaMod;
        public static string Deception => DeceptionModifier.ToString("+0;-#");
        public static string Intimidation => IntimidationModifier.ToString("+0;-#");
        public static string Performance => PerformanceModifier.ToString("+0;-#");
        public static string Persuasion => PersuasionModifier.ToString("+0;-#");

        //Passives
        public static int PassivePerception => 10 + PerceptionModifier;
    }
}
