using FifthCharacter.Plugin.Attacks.Abstract;
using System.Windows.Input;
using Xamarin.Forms;

namespace WotC.FifthEd.SRD.Attacks.Mechanics.Property {
    public class PropertyAmmunition : IWeaponProperty {
        public string TextDescription => WeapPropTxt.Ammunition;
        public string PropertyName => WeapPropName.Ammunition;
        private int RangeOpt { get; set; }
        private int RangeMax { get; set; }
        public bool VisDescriptionShowing { get; set; } = false;

        private ICommand _tapDescription;
        public ICommand TapDescription => _tapDescription ?? (_tapDescription = new Command(() => {
            VisDescriptionShowing = !VisDescriptionShowing;
        }));

        public PropertyAmmunition(int opt, int max) {
            RangeOpt = opt;
            RangeMax = max;
        }
    }
}
