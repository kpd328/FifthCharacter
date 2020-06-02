using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock.EldritchInvocations {
    public class EIMinionsOfChaos : AEldritchInvocation {
        public override bool PrerequisiteMet => ClassManager.ClassLevel("Warlock") >= 9;
        public override string Name => "Minions of Chaos";
        public override string Text => EldritchInvocationsText.Minions_of_Chaos;
        public override bool IsActive => true;
        public override int ActiveUses => 1;

        public override IFeature GetInstance() => new EIMinionsOfChaos();
    }
}
