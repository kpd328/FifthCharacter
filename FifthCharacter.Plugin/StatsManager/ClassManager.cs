using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Tools;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FifthCharacter.Plugin.StatsManager {
    public static class ClassManager {
        public static IList<IPlayerClass> Classes { get; private set; } = new List<IPlayerClass>();
        public static IPlayerClass PrimaryClass { get; private set; }
        public static CompoundDice HitDiceTotal { get; private set; } = new CompoundDice();
        public static CompoundDice HitDiceCurrent { get; private set; } = new CompoundDice();
        public static int TotalLevel {
            get {
                int _return = 0;
                foreach(var c in Classes) {
                    _return += c.Level;
                }
                return _return;
            }
        }

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
            FeaturesManager.RemoveClassFeatures();
            ProficiencyManager.RemoveClassProficiencies();
            PrimaryClass = playerClass.TakeAsPrimaryClass();
            Classes.Clear();
            Classes.Add(PrimaryClass);
            HitDiceTotal = new CompoundDice(PrimaryClass.CurrentTotalHitDice);
            HitDiceCurrent = new CompoundDice(HitDiceTotal);
        }

        public static int ClassLevel(string playerclass) {
            if (Classes.Any(c => c.Name.Equals(playerclass))) {
                return Classes.Where(c => c.Name.Equals(playerclass)).FirstOrDefault().Level;
            }
            return 0;
        }
    }
}
