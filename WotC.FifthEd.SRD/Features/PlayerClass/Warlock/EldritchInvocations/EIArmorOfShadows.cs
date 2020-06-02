using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock.EldritchInvocations {
    public class EIArmorOfShadows : AEldritchInvocation {
        public override bool PrerequisiteMet => true;
        public override string Name => "Armor of Shadows";
        public override string Text => EldritchInvocationsText.Armor_of_Shadows;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new EIArmorOfShadows();
    }
}
