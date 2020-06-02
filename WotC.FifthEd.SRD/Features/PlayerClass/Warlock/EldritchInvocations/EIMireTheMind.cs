using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock.EldritchInvocations {
    public class EIMireTheMind : AEldritchInvocation {
        public override bool PrerequisiteMet => ClassManager.ClassLevel("Warlock") >= 5;
        public override string Name => "Mire the Mind";
        public override string Text => EldritchInvocationsText.Mire_the_Mind;
        public override bool IsActive => true;
        public override int ActiveUses => 1;

        public override IFeature GetInstance() => new EIMireTheMind();
    }
}
