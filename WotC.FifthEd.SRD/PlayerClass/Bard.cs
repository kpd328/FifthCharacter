﻿using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Proficiencies.Armor;
using FifthCharacter.Plugin.Proficiencies.Attacks;
using FifthCharacter.Plugin.Proficiencies.SavingThrows;
using FifthCharacter.Plugin.StatsManager;
using FifthCharacter.Plugin.Tools;
using SD.Tools.Algorithmia.GeneralDataStructures;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon;
using WotC.FifthEd.SRD.Proficiencies.Attacks.MartialRangedWeapon;

namespace WotC.FifthEd.SRD.PlayerClass {
    public class Bard : IPlayerClass {
        private const int SUBCLASS_LEVEL = 3;
        private const string SOURCE_TEXT = "Class Bard";
        public string Name => "Bard";
        public string ID => "SRD.PlayerClass.Bard";
        public int Level { get; private set; }
        public Dice HitDicePerLevel => new Dice(1, 8);
        public Dice CurrentTotalHitDice { get; private set; }
        public IList<IFeature> ClassFeatures => new List<IFeature>();
        private MultiValueDictionary<int, IFeature> AllClassFeatures => new MultiValueDictionary<int, IFeature>() {

        };

        internal Bard() { }

        private Bard(bool isPrimary) : base() {
            if (isPrimary) {
                ProficiencyManager.Proficiencies.Add(new ProfDexteritySave(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfCharismaSave(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSimpleWeapon(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfMRWHandCrossbow(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfMMWLongsword(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfMMWRapier(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfMMWShortsword(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorLight(SOURCE_TEXT));
                //TODO: prompt to pick skills
            } else {
                ProficiencyManager.Proficiencies.Add(new ProfArmorLight(SOURCE_TEXT));
                //TODO: prompt to pick skills
            }
        }

        public IPlayerClass TakeAsPrimaryClass() => new Bard(true) { Level = 1, CurrentTotalHitDice = new Dice(HitDicePerLevel) };
        public IPlayerClass TakeAsSecondaryClass() => new Bard(false) { Level = 1, CurrentTotalHitDice = new Dice(HitDicePerLevel) };

        public void LevelUp() {
            Level++;
            CurrentTotalHitDice.Number++;
            if (Level == SUBCLASS_LEVEL) {
                SelectSubclass();
            }
            var newFeatures = AllClassFeatures.GetValues(Level, true);
            foreach (IFeature f in newFeatures) {
                ClassFeatures.Add(f);
            }
        }

        private void SelectSubclass() {
            //Popup a prompt to select a subclass (or add prompt to levelup popup queue
        }
    }
}
