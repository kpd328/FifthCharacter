using FifthCharacter.Plugin.StatsManager;
using FifthCharacter.View;
using System;
using System.ComponentModel;
using System.Globalization;
using Xamarin.Forms;

namespace FifthCharacter.Viewmodel {
    public class CharacterDefenseVM : INotifyPropertyChanged {
        //TODO: Set color of HitPointCurrent based on CharacterManager.HasTempHitPoints
        public string ArmorClass => CharacterManager.ArmorClass.ToString();
        public string InitiativeBonus => CharacterManager.Initiative;
        public string Speed => CharacterManager.Speed.ToString();
        public string HitPointMaximum => CharacterManager.HitPointMaximum.ToString();
        public string HitPointCurrent => CharacterManager.HitPointShowing.ToString();
        public string HitDiceTotal => ClassManager.HitDiceTotal.ToString();
        public string HitDiceCurrent => ClassManager.HitDiceCurrent.ToString();
        public bool HasTempHitPoints => CharacterManager.HasTempHitPoints;
        public string PassivePerception => AbilityManager.PassivePerception.ToString();

        private CharacterDefense View;

        public event PropertyChangedEventHandler PropertyChanged;

        public void Bind(CharacterDefense view) {
            View = view;
            View.BindingContext = this;
        }

        internal virtual void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class BoolToColorConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            return (bool)value ? Color.Accent : Color.Black;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            return (Color)value == Color.Accent;
        }
    }
}
