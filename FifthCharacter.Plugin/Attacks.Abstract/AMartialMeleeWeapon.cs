using FifthCharacter.Plugin.StatsManager;

namespace FifthCharacter.Plugin.Attacks.Abstract {
    public abstract class AMartialMeleeWeapon : AMartialWeapon {
        public override string Range => "5 feet";
        public override string WeaponType => "Martial Melee Weapon";
        private int SpecialBonus { get; } = 0;
        public override string AttackBonus {
            get {
                var _temp = AbilityManager.StrengthMod + SpecialBonus;
                if(ProficiencyManager.CheckByName("Martial Weapons", Interface.ProficiencyType.WEAPON)
                    || ProficiencyManager.CheckByName("Martial Melee Weapons", Interface.ProficiencyType.WEAPON)
                    || ProficiencyManager.CheckByName(Name, Interface.ProficiencyType.WEAPON)) {
                    _temp += AbilityManager.ProficiencyBonus;
                }

                return _temp.ToString("+0;-#");
            }
        }
    }
}
