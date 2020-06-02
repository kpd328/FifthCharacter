using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock.EldritchInvocations {
    public class EIGazeOfTwoMinds : AEldritchInvocation {
        public override bool PrerequisiteMet => true;
        public override string Name => "Gaze of Two Minds";
        public override string Text => EldritchInvocationsText.Gaze_of_Two_Minds;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new EIGazeOfTwoMinds();
    }
}
