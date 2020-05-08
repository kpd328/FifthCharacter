using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections.ObjectModel;

namespace FifthCharacter.Plugin.StatsManager {
    public static class ProficiencyManager {
        //TODO: Save scores to static location

        public static ObservableCollection<IProficiency> Proficiencies { get; private set; } = new ObservableCollection<IProficiency>();

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
