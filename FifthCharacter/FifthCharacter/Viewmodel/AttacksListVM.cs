using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using FifthCharacter.View;
using System.Collections.ObjectModel;

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
