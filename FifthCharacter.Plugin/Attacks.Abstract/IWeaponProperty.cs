using System.Windows.Input;

namespace FifthCharacter.Plugin.Attacks.Abstract {
    public interface IWeaponProperty {
        string PropertyName { get; }
        string TextDescription { get; }
        bool VisDescriptionShowing { get; set; }
        ICommand TapDescription { get; }
    }
}
