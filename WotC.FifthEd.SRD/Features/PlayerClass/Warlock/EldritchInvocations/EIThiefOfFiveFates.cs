using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock.EldritchInvocations {
    public class EIThiefOfFiveFates : AEldritchInvocation {
        public override bool PrerequisiteMet => true;
        public override string Name => "Thief of Five Fates";
        public override string Text => EldritchInvocationsText.Thief_of_Five_Fates;
        public override bool IsActive => true;
        public override int ActiveUses => 1;

        public override IFeature GetInstance() => new EIThiefOfFiveFates();
    }
}
