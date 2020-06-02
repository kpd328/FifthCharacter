using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock.EldritchInvocations {
    public class EIMasterOfMyriadForms : AEldritchInvocation {
        public override bool PrerequisiteMet => ClassManager.ClassLevel("Warlock") >= 15;
        public override string Name => "Master of Myriad Forms";
        public override string Text => EldritchInvocationsText.Master_of_Myriad_Forms;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new EIMasterOfMyriadForms();
    }
}
