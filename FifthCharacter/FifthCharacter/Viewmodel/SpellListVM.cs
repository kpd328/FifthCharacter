using FifthCharacter.Spells;
using FifthCharacter.StatsManager;
using FifthCharacter.View;
using System.Collections.ObjectModel;

namespace FifthCharacter.Viewmodel {
    public class SpellListVM {
        private SpellList View;

        public ObservableCollection<SpellLevelGroup> Spells => MagicManager.SpellsKnown;

        public void Bind(SpellList view) {
            this.View = view;
            View.BindingContext = this;
        }
    }
}
