using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter {
    public interface IAbilityVM {
        //Properties
        string AbilityName { get; }
        string AbilityScore { get; }
        string AbilityModifier { get; }

        string Skill1Name { get; }
        string Skill2Name { get; }
        string Skill3Name { get; }
        string Skill4Name { get; }
        string Skill5Name { get; }

        string SavingThrowModifier { get; }
        string Skill1Modifier { get; }
        string Skill2Modifier { get; }
        string Skill3Modifier { get; }
        string Skill4Modifier { get; }
        string Skill5Modifier { get; }

        bool SavingThrowProficiency { get; }
        bool Skill1Proficiency { get; }
        bool Skill2Proficiency { get; }
        bool Skill3Proficiency { get; }
        bool Skill4Proficiency { get; }
        bool Skill5Proficiency { get; }

        bool Skill1Exists { get; }
        bool Skill2Exists { get; }
        bool Skill3Exists { get; }
        bool Skill4Exists { get; }
        bool Skill5Exists { get; }

        //Methods
        void Bind(AbilityScore view);
    }
}
