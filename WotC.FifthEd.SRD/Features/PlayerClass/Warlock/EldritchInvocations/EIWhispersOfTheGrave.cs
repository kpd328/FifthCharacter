using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock.EldritchInvocations {
    public class EIWhispersOfTheGrave : AEldritchInvocation {
        public override bool PrerequisiteMet => ClassManager.ClassLevel("Warlock") >= 9;
        public override string Name => "Whispers of the Grave";
        public override string Text => EldritchInvocationsText.Whispers_of_the_Grave;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new EIWhispersOfTheGrave();
    }
}
