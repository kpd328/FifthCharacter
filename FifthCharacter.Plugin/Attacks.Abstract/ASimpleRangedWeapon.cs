using FifthCharacter.Plugin.StatsManager;

namespace FifthCharacter.Plugin.Attacks.Abstract {
    public abstract class ASimpleRangedWeapon : ASimpleWeapon {
        public override string WeaponType => "Simple Ranged Weapon";
        private int SpecialBonus { get; } = 0;
        public override string AttackBonus {
            get {
                var _temp = AbilityManager.DexterityMod + SpecialBonus;
                if (ProficiencyManager.CheckByName("Simple Weapons", Interface.ProficiencyType.WEAPON)
                    || ProficiencyManager.CheckByName("Simple Ranged Weapons", Interface.ProficiencyType.WEAPON)
                    || ProficiencyManager.CheckByName(Name, Interface.ProficiencyType.WEAPON)) {
                    _temp += AbilityManager.ProficiencyBonus;
                }

                return _temp.ToString("+0;-#");
            }
        }
    }
}
