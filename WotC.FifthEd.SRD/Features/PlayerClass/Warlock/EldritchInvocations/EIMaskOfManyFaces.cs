using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock.EldritchInvocations {
    public class EIMaskOfManyFaces : AEldritchInvocation {
        public override bool PrerequisiteMet => true;
        public override string Name => "Mask of Many Faces";
        public override string Text => EldritchInvocationsText.Mask_of_Many_Faces;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new EIMaskOfManyFaces();
    }
}
