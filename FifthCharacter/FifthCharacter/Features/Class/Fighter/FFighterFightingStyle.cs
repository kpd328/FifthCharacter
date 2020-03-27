namespace FifthCharacter.Features.Class.Fighter {
    public class FFighterFightingStyle : AFeatureFighter {
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
                return FeatureFighterText.FightingStyle;
            }
        }
        public FightingStyle FightingStyle { get; private set; }
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public FFighterFightingStyle(FightingStyle style) => FightingStyle = style;
    }

    public enum FightingStyle {
        ARCHERY,
        DEFENSE,
        DUELING,
        GREATWEAPONFIGHTING,
        PROTECTION,
        TWOWEAPONFIGHTING
    }
}
