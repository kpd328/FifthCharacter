﻿using FifthCharacter.Plugin.StatsManager;
using System.ComponentModel;

namespace FifthCharacter.Abilities {
    public class DexterityAbility : AAbilityVM, INotifyPropertyChanged {
        public override string AbilityName => "Dexterity";
        public override string AbilityScore => AbilityManager.DexterityScore.ToString();
        public override string AbilityModifier => AbilityManager.DexterityModifier;

        public override string Skill1Name => "Acrobatics";
        public override string Skill2Name => "Sleight of Hand";
        public override string Skill3Name => "Stealth";
        public override string Skill4Name => "";
        public override string Skill5Name => "";

        public override string SavingThrowModifier => AbilityManager.DexteritySave;
        public override string Skill1Modifier => AbilityManager.Acrobatics;
        public override string Skill2Modifier => AbilityManager.SleightOfHand;
        public override string Skill3Modifier => AbilityManager.Stealth;
        public override string Skill4Modifier => "";
        public override string Skill5Modifier => "";

        public override bool SavingThrowProficiency => AbilityManager.DexteritySaveProficiency;
        public override bool Skill1Proficiency => AbilityManager.AcrobaticsProficiency;
        public override bool Skill2Proficiency => AbilityManager.SleightOfHandProficiency;
        public override bool Skill3Proficiency => AbilityManager.StealthProficiency;
        public override bool Skill4Proficiency => false;
        public override bool Skill5Proficiency => false;

        public override bool Skill1Exists => true;
        public override bool Skill2Exists => true;
        public override bool Skill3Exists => true;
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
            OnPropertyChanged("Skill2Modifier");
            OnPropertyChanged("Skill3Modifier");

            OnPropertyChanged("SavingThrowProficiency");
            OnPropertyChanged("Skill1Proficiency");
            OnPropertyChanged("Skill2Proficiency");
            OnPropertyChanged("Skill3Proficiency");
        }
    }
}
