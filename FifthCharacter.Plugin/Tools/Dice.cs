namespace FifthCharacter.Plugin.Tools {
    public class Dice {
        public int Number { get; set; }
        public int DieBase { get; set; }
        public new string ToString => string.Format("{0}d{1}", Number, DieBase);

        public Dice(int num, int die) {
            Number = num;
            DieBase = die;
        }

        public Dice(string die) {
            var _d = die.Split('d');
            Number = int.Parse(_d[0]);
            DieBase = int.Parse(_d[1]);
        }

        public Dice(Dice toCopy) {
            this.Number = toCopy.Number;
            this.DieBase = toCopy.DieBase;
        }
    }
}
