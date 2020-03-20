using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FifthCharacter {
    public class AttacksListVM {
        private AttacksList View;

        public ObservableCollection<IAttack> Attacks { get; set; }

        public void Bind(AttacksList view) {
            this.View = view;
            View.BindingContext = this;
        }
    }
}
