using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using System;
using System.Collections.Generic;
using System.Text;
using WotC.FifthEd.SRD.Features.Race.Tiefling;

namespace WotC.FifthEd.SRD.Race {
    public class Tiefling : IRace {
        public string Name => "Tiefling";
        public string ID => "SRD.Race.Tiefling";

        public Tiefling() { }

        protected Tiefling(bool isRace) {
            CharacterManager.Speed = 30;
            FeaturesManager.Features.Add(new FTieflingAbilityScoreIncrease());
            FeaturesManager.Features.Add(new FTieflingDarkvision());
            FeaturesManager.Features.Add(new FTieflingHellishResistance());
            FeaturesManager.Features.Add(new FTieflingInfernalLegacy1st());
            //TODO: add languages
            //TODO: add level tracker for infernal legacy
        }

        public IRace GetInstance() => new Tiefling(true);
    }
}
