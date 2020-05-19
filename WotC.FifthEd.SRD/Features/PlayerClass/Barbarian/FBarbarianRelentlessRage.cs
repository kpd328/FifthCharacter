using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Barbarian {
    public class FBarbarianRelentlessRage : AFeatureBarbarian {
        public override string Name => "Relentless Rage";
        public override string Text => FeatureBarbarianText.Relentless_Rage;
        public override bool IsActive => true;
        public override int ActiveUses => 0; //This is zero because there is no usage limit, but on a rest the conditions change

        public override IFeature GetInstance() => new FBarbarianRelentlessRage();
    }
}
