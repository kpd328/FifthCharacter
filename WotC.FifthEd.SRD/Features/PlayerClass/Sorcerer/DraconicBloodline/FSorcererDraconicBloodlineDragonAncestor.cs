using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using WotC.FifthEd.SRD.Proficiencies.Languages;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Sorcerer.DraconicBloodline {
    public class FSorcererDraconicBloodlineDragonAncestor : AFeatureSorcererDraconicBloodline {
        public override string Name => "Dragon Ancestor";
        public override string Text => FeatureSorcererDraconicBloodline.Dragon_Ancestor;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        internal FSorcererDraconicBloodlineDragonAncestor() { }

        public FSorcererDraconicBloodlineDragonAncestor(bool isTaken) {
            //TODO: choose ancestry similarly to Dragonborn
            ProficiencyManager.Proficiencies.Add(new ProfLangDraconic(Source));
        }

        public override IFeature GetInstance() => new FSorcererDraconicBloodlineDragonAncestor(true);
    }
}
