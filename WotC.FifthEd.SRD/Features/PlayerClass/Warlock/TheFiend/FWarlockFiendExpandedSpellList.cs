using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock.TheFiend {
    public class FWarlockFiendExpandedSpellList : AFeatureWarlockFiend {
        public override string Name => "Expanded Spell List";
        public override string Text => FeatureWarlockFiendText.Expanded_Spell_List;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FWarlockFiendExpandedSpellList();
    }
}
