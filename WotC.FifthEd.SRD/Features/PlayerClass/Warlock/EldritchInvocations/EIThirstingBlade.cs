using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock.EldritchInvocations {
    public class EIThirstingBlade : AEldritchInvocation {
        public override bool PrerequisiteMet => ClassManager.ClassLevel("Warlock") >= 5; //TODO: add an && to checking for Pact of the Blade
        public override string Name => "Thirsting Blade";
        public override string Text => EldritchInvocationsText.Thirsting_Blade;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new EIThirstingBlade();
    }
}
