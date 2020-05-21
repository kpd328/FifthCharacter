using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Cleric {
    public class FClericDivineIntervention : AFeatureCleric {
        public override string Name => throw new System.NotImplementedException();
        public override string Text => FeatureClericText.Divine_Intervention;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FClericDivineIntervention();
    }
}
