using FifthCharacter.Plugin.StatsManager;

namespace FifthCharacter.Plugin.Attacks.Abstract {
    public abstract class AMartialRangedWeapon : AMartialWeapon {
        public override string WeaponType => "Martial Ranged Weapon";
        private int SpecialBonus { get; } = 0;
        public override string AttackBonus {
            get {
                var _temp = AbilityManager.DexterityMod + SpecialBonus;
                if (ProficiencyManager.CheckByName("Martial Weapons", Interface.ProficiencyType.WEAPON)
                    || ProficiencyManager.CheckByName("Martial Ranged Weapons", Interface.ProficiencyType.WEAPON)
                    || ProficiencyManager.CheckByName(Name, Interface.ProficiencyType.WEAPON)) {
                    _temp += AbilityManager.ProficiencyBonus;
                }

                return _temp.ToString("+0;-#");
            }
        }
    }
}
