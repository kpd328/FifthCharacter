using FifthCharacter.Plugin.StatsManager;
using FifthCharacter.Plugin.Tools;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FifthCharacter.Plugin.Interface {
    public interface IPlayerClass {
        string Name { get; }
        string ID { get; }
        Dice HitDicePerLevel { get; }
        Dice CurrentTotalHitDice { get; }
        IList<IFeature> ClassFeatures { get; }
        int Level { get; }
        SpellcasterClass SpellcasterClass { get; }

        IPlayerClass TakeAsPrimaryClass();
        IPlayerClass TakeAsSecondaryClass();
        void LevelUp();
        void BuildNewCharacterPopup(Frame frame);
        void ConfirmNewCharacterPopup();
    }
}
