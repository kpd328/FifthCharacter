using FifthCharacter.Plugin.Features.Abstract;
using FifthCharacter.Plugin.Interface;
using WotC.FifthEd.SRD.Features.PlayerClass.Fighter;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Ranger {
    public class FRangerFightingStyle : AFeatureRanger {
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
                    case FightingStyle.TWOWEAPONFIGHTING:
                        return FightingStyleText.TwoWeaponFighting;
                }
                return FeatureFighterText.Fighting_Style;
            }
        }
        public FightingStyle FightingStyle { get; private set; }
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        internal FRangerFightingStyle() { }

        public FRangerFightingStyle(bool isTaken) {
            //TODO: Prompt to pick Fighting Style and remove Protection and Greatweapon Fighting
        }

        public override IFeature GetInstance() => new FRangerFightingStyle(true);
    }
}
