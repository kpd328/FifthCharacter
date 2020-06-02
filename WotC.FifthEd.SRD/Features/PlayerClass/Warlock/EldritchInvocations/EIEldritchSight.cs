﻿using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock.EldritchInvocations {
    public class EIEldritchSight : AEldritchInvocation {
        public override bool PrerequisiteMet => true;
        public override string Name => "Eldritch Sight";
        public override string Text => EldritchInvocationsText.Eldritch_Sight;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new EIEldritchSight();
    }
}
