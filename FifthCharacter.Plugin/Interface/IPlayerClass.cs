using FifthCharacter.Plugin.Features.Abstract;
using FifthCharacter.Plugin.Tools;
using System.Collections.Generic;

namespace FifthCharacter.Plugin.Interface {
    public interface IPlayerClass {
        string Name { get; }
        string ID { get; }
        Dice HitDicePerLevel { get; }
        Dictionary<int, IFeature> ClassFeatures { get; }

        IPlayerClass GetInstance();
        IPlayerClass GetInstance(FightingStyle style);
    }
}
