﻿using FifthCharacter.Plugin.StatsManager;
using System.ComponentModel;

namespace FifthCharacter.Abilities {
    public class WisdomAbility : AAbilityVM, INotifyPropertyChanged {
        public override string AbilityName => "Wisdom";
        public override string AbilityScore => AbilityManager.WisdomScore.ToString();
        public override string AbilityModifier => AbilityManager.WisdomModifier;

        public override string Skill1Name => "Animal Handling";
        public override string Skill2Name => "Insight";
        public override string Skill3Name => "Medicine";
        public override string Skill4Name => "Perception";
        public override string Skill5Name => "Survival";

        public override string SavingThrowModifier => AbilityManager.WisdomSave;
        public override string Skill1Modifier => AbilityManager.AnimalHandling;
        public override string Skill2Modifier => AbilityManager.Insight;
        public override string Skill3Modifier => AbilityManager.Medicine;
        public override string Skill4Modifier => AbilityManager.Perception;
        public override string Skill5Modifier => AbilityManager.Survival;

        public override bool SavingThrowProficiency => AbilityManager.WisdomSaveProficiency;
        public override bool Skill1Proficiency => AbilityManager.AnimalHandlingProficiency;
        public override bool Skill2Proficiency => AbilityManager.InsightProficiency;
        public override bool Skill3Proficiency => AbilityManager.MedicineProficiency;
        public override bool Skill4Proficiency => AbilityManager.PerceptionProficiency;
        public override bool Skill5Proficiency => AbilityManager.SurvivalProficiency;

        public override bool Skill1Exists => true;
        public override bool Skill2Exists => true;
        public override bool Skill3Exists => true;
        public override bool Skill4Exists => true;
        public override bool Skill5Exists => true;

        public event PropertyChangedEventHandler PropertyChanged;
        public override void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public override void AllPropertiesChanged() {
            OnPropertyChanged("AbilityScore");
            OnPropertyChanged("AbilityModifier");

            OnPropertyChanged("SavingThrowModifier");
            OnPropertyChanged("Skill1Modifier");
            OnPropertyChanged("Skill2Modifier");
            OnPropertyChanged("Skill3Modifier");
            OnPropertyChanged("Skill4Modifier");
            OnPropertyChanged("Skill5Modifier");

            OnPropertyChanged("SavingThrowProficiency");
            OnPropertyChanged("Skill1Proficiency");
            OnPropertyChanged("Skill2Proficiency");
            OnPropertyChanged("Skill3Proficiency");
            OnPropertyChanged("Skill4Proficiency");
            OnPropertyChanged("Skill5Proficiency");
        }
    }
}
