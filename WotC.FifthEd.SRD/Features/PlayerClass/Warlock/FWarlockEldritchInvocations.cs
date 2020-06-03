using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using System.Linq;
using WotC.FifthEd.SRD.Features.PlayerClass.Warlock.EldritchInvocations;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock {
    public class FWarlockEldritchInvocations : AFeatureWarlock {
        public override string Name => "Eldritch Invocations";
        public override string Text => FeatureWarlockText.Eldritch_Invocations;
        public override bool IsActive => false;
        public override int ActiveUses => 0;
        private List<AEldritchInvocation> AllInvocations => new List<AEldritchInvocation>() {
            new EIAgonizingBlast(),
            new EIArmorOfShadows(),
            new EIAscendantStep(),
            new EIBeastSpeech(),
            new EIBeguilingInfluence(),
            new EIBewitchingWhispers(),
            new EIBookOfAncinetSecrets(),
            new EIChainsOfCarceri(),
            new EIDevilsSight(),
            new EIDreadfulWord(),
            new EIEldritchSight(),
            new EIEldritchSpear(),
            new EIEyesOfTheRuneKeeper(),
            new EIFiendishVigor(),
            new EIGazeOfTwoMinds(),
            new EILifedrinker(),
            new EIMaskOfManyFaces(),
            new EIMasterOfMyriadForms(),
            new EIMinionsOfChaos(),
            new EIMireTheMind(),
            new EIMistyVisions(),
            new EIOneWithShadows(),
            new EIOtherworldlyLeap(),
            new EIRepellingBlast(),
            new EISculptorOfFlesh(),
            new EISignOfIllOmen(),
            new EIThiefOfFiveFates(),
            new EIThirstingBlade(),
            new EIVisionsOfDistantRealms(),
            new EIVoiceOfTheChainMaster(),
            new EIWhispersOfTheGrave(),
            new EIWitchSight()
        };

        public IEnumerable<AEldritchInvocation> Invocations => AllInvocations.Where(i => i.PrerequisiteMet);

        internal FWarlockEldritchInvocations() { }

        public FWarlockEldritchInvocations(bool isTaken) {
            //TODO: prompt to take first two invocations
        }

        public override IFeature GetInstance() => new FWarlockEldritchInvocations(true);
    }
}
