using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Fighter {
    public abstract class FFighterMartialArchetype : AFeatureFighter {
        public override string Name => "Martial Archetype";
        public override string Text => FeatureFighterText.MartialArchetype;
        public override bool IsActive => false;
        public override int ActiveUses => 0;
    }
}
