using FifthCharacter.Interface;
using FifthCharacter.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FifthCharacter.Viewmodel {
    public class AttacksListVM {
        private AttacksList View;

        public ObservableCollection<IAttack> Attacks { get; set; }

        public void Bind(AttacksList view) {
            View = view;
            View.BindingContext = this;
        }
    }
}
