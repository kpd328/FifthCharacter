using FifthCharacter.Plugin.Interface;
using FifthCharacter.StatsManager;
using FifthCharacter.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

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
