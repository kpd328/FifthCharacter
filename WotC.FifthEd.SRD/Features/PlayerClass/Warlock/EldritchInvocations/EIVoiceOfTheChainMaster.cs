using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock.EldritchInvocations {
    public class EIVoiceOfTheChainMaster : AEldritchInvocation {
        public override bool PrerequisiteMet => throw new System.NotImplementedException(); //TODO: Check for Pact of the Chain
        public override string Name => "Voice of the Chain Master";
        public override string Text => EldritchInvocationsText.Voice_of_the_Chain_Master;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new EIVoiceOfTheChainMaster();
    }
}
