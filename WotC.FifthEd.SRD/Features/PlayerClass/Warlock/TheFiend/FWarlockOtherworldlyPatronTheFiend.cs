using FifthCharacter.Plugin.Interface;
using Microsoft.Collections.Extensions;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock.TheFiend {
    public class FWarlockOtherworldlyPatronTheFiend : FWarlockOtherworldlyPatron {
        public override string Name => "Otherworldly Patron: The Fiend";
        public override string Text => FeatureWarlockFiendText.The_Fiend;
        public override MultiValueDictionary<int, IFeature> PatronFeatures => new MultiValueDictionary<int, IFeature>() {
            { 1, new FWarlockFiendExpandedSpellList() },
            { 1, new FWarlockFiendDarkOnesBlessing() },
            { 6, new FWarlockFiendDarkOnesOwnLuck() },
            { 10, new FWarlockFiendFiendishResilience() },
            { 14, new FWarlockFiendHurlThroughHell() }
        };

        public override IFeature GetInstance() => new FWarlockOtherworldlyPatronTheFiend();
    }
}
