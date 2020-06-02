using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Proficiencies.Skills;
using FifthCharacter.Plugin.StatsManager;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock.EldritchInvocations {
    public class EIBeguilingInfluence : AEldritchInvocation {
        public override bool PrerequisiteMet => true;
        public override string Name => "Beguiling Influence";
        public override string Text => EldritchInvocationsText.Beguiling_Influence;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        internal EIBeguilingInfluence() { }

        public EIBeguilingInfluence(bool isTaken) {
            ProficiencyManager.Proficiencies.Add(new ProfDeception("Class Warlock"));
            ProficiencyManager.Proficiencies.Add(new ProfPersuasion("Class Warlock"));
        }

        public override IFeature GetInstance() => new EIBeguilingInfluence(true);
    }
}
