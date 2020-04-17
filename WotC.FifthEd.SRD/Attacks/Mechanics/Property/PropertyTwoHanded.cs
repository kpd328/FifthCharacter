using FifthCharacter.Plugin.Attacks.Abstract;
using System.Windows.Input;
using Xamarin.Forms;

namespace WotC.FifthEd.SRD.Attacks.Mechanics.Property {
    public class PropertyTwoHanded : IWeaponProperty {
        public string TextDescription => WeapPropTxt.Two_Handed;
        public string PropertyName => WeapPropName.Two_Handed;
        public bool VisDescriptionShowing { get; set; } = false;

        private ICommand _tapDescription;
        public ICommand TapDescription => _tapDescription ?? (_tapDescription = new Command(() => {
            VisDescriptionShowing = !VisDescriptionShowing;
        }));
    }
}
