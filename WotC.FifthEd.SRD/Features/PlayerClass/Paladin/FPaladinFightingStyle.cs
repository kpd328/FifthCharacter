using FifthCharacter.Plugin.Features.Abstract;
using FifthCharacter.Plugin.Interface;
using WotC.FifthEd.SRD.Features.PlayerClass.Fighter;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Paladin {
    public class FPaladinFightingStyle : AFeaturePaladin {
        public override string Name {
            get {
                string _style = "";
                switch (FightingStyle) {
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
                }
                return string.Format("Fighting Style ({0})", _style);
            }
        }
        public override string Text {
            get {
                switch (FightingStyle) {
                    case FightingStyle.DEFENSE:
                        return FightingStyleText.Defense;
                    case FightingStyle.DUELING:
                        return FightingStyleText.Dueling;
                    case FightingStyle.GREATWEAPONFIGHTING:
                        return FightingStyleText.GreatWeaponFighting;
                    case FightingStyle.PROTECTION:
                        return FightingStyleText.Protection;
                }
                return FeatureFighterText.Fighting_Style;
            }
        }
        public FightingStyle FightingStyle { get; private set; }
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        internal FPaladinFightingStyle() { }

        public FPaladinFightingStyle(bool isTaken) {
            //TODO: Prompt to pick Fighting Style, excluding Archery and Two-Weapon Fighting
        }

        public override IFeature GetInstance() => new FPaladinFightingStyle();
    }
}
