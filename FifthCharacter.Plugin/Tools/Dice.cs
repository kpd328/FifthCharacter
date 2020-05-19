using System.Collections.Generic;
using System.Text;

namespace FifthCharacter.Plugin.Tools {
    public class Dice {
        public int Number { get; set; }
        public int DieBase { get; set; }
        public override string ToString() => string.Format("{0}d{1}", Number, DieBase);

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

    public class CompoundDice {
        public Dice d4s = new Dice(0, 4);
        public Dice d6s = new Dice(0, 6);
        public Dice d8s = new Dice(0, 8);
        public Dice d10s = new Dice(0, 10);
        public Dice d12s = new Dice(0, 12);
        public Dice d20s = new Dice(0, 20);
        public List<Dice> Misc = new List<Dice>();

        public CompoundDice(params Dice[] dice) {
            foreach(Dice die in dice) {
                switch (die.DieBase) {
                    case 4:
                        d4s.Number++;
                        break;
                    case 6:
                        d6s.Number++;
                        break;
                    case 8:
                        d8s.Number++;
                        break;
                    case 10:
                        d10s.Number++;
                        break;
                    case 12:
                        d12s.Number++;
                        break;
                    case 20:
                        d20s.Number++;
                        break;
                    default:
                        Misc.Add(new Dice(die));
                        break;
                }
            }
        }

        public CompoundDice(CompoundDice toCopy) {
            d4s = new Dice(toCopy.d4s);
            d6s = new Dice(toCopy.d6s);
            d8s = new Dice(toCopy.d8s);
            d10s = new Dice(toCopy.d10s);
            d12s = new Dice(toCopy.d12s);
            d20s = new Dice(toCopy.d20s);
            Misc = new List<Dice>(toCopy.Misc);
        }

        public override string ToString() {
            StringBuilder _return = new StringBuilder();
            if(d4s.Number > 0) {
                _return.Append(d4s.ToString());
                _return.Append(' ');
            }
            if (d6s.Number > 0) {
                _return.Append(d6s.ToString());
                _return.Append(' ');
            }
            if (d8s.Number > 0) {
                _return.Append(d8s.ToString());
                _return.Append(' ');
            }
            if (d10s.Number > 0) {
                _return.Append(d10s.ToString());
                _return.Append(' ');
            }
            if (d12s.Number > 0) {
                _return.Append(d12s.ToString());
                _return.Append(' ');
            }
            if (d20s.Number > 0) {
                _return.Append(d20s.ToString());
            }
            return string.Format("{0} {1}", _return.ToString().Trim(), AsDiceString(Misc)).Trim();
        }

        public static string AsDiceString(IEnumerable<Dice> dice) {
            StringBuilder _return = new StringBuilder();
            foreach(Dice die in dice) {
                _return.Append(die.ToString());
                _return.Append(' ');
            }
            return _return.ToString().Trim();
        }

        public void ReduceDice(Dice die) {
            switch (die.DieBase) {
                case 4:
                    d4s.Number--;
                    break;
                case 6:
                    d6s.Number--;
                    break;
                case 8:
                    d8s.Number--;
                    break;
                case 10:
                    d10s.Number--;
                    break;
                case 12:
                    d12s.Number--;
                    break;
                case 20:
                    d20s.Number--;
                    break;
                default:
                    //TODO: search for die base in list
                    break;
            }
        }

        public void ReduceDice(int type) {
            switch (type) {
                case 4:
                    d4s.Number--;
                    break;
                case 6:
                    d6s.Number--;
                    break;
                case 8:
                    d8s.Number--;
                    break;
                case 10:
                    d10s.Number--;
                    break;
                case 12:
                    d12s.Number--;
                    break;
                case 20:
                    d20s.Number--;
                    break;
                default:
                    //TODO: search for die base in list
                    break;
            }
        }
    }
}
