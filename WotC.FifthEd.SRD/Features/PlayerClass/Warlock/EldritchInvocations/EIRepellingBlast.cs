﻿using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock.EldritchInvocations {
    public class EIRepellingBlast : AEldritchInvocation {
        public override bool PrerequisiteMet => throw new System.NotImplementedException(); //TODO check for Eldritch Blast
        public override string Name => "Repelling Blast";
        public override string Text => EldritchInvocationsText.Repelling_Blast;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new EIRepellingBlast();
    }
}
