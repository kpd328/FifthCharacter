using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Ranger {
    public class FRangerFavoredEnemy : AFeatureRanger {
        public override string Name => "Favored Enemy";
        public override string Text => FeatureRangerText.Favored_Enemy;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FRangerFavoredEnemy();
    }
}
