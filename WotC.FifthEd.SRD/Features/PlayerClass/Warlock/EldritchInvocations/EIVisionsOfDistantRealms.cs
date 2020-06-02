using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock.EldritchInvocations {
    public class EIVisionsOfDistantRealms : AEldritchInvocation {
        public override bool PrerequisiteMet => ClassManager.ClassLevel("Warlock") >= 15;
        public override string Name => "Visions of Distant Realms";
        public override string Text => EldritchInvocationsText.Visions_of_Distant_Realms;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new EIVisionsOfDistantRealms();
    }
}
