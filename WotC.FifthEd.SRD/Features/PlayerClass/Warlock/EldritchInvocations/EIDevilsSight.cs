using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock.EldritchInvocations {
    public class EIDevilsSight : AEldritchInvocation {
        public override bool PrerequisiteMet => true;
        public override string Name => "Devil's Sight";
        public override string Text => EldritchInvocationsText.Devil_s_Sight;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new EIDevilsSight();
    }
}
