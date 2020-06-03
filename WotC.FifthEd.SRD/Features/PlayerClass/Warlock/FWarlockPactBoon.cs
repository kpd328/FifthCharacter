using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock {
    public class FWarlockPactBoon : AFeatureWarlock {
        public override string Name => PactBoon switch {
            PactBoon.PACT_OF_THE_CHAIN => "Pact Boon (Pact of the Chain)",
            PactBoon.PACT_OF_THE_BLADE => "Pact Boon (Pact of the Blade)",
            PactBoon.PACT_OF_THE_TOME => "Pact Boon (Pact of the Tomb)",
            _ => "Pact Boon"
        };
        public override string Text => PactBoon switch {
            PactBoon.PACT_OF_THE_CHAIN => FeatureWarlockText.Pact_Boon__Pact_of_the_Chain,
            PactBoon.PACT_OF_THE_BLADE => FeatureWarlockText.Pact_Boon__Pact_of_the_Blade,
            PactBoon.PACT_OF_THE_TOME => FeatureWarlockText.Pact_Boon__Pact_of_the_Tome,
            _ => FeatureWarlockText.Pact_Boon,
        };
        public PactBoon PactBoon;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        internal FWarlockPactBoon() { }

        public FWarlockPactBoon(bool isTaken) {
            //TODO: Prompt to pick pact boon
        }

        public override IFeature GetInstance() => new FWarlockPactBoon(true);
    }

    public enum PactBoon {
        PACT_OF_THE_CHAIN,
        PACT_OF_THE_BLADE,
        PACT_OF_THE_TOME
    }
}
