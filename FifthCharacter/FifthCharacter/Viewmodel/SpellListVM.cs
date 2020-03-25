using FifthCharacter.Interface;
using FifthCharacter.Spells;
using FifthCharacter.StatsManager;
using FifthCharacter.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

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
