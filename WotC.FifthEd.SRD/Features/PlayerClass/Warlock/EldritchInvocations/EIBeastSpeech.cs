using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock.EldritchInvocations {
    public class EIBeastSpeech : AEldritchInvocation {
        public override bool PrerequisiteMet => true;
        public override string Name => "Beast Speech";
        public override string Text => EldritchInvocationsText.Beast_Speech;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new EIBeastSpeech();
    }
}
