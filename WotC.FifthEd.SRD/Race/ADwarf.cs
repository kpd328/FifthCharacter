using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon;
using WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleMeleeWeapon;

namespace WotC.FifthEd.SRD.Race {
    public abstract class ADwarf : IRace {
        private const string SOURCE_TEXT = "Race Dwarf";

        public string Name => "Dwarf";
        public abstract string ID { get; }

        protected ADwarf() {
            CharacterManager.Speed = 25;

            //Dwarven Combat Training
            ProficiencyManager.Proficiencies.Add(new ProfMMWBattleaxe(SOURCE_TEXT));
            ProficiencyManager.Proficiencies.Add(new ProfSMWHandaxe(SOURCE_TEXT));
            ProficiencyManager.Proficiencies.Add(new ProfSMWLightHammer(SOURCE_TEXT));
            ProficiencyManager.Proficiencies.Add(new ProfMMWWarhammer(SOURCE_TEXT));

            //Tool Proficiency
            //TODO: add artisan's tools
            //TODO: prompt for tool choice

            //Languages
            //TODO: add languages

            //TODO: add asi and race features
        }

        public abstract IRace GetInstance();
    }
}
