using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;

namespace FifthCharacter.Plugin.StatsManager {
    public static class ProficiencyManager {
        //TODO: Save proficiencies to static location

        public static ObservableCollection<IProficiency> Proficiencies { get; private set; } = new ObservableCollection<IProficiency>();
        public static ObservableCollection<IProficiency> ArmorProficiencies => new ObservableCollection<IProficiency>(Proficiencies.Where(p => p.ProficiencyType == ProficiencyType.ARMOR));
        public static ObservableCollection<IProficiency> WeaponProficiencies => new ObservableCollection<IProficiency>(Proficiencies.Where(p => p.ProficiencyType == ProficiencyType.WEAPON));
        public static ObservableCollection<IProficiency> ToolProficiencies => new ObservableCollection<IProficiency>(Proficiencies.Where(p => p.ProficiencyType == ProficiencyType.TOOL));
        public static ObservableCollection<IProficiency> SavingThrowProficiencies => new ObservableCollection<IProficiency>(Proficiencies.Where(p => p.ProficiencyType == ProficiencyType.SAVING_THROW));
        public static ObservableCollection<IProficiency> SkillProficiencies => new ObservableCollection<IProficiency>(Proficiencies.Where(p => p.ProficiencyType == ProficiencyType.SKILL));
        public static ObservableCollection<IProficiency> LanguageProficiencies => new ObservableCollection<IProficiency>(Proficiencies.Where(p => p.ProficiencyType == ProficiencyType.LANGUAGE));

        public static ObservableCollection<IProficiency> AllProficienciesOfType(ProficiencyType type) => type switch
        {
            ProficiencyType.ARMOR => ArmorProficiencies,
            ProficiencyType.WEAPON => WeaponProficiencies,
            ProficiencyType.TOOL => ToolProficiencies,
            ProficiencyType.SAVING_THROW => ToolProficiencies,
            ProficiencyType.SKILL => SkillProficiencies,
            ProficiencyType.LANGUAGE => LanguageProficiencies,
            _ => throw new System.NotImplementedException(),
        };

        public static bool CheckByName(string name) => Proficiencies.Any(n => n.Name == name);
        public static bool CheckByName(string name, ProficiencyType type) => Proficiencies.Where(t => t.ProficiencyType == type).Any(n => n.Name == name);

        public static void RemoveClassProficiencies() {
            var _toDelete = new List<IProficiency>();
            foreach (var p in Proficiencies) {
                if (p.Source.StartsWith("Class")) {
                    _toDelete.Add(p);
                }
            }
            foreach (var p in _toDelete) {
                Proficiencies.Remove(p);
            }
        }

        public static void RemoveRaceProficiencies() {
            var _toDelete = new List<IProficiency>();
            foreach(var p in Proficiencies) {
                if (p.Source.StartsWith("Race")) {
                    _toDelete.Add(p);
                }
            }
            foreach(var p in _toDelete) {
                Proficiencies.Remove(p);
            }
        }

        public static void RemoveBackgroundProficiencies() {
            var _toDelete = new List<IProficiency>();
            foreach (var p in Proficiencies) {
                if (p.Source.StartsWith("Background")) {
                    _toDelete.Add(p);
                }
            }
            foreach (var p in _toDelete) {
                Proficiencies.Remove(p);
            }
        }
    }
}
