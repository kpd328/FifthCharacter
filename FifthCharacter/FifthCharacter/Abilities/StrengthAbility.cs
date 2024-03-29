﻿using FifthCharacter.Plugin.StatsManager;
using System.ComponentModel;

namespace FifthCharacter.Abilities {
    public class StrengthAbility : AAbilityVM, INotifyPropertyChanged {
        public override string AbilityName => "Strength";
        public override string AbilityScore => AbilityManager.StrengthScore.ToString();
        public override string AbilityModifier => AbilityManager.StrengthModifier;

        public override string Skill1Name => "Athletics";
        public override string Skill2Name => "";
        public override string Skill3Name => "";
        public override string Skill4Name => "";
        public override string Skill5Name => "";

        public override string SavingThrowModifier => AbilityManager.StrengthSave;
        public override string Skill1Modifier => AbilityManager.Athletics;
        public override string Skill2Modifier => "";
        public override string Skill3Modifier => "";
        public override string Skill4Modifier => "";
        public override string Skill5Modifier => "";

        public override bool SavingThrowProficiency => AbilityManager.StrengthSaveProficiency;
        public override bool Skill1Proficiency => AbilityManager.AthleticsProficiency;
        public override bool Skill2Proficiency => false;
        public override bool Skill3Proficiency => false;
        public override bool Skill4Proficiency => false;
        public override bool Skill5Proficiency => false;

        public override bool Skill1Exists => true;
        public override bool Skill2Exists => false;
        public override bool Skill3Exists => false;
        public override bool Skill4Exists => false;
        public override bool Skill5Exists => false;

        public event PropertyChangedEventHandler PropertyChanged;
        public override void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public override void AllPropertiesChanged() {
            OnPropertyChanged("AbilityScore");
            OnPropertyChanged("AbilityModifier");

            OnPropertyChanged("SavingThrowModifier");
            OnPropertyChanged("Skill1Modifier");

            OnPropertyChanged("SavingThrowProficiency");
            OnPropertyChanged("Skill1Proficiency");
        }
    }
}
