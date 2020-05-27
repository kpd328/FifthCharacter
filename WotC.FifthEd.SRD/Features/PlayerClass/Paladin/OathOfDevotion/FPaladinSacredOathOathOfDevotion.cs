using FifthCharacter.Plugin.Interface;
using Microsoft.Collections.Extensions;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Paladin.OathOfDevotion {
    public class FPaladinSacredOathOathOfDevotion : FPaladinSacredOath {
        //TODO: add permenant spells for 3rd, 5th, 9th, 13th, and 17th level
        public override string Name => "Sacred Oath: Oath of Devotion";
        public override string Text => FeaturePaladinOathOfDevotionText.Oath_of_Devotion;
        public override MultiValueDictionary<int, IFeature> OathFeatures => new MultiValueDictionary<int, IFeature>() {
            { 3, new FPaladinDevotionChannelDivinity() },
            { 7, new FPaladinDevotionAuraOfDevotion() },
            { 15, new FPaladinDevotionPurityOfSpirit() },
            { 20, new FPaladinDevotionHolyNimbus() }
        };

        public override IFeature GetInstance() => new FPaladinSacredOathOathOfDevotion();
    }
}
