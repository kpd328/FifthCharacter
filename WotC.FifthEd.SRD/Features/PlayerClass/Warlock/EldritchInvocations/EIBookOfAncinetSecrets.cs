using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock.EldritchInvocations {
    public class EIBookOfAncinetSecrets : AEldritchInvocation {
        public override bool PrerequisiteMet => throw new System.NotImplementedException(); //TODO: check for Pact of the Tome
        public override string Name => "Book of Ancient Secrets";
        public override string Text => EldritchInvocationsText.Book_of_Ancient_Secrets;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new EIBookOfAncinetSecrets();
    }
}
