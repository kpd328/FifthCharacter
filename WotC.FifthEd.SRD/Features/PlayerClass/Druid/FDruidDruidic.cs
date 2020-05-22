using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using WotC.FifthEd.SRD.Proficiencies.Languages;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Druid {
    public class FDruidDruidic : AFeatureDruid {
        public override string Name => "Druidic";
        public override string Text => FeatureDruidText.Druidic;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        internal FDruidDruidic() { }

        public FDruidDruidic(bool isTaken) {
            ProficiencyManager.Proficiencies.Add(new ProfLangDruidic("Class Druid"));
        }

        public override IFeature GetInstance() => new FDruidDruidic(true);
    }
}
