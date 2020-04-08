using FifthCharacter.Plugin.Features.Abstract;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Tools;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Features.Class.Fighter;

namespace WotC.FifthEd.SRD.PlayerClass {
    public class Fighter : IPlayerClass {
        public string Name => "Fighter";
        public string ID => "SRD.PlayerClass.Figher";
        public Dice HitDicePerLevel => new Dice(1, 10);
        public Dictionary<int, IFeature> ClassFeatures => new Dictionary<int, IFeature>() {
            {1, new FFighterSecondWind() },
            {2, new FFighterActionSurge() }
            //Add other features as implemented
        };

        private Fighter() { }
        private Fighter(FightingStyle style) {
            ClassFeatures.Add(1, new FFighterFightingStyle(style));
        }

        public IPlayerClass GetInstance() => new Fighter();
        public IPlayerClass GetInstance(FightingStyle style) => new Fighter(style);
    }
}
