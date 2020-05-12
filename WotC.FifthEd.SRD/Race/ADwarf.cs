using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Popup;
using FifthCharacter.Plugin.StatsManager;
using WotC.FifthEd.SRD.Features.Race.Dwarf;
using WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon;
using WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleMeleeWeapon;
using WotC.FifthEd.SRD.Proficiencies.Languages;

namespace WotC.FifthEd.SRD.Race {
    public abstract class ADwarf : IRace {
        private const string SOURCE_TEXT = "Race Dwarf";

        public virtual string Name => "Dwarf";
        public abstract string ID { get; }
        public bool HasChoices => true;

        protected ADwarf() {
            CharacterManager.Speed = 25;
            ProficiencyManager.Proficiencies.Add(new ProfMMWBattleaxe(SOURCE_TEXT));
            ProficiencyManager.Proficiencies.Add(new ProfSMWHandaxe(SOURCE_TEXT));
            ProficiencyManager.Proficiencies.Add(new ProfSMWLightHammer(SOURCE_TEXT));
            ProficiencyManager.Proficiencies.Add(new ProfMMWWarhammer(SOURCE_TEXT));
            ProficiencyManager.Proficiencies.Add(new ProfLangCommon(SOURCE_TEXT));
            ProficiencyManager.Proficiencies.Add(new ProfLangDwarvish(SOURCE_TEXT));
            FeaturesManager.Features.Add(new FDwarfAbilityScoreIncrease());
            FeaturesManager.Features.Add(new FDwarfDarkvision());
            FeaturesManager.Features.Add(new FDwarfDwarvenResilience());
            FeaturesManager.Features.Add(new FDwarfStonecunning());
        }

        public abstract IRace GetInstance();

        public virtual void BuildPopup(PopupNCRaceOptions raceOptions) {
            //TODO: Add picker for tool choice:
            //smith's tools, brewer's supplies, or mason's tools
        }
        
        public virtual void BuildPopup(PopupNCRaceOptions_GTK raceOptions) {
            //TODO: Add picker for tool choice:
            //smith's tools, brewer's supplies, or mason's tools
        }

        public virtual void ConfirmPopup() { }
    }
}
