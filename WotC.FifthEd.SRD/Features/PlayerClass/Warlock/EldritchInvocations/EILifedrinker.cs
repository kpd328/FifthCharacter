using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock.EldritchInvocations {
    public class EILifedrinker : AEldritchInvocation {
        public override bool PrerequisiteMet => ClassManager.ClassLevel("Warlock") >= 12; //TODO: && this to finding Pact of the Blade
        public override string Name => "Lifedrinker";
        public override string Text => EldritchInvocationsText.Lifedrinker;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new EILifedrinker();
    }
}
