using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Tools;
using System.Windows.Input;
using Xamarin.Forms;

namespace WotC.FifthEd.SRD.Attacks.Mechanics.Property {
    public class PropertyVersatile : IWeaponProperty {
        public string TextDescription => WeapPropTxt.Versatile;
        public string PropertyName => WeapPropName.Versatile;
        private Dice Dice { get; set; }
        public string Die => Dice.ToString();
        public bool VisDescriptionShowing { get; set; } = false;

        private ICommand _tapDescription;
        public ICommand TapDescription => _tapDescription ?? (_tapDescription = new Command(() => {
            VisDescriptionShowing = !VisDescriptionShowing;
        }));

        public PropertyVersatile(Dice die) {
            Dice = die;
        }

        public PropertyVersatile(int num, int die) {
            Dice = new Dice(num, die);
        }
    }
}
