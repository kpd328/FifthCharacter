using FifthCharacter.Interface;
using FifthCharacter.StatsManager;
using FifthCharacter.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FifthCharacter.Viewmodel {
    public class AttacksListVM {
        private AttacksList View;

        public ObservableCollection<IAttack> Attacks => AttacksManager.Attacks;

        public void Bind(AttacksList view) {
            View = view;
            View.BindingContext = this;
        }
    }
}
