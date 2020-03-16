using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter.Abilities {
    public class ConstitutionAbility : AAbilityVM {
        public override string AbilityName => "Constitution";
        public override string AbilityScore => AbilityManager.ConstitutionScore.ToString();
        public override string AbilityModifier => AbilityManager.ConstitutionModifier;

        public override string Skill1Name => "";
        public override string Skill2Name => "";
        public override string Skill3Name => "";
        public override string Skill4Name => "";
        public override string Skill5Name => "";

        public override string SavingThrowModifier => AbilityManager.ConstitutionSave;
        public override string Skill1Modifier => "";
        public override string Skill2Modifier => "";
        public override string Skill3Modifier => "";
        public override string Skill4Modifier => "";
        public override string Skill5Modifier => "";

        public override bool SavingThrowProficiency => AbilityManager.ConstitutionSaveProficiency;
        public override bool Skill1Proficiency => false;
        public override bool Skill2Proficiency => false;
        public override bool Skill3Proficiency => false;
        public override bool Skill4Proficiency => false;
        public override bool Skill5Proficiency => false;

        public override bool Skill1Exists => false;
        public override bool Skill2Exists => false;
        public override bool Skill3Exists => false;
        public override bool Skill4Exists => false;
        public override bool Skill5Exists => false;
    }
}
