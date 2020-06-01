using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Sorcerer {
    public class FSorcererSorcerousRestoration : AFeatureSorcerer {
        //TODO: use this feature to add a short rest ability to restore sorcery points
        public override string Name => "Sorcerous Restoration";
        public override string Text => FeatureSorcererText.Sorcerous_Restoration;
        public override bool IsActive => true;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FSorcererSorcerousRestoration();
    }
}
