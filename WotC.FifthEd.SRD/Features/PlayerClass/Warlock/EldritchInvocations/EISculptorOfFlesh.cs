using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock.EldritchInvocations {
    public class EISculptorOfFlesh : AEldritchInvocation {
        public override bool PrerequisiteMet => ClassManager.ClassLevel("Warlock") >= 7;
        public override string Name => "Sculptor of Flesh";
        public override string Text => EldritchInvocationsText.Sculptor_of_Flesh;
        public override bool IsActive => true;
        public override int ActiveUses => 1;

        public override IFeature GetInstance() => new EISculptorOfFlesh();
    }
}
