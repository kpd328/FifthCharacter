using FifthCharacter.Plugin.StatsManager;

namespace FifthCharacter.Plugin.Attacks.Abstract {
    public abstract class ASimpleMeleeWeapon : ASimpleWeapon {
        public override string Range => "5 feet";
        public override string WeaponType => "Simple Melee Weapon";
        private int SpecialBonus { get; } = 0;
        public override string AttackBonus {
            get {
                var _temp = AbilityManager.StrengthMod + SpecialBonus;
                if (ProficiencyManager.CheckByName("Simple Weapons", Interface.ProficiencyType.WEAPON)
                    || ProficiencyManager.CheckByName("Simple Melee Weapons", Interface.ProficiencyType.WEAPON)
                    || ProficiencyManager.CheckByName(Name, Interface.ProficiencyType.WEAPON)) {
                    _temp += AbilityManager.ProficiencyBonus;
                }

                return _temp.ToString("+0;-#");
            }
        }
    }
}
