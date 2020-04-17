using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FifthCharacter.Plugin.StatsManager {
    public static class ProficiencyManager {
        //TODO: Save scores to static location

        public static IList<IProficiency> Proficiencies { get; private set; } = new List<IProficiency>();

        public static bool CheckByName(string name) => Proficiencies.Any(n => n.Name == name);
        public static bool CheckByName(string name, ProficiencyType type) => Proficiencies.Where(t => t.ProficiencyType == type).Any(n => n.Name == name);
        
    }
}
