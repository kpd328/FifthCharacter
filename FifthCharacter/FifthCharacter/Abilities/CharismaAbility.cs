using FifthCharacter.Plugin.StatsManager;
using System.ComponentModel;

namespace FifthCharacter.Abilities {
    public class CharismaAbility : AAbilityVM, INotifyPropertyChanged {
        public override string AbilityName => "Charisma";
        public override string AbilityScore => AbilityManager.CharismaScore.ToString();
        public override string AbilityModifier => AbilityManager.CharismaModifier;

        public override string Skill1Name => "Deception";
        public override string Skill2Name => "Intimidation";
        public override string Skill3Name => "Performance";
        public override string Skill4Name => "Persuasion";
        public override string Skill5Name => "";

        public override string SavingThrowModifier => AbilityManager.CharismaSave;
        public override string Skill1Modifier => AbilityManager.Deception;
        public override string Skill2Modifier => AbilityManager.Intimidation;
        public override string Skill3Modifier => AbilityManager.Performance;
        public override string Skill4Modifier => AbilityManager.Persuasion;
        public override string Skill5Modifier => "";

        public override bool SavingThrowProficiency => AbilityManager.CharismaSaveProficiency;
        public override bool Skill1Proficiency => AbilityManager.DeceptionProficiency;
        public override bool Skill2Proficiency => AbilityManager.IntimidationProficiency;
        public override bool Skill3Proficiency => AbilityManager.PerformanceProficiency;
        public override bool Skill4Proficiency => AbilityManager.PersuasionProficiency;
        public override bool Skill5Proficiency => false;

        public override bool Skill1Exists => true;
        public override bool Skill2Exists => true;
        public override bool Skill3Exists => true;
        public override bool Skill4Exists => true;
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
            OnPropertyChanged("Skill4Modifier");

            OnPropertyChanged("SavingThrowProficiency");
            OnPropertyChanged("Skill1Proficiency");
            OnPropertyChanged("Skill2Proficiency");
            OnPropertyChanged("Skill3Proficiency");
            OnPropertyChanged("Skill4Proficiency");
        }
    }
}
