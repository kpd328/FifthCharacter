using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock.EldritchInvocations {
    public class EIEldritchSpear : AEldritchInvocation {
        public override bool PrerequisiteMet => throw new System.NotImplementedException(); //TODO: check for Eldritch Blast
        public override string Name => "Eldritch Spear";
        public override string Text => EldritchInvocationsText.Eldritch_Spear;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new EIEldritchSpear();
    }
}
