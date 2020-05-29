using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Rogue {
    public class FRogueExpertise : AFeatureRogue {
        //TODO: prompt to choose 2 skill proficiencies (or thieves' tools proficiency) to double
        //TODO: prompt again @ 6th level
        //Basically, create an expertise system to double proficiencies with expertise marked
        public override string Name => "Expertise";
        public override string Text => FeatureRogueText.Expertise;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FRogueExpertise();
    }
}
