using FifthCharacter.View;
using FifthCharacter.Viewmodel;
using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter.Abilities {
    public abstract class AAbilityVM : IAbilityVM {
        //Inherited Properties
        public abstract string AbilityName { get; }
        public abstract string AbilityScore { get; }
        public abstract string AbilityModifier { get; }

        public abstract string Skill1Name { get; }
        public abstract string Skill2Name { get; }
        public abstract string Skill3Name { get; }
        public abstract string Skill4Name { get; }
        public abstract string Skill5Name { get; }

        public abstract string SavingThrowModifier { get; }
        public abstract string Skill1Modifier { get; }
        public abstract string Skill2Modifier { get; }
        public abstract string Skill3Modifier { get; }
        public abstract string Skill4Modifier { get; }
        public abstract string Skill5Modifier { get; }

        public abstract bool SavingThrowProficiency { get; }
        public abstract bool Skill1Proficiency { get; }
        public abstract bool Skill2Proficiency { get; }
        public abstract bool Skill3Proficiency { get; }
        public abstract bool Skill4Proficiency { get; }
        public abstract bool Skill5Proficiency { get; }

        public abstract bool Skill1Exists { get; }
        public abstract bool Skill2Exists { get; }
        public abstract bool Skill3Exists { get; }
        public abstract bool Skill4Exists { get; }
        public abstract bool Skill5Exists { get; }

        //Properties
        private AbilityScore View;

        //Methods
        public void Bind(AbilityScore view) {
            this.View = view;
            View.BindingContext = this;
        }
    }
}
