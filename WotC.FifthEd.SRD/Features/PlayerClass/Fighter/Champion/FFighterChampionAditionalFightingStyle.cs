using FifthCharacter.Plugin.Features.Abstract;
using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Fighter.Champion {
    public class FFighterChampionAditionalFightingStyle : AFeatureFighterChampion {
        public override string Name {
            get {
                string _style = "";
                switch (FightingStyle) {
                    case FightingStyle.ARCHERY:
                        _style = "Archery";
                        break;
                    case FightingStyle.DEFENSE:
                        _style = "Defense";
                        break;
                    case FightingStyle.DUELING:
                        _style = "Dueling";
                        break;
                    case FightingStyle.GREATWEAPONFIGHTING:
                        _style = "Great Weapon Fighting";
                        break;
                    case FightingStyle.PROTECTION:
                        _style = "Protection";
                        break;
                    case FightingStyle.TWOWEAPONFIGHTING:
                        _style = "Two-Weapon Fighting";
                        break;
                    default:
                        break;
                }
                return string.Format("Fighting Style ({0})", _style);
            }
        }
        public override string Text {
            get {
                switch (FightingStyle) {
                    case FightingStyle.ARCHERY:
                        return FightingStyleText.Archery;
                    case FightingStyle.DEFENSE:
                        return FightingStyleText.Defense;
                    case FightingStyle.DUELING:
                        return FightingStyleText.Dueling;
                    case FightingStyle.GREATWEAPONFIGHTING:
                        return FightingStyleText.GreatWeaponFighting;
                    case FightingStyle.PROTECTION:
                        return FightingStyleText.Protection;
                    case FightingStyle.TWOWEAPONFIGHTING:
                        return FightingStyleText.TwoWeaponFighting;
                }
                return FeatureFighterText.Fighting_Style;
            }
        }
        public FightingStyle FightingStyle { get; private set; }
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        internal FFighterChampionAditionalFightingStyle() { }

        public FFighterChampionAditionalFightingStyle(bool isTaken) {
            //TODO: Prompt to pick Fighting Style
        }

        public override IFeature GetInstance() => new FFighterChampionAditionalFightingStyle(true);
    }
}
