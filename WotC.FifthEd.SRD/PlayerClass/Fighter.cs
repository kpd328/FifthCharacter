using FifthCharacter.Plugin.Features.Abstract;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Tools;
using SD.Tools.Algorithmia.GeneralDataStructures;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Features.PlayerClass.Fighter;

namespace WotC.FifthEd.SRD.PlayerClass {
    public class Fighter : IPlayerClass {
        private const int SUBCLASS_LEVEL = 3;
        public string Name => "Fighter";
        public string ID => "SRD.PlayerClass.Figher";
        public int Level { get; private set; }
        public Dice HitDicePerLevel => new Dice(1, 10);
        public Dice CurrentTotalHitDice { get; private set; }
        public IList<IFeature> ClassFeatures => new List<IFeature>() {
            new FFighterSecondWind()
        };
        private MultiValueDictionary<int, IFeature> AllClassFeatures => new MultiValueDictionary<int, IFeature>() {
            { 1, new FFighterSecondWind() },
            { 1, new FFighterFightingStyle(FightingStyle.ARCHERY) },
            { 1, new FFighterFightingStyle(FightingStyle.DEFENSE) },
            { 1, new FFighterFightingStyle(FightingStyle.DUELING) },
            { 1, new FFighterFightingStyle(FightingStyle.GREATWEAPONFIGHTING) },
            { 1, new FFighterFightingStyle(FightingStyle.PROTECTION) },
            { 1, new FFighterFightingStyle(FightingStyle.TWOWEAPONFIGHTING) },
            { 2, new FFighterActionSurge() },
            { 4, new FFighterAbilityScoreImprovement() }
            //Add other features as implemented
        };

        public Fighter() { }
        private Fighter(FightingStyle style) : this() {
            ClassFeatures.Add(new FFighterFightingStyle(style));
        }

        public IPlayerClass GetInstance() => new Fighter() { Level = 1, CurrentTotalHitDice = new Dice(HitDicePerLevel) };
        public IPlayerClass GetInstance(FightingStyle style) => new Fighter(style) { Level = 1, CurrentTotalHitDice = new Dice(HitDicePerLevel) };

        public void LevelUp() {
            Level++;
            CurrentTotalHitDice.Number++;
            if(Level == SUBCLASS_LEVEL) {
                SelectSubclass();
            }
            var newFeatures = AllClassFeatures.GetValues(Level, true);
            foreach(IFeature f in newFeatures) {
                ClassFeatures.Add(f);
            }
        }

        private void SelectSubclass() {
            //Popup a prompt to select a subclass (or add prompt to levelup popup queue
        }
    }
}
