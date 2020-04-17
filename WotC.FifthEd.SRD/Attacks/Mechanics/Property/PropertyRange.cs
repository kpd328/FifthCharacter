using FifthCharacter.Plugin.Attacks.Abstract;
using System.Windows.Input;
using Xamarin.Forms;

namespace WotC.FifthEd.SRD.Attacks.Mechanics.Property {
    public class PropertyRange : IWeaponProperty {
        public string TextDescription => WeapPropTxt.Range;
        public string PropertyName => WeapPropName.Range;
        public bool VisDescriptionShowing { get; set; } = false;

        private ICommand _tapDescription;
        public ICommand TapDescription => _tapDescription ?? (_tapDescription = new Command(() => {
            VisDescriptionShowing = !VisDescriptionShowing;
        }));
    }
}
