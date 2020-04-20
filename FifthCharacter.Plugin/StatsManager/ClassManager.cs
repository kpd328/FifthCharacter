using FifthCharacter.Plugin.Interface;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter.Plugin.StatsManager {
    /// <summary>
    /// As a note, this is very TEMPORARY.
    /// PLEASE, reimplement with something
    /// more sophisticated, integrating
    /// into player class classes ((eww))
    /// </summary>
    public static class ClassManager {
        public static IList<IPlayerClass> Classes { get; private set; } = new List<IPlayerClass>();
        public static IPlayerClass PrimaryClass { get; private set; }

        public static string ClassAndLevelText {
            get {
                StringBuilder _return = new StringBuilder();

                foreach(IPlayerClass playerClass in Classes) {
                    _return.Append(string.Format("{0} {1} ", playerClass.Name, playerClass.Level));
                }

                return _return.ToString().Trim();
            }
        }

        public static void TakeInitialClass(IPlayerClass playerClass) {
            PrimaryClass = playerClass.TakeAsPrimaryClass();
            Classes.Clear();
            Classes.Add(PrimaryClass);
        }
    }
}
