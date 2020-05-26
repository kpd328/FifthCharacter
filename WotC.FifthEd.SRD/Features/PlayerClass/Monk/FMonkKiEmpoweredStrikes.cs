using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Monk {
    public class FMonkKiEmpoweredStrikes : AFeatureMonk {
        public override string Name => "Ki-Empowered Strikes";
        public override string Text => FeatureMonkText.Ki_Empowered_Strikes;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FMonkKiEmpoweredStrikes();
    }
}
