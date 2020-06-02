using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock.EldritchInvocations {
    public class EISignOfIllOmen : AEldritchInvocation {
        public override bool PrerequisiteMet => ClassManager.ClassLevel("Warlock") >= 5;
        public override string Name => "Sign of Ill Omen";
        public override string Text => EldritchInvocationsText.Sign_of_Ill_Omen;
        public override bool IsActive => true;
        public override int ActiveUses => 1;

        public override IFeature GetInstance() => new EISignOfIllOmen();
    }
}
