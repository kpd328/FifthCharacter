using FifthCharacter.Plugin.StatsManager;
using System.ComponentModel;

namespace FifthCharacter.Abilities {
    public class IntelligenceAbility : AAbilityVM, INotifyPropertyChanged {
        public override string AbilityName => "Intelligence";
        public override string AbilityScore => AbilityManager.IntelligenceScore.ToString();
        public override string AbilityModifier => AbilityManager.IntelligenceModifier;

        public override string Skill1Name => "Arcana";
        public override string Skill2Name => "History";
        public override string Skill3Name => "Investigation";
        public override string Skill4Name => "Nature";
        public override string Skill5Name => "Religion";

        public override string SavingThrowModifier => AbilityManager.IntelligenceSave;
        public override string Skill1Modifier => AbilityManager.Arcana;
        public override string Skill2Modifier => AbilityManager.History;
        public override string Skill3Modifier => AbilityManager.Investigation;
        public override string Skill4Modifier => AbilityManager.Nature;
        public override string Skill5Modifier => AbilityManager.Religion;

        public override bool SavingThrowProficiency => AbilityManager.IntelligenceSaveProficiency;
        public override bool Skill1Proficiency => AbilityManager.ArcanaProficiency;
        public override bool Skill2Proficiency => AbilityManager.HistoryProficiency;
        public override bool Skill3Proficiency => AbilityManager.InvestigationProficiency;
        public override bool Skill4Proficiency => AbilityManager.NatureProficiency;
        public override bool Skill5Proficiency => AbilityManager.ReligionProficiency;

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
