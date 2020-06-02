using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock.EldritchInvocations {
    public class EIFiendishVigor : AEldritchInvocation {
        public override bool PrerequisiteMet => true;
        public override string Name => "Fiendish Vigor";
        public override string Text => EldritchInvocationsText.Fiendish_Vigor;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new EIFiendishVigor();
    }
}
