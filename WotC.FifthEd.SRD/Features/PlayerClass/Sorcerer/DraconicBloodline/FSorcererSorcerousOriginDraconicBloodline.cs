using FifthCharacter.Plugin.Interface;
using Microsoft.Collections.Extensions;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Sorcerer.DraconicBloodline {
    public class FSorcererSorcerousOriginDraconicBloodline : FSorcererSorcerousOrigin {
        public override string Name => "Sorcerous Origin: Draconic Bloodline";
        public override string Text => FeatureSorcererDraconicBloodline.Draconic_Bloodline;
        public override MultiValueDictionary<int, IFeature> OriginFeatures => new MultiValueDictionary<int, IFeature>() {
            { 1, new FSorcererDraconicBloodlineDragonAncestor() },
            { 1, new FSorcererDraconicBloodlineDraconicResilience() },
            { 6, new FSorcererDraconicBloodlineElementalAffinity() },
            { 14, new FSorcererDraconicBloodlineDragonWings() },
            { 18, new FSorcererDraconicBloodlineDraconicPresence() }
        };

        public override IFeature GetInstance() => new FSorcererSorcerousOriginDraconicBloodline();
    }
}
