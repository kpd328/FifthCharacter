using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter {
    public static class AbilityManager {
        //TODO: Save scores to static location

        //Raw Ability Scores
        public static int StrengthScore { get; set; }
        public static int DexterityScore { get; set; }
        public static int ConstitutionScore { get; set; }
        public static int IntelligenceScore { get; set; }
        public static int WisdomScore { get; set; }
        public static int CharismaScore { get; set; }
        public static int ProficiencyBonus { get; set; }

        //Ability Score Modifiers
        private static int StrengthMod => (StrengthScore - 10) / 2;
        private static int DexterityMod => (DexterityScore - 10) / 2;
        private static int ConstitutionMod => (ConstitutionScore - 10) / 2;
        private static int IntelligenceMod => (IntelligenceScore - 10) / 2;
        private static int WisdomMod => (WisdomScore - 10) / 2;
        private static int CharismaMod => (CharismaScore - 10) / 2;

        public static string StrengthModifier => StrengthMod.ToString("+0;-#");
        public static string DexterityModifier => DexterityMod.ToString("+0;-#");
        public static string ConstitutionModifier => ConstitutionMod.ToString("+0;-#");
        public static string IntelligenceModifier => IntelligenceMod.ToString("+0;-#");
        public static string WisdomModifier => WisdomMod.ToString("+0;-#");
        public static string CharismaModifier => CharismaMod.ToString("+0;-#");

        //Saving Throws
        public static bool StrengthSaveProficiency { get; set; }
        public static bool DexteritySaveProficiency { get; set; }
        public static bool ConstitutionSaveProficiency { get; set; }
        public static bool IntelligenceSaveProficiency { get; set; }
        public static bool WisdomSaveProficiency { get; set; }
        public static bool CharismaSaveProficiency { get; set; }

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
        public static bool AthleticsProficiency { get; set; }
        private static int AthleticsModifier => AthleticsProficiency ? StrengthMod + ProficiencyBonus : StrengthMod;
        public static string Athletics => AthleticsModifier.ToString("+0;-#");

        public static bool AcrobaticsProficiency { get; set; }
        public static bool SleightOfHandProficiency { get; set; }
        public static bool StealthProficiency { get; set; }
        private static int AcrobaticsModifier => AcrobaticsProficiency ? DexterityMod + ProficiencyBonus : DexterityMod;
        private static int SleightOfHandModifier => SleightOfHandProficiency ? DexterityMod + ProficiencyBonus : DexterityMod;
        private static int StealthModifier => StealthProficiency ? DexterityMod + ProficiencyBonus : DexterityMod;
        public static string Acrobatics => AcrobaticsModifier.ToString("+0;-#");
        public static string SleightOfHand => SleightOfHandModifier.ToString("+0;-#");
        public static string Stealth => StealthModifier.ToString("+0;-#");

        public static bool ArcanaProficiency { get; set; }
        public static bool HistoryProficiency { get; set; }
        public static bool InvestigationProficiency { get; set; }
        public static bool NatureProficiency { get; set; }
        public static bool ReligionProficiency { get; set; }
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


        public static bool AnimalHandlingProficiency { get; set; }
        public static bool InsightProficiency { get; set; }
        public static bool MedicineProficiency { get; set; }
        public static bool PerceptionProficiency { get; set; }
        public static bool SurvivalProficiency { get; set; }
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

        public static bool DeceptionProficiency { get; set; }
        public static bool IntimidationProficiency { get; set; }
        public static bool PerformanceProficiency { get; set; }
        public static bool PersuasionProficiency { get; set; }
        private static int DeceptionModifier => DeceptionProficiency ? CharismaMod + ProficiencyBonus : CharismaMod;
        private static int IntimidationModifier => IntimidationProficiency ? CharismaMod + ProficiencyBonus : CharismaMod;
        private static int PerformanceModifier => PerformanceProficiency ? CharismaMod + ProficiencyBonus : CharismaMod;
        private static int PersuasionModifier => PersuasionProficiency? CharismaMod + ProficiencyBonus : CharismaMod;
        public static string Deception => DeceptionModifier.ToString("+0;-#");
        public static string Intimidation => IntimidationModifier.ToString("+0;-#");
        public static string Performance => PerformanceModifier.ToString("+0;-#");
        public static string Persuasion => PersuasionModifier.ToString("+0;-#");

        //Passives
        public static int PassivePerception => 10 + PerceptionModifier;
    }
}
