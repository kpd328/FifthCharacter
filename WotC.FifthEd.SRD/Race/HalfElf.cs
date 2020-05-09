using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using System;
using System.Collections.Generic;
using System.Text;
using WotC.FifthEd.SRD.Features.Race.HalfElf;

namespace WotC.FifthEd.SRD.Race {
    public class HalfElf : IRace {
        public string Name => "Half-Elf";
        public string ID => "SRD.Race.HalfElf";

        public HalfElf() { }

        protected HalfElf(bool isRace) {
            CharacterManager.Speed = 30;
            FeaturesManager.Features.Add(new FHalfElfAbilityScoreIncrease());
            FeaturesManager.Features.Add(new FHalfElfDarkvision());
            FeaturesManager.Features.Add(new FHalfElfFeyAncestry());

            //TODO: prompt for 2 skill proficiencies
        }

        public IRace GetInstance() => new HalfElf(true);
    }
}
