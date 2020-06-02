using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock.EldritchInvocations {
    public class EIChainsOfCarceri : AEldritchInvocation {
        public override bool PrerequisiteMet => ClassManager.ClassLevel("Warlock") >= 15; //TODO: && this to checking for Pact of the Chain
        public override string Name => "Chains of Carceri";
        public override string Text => EldritchInvocationsText.Chains_of_Carceri;
        public override bool IsActive => true;
        public override int ActiveUses => 1;

        public override IFeature GetInstance() => new EIChainsOfCarceri();
    }
}
