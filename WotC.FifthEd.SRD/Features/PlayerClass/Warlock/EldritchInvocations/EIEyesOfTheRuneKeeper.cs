using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock.EldritchInvocations {
    public class EIEyesOfTheRuneKeeper : AEldritchInvocation {
        public override bool PrerequisiteMet => true;
        public override string Name => "Eyes of the Rune Keeper";
        public override string Text => EldritchInvocationsText.Eyes_of_the_Rune_Keeper;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new EIEyesOfTheRuneKeeper();
    }
}
