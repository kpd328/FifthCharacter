using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FifthCharacter.Utilities {
    /// <summary>
    /// TODO: implement a way to clear all checkboxes back to zero
    /// TODO: implement a way for checkboxes to be immutable after set true
    /// </summary>
    public class CheckboxGroup : ContentView {
        private static bool ready = false;
        public int BoxCount { get; set; }

        public static readonly BindableProperty BoxCountProperty = BindableProperty.Create(
            propertyName: "BoxCount",
            returnType: typeof(int),
            declaringType: typeof(CheckboxGroup),
            defaultValue: 0,
            defaultBindingMode: BindingMode.OneTime,
            propertyChanged: BoxCountPropertyChanged);

        public CheckboxGroup() {
            Content = new StackLayout {
                Orientation = StackOrientation.Horizontal,
                Spacing = 7.5,
                Margin = new Thickness(2.5,0)
            };
            var _t = new Thread(() => AddWhenReady()) {
                IsBackground = true,
                Priority = ThreadPriority.Normal
            };
            _t.Start();
        }

        private static void BoxCountPropertyChanged(BindableObject bindable, object oldValue, object newValue) {
            if((int)oldValue == 0 && (int)newValue > 0) {
                ready = true;
            }
        }

        private void AddWhenReady() {
            SpinWait.SpinUntil(() => ready
                && Application.Current.Resources.MergedDictionaries.Where(c => c.ContainsKey("InvertColor")).FirstOrDefault() != null
                && Application.Current.Resources.MergedDictionaries.Where(c => c.ContainsKey("ScaleCheckboxX")).FirstOrDefault() != null
                && Application.Current.Resources.MergedDictionaries.Where(c => c.ContainsKey("ScaleCheckboxY")).FirstOrDefault() != null
                && Application.Current.Resources.MergedDictionaries.Where(c => c.ContainsKey("CheckboxMargin")).FirstOrDefault() != null);
            Dispatcher.BeginInvokeOnMainThread(() => Ready());
        }

        private void Ready() {
            for (int i = 0; i < (int)GetValue(BoxCountProperty); i++) {
                ((StackLayout)Content).Children.Add(new CheckBox() {
                    Color = (Color)Application.Current.Resources.MergedDictionaries.Where(c => c.ContainsKey("InvertColor")).FirstOrDefault()["InvertColor"],
                    ScaleX = (float)Application.Current.Resources.MergedDictionaries.Where(c => c.ContainsKey("ScaleCheckboxX")).FirstOrDefault()["ScaleCheckboxX"],
                    ScaleY = (float)Application.Current.Resources.MergedDictionaries.Where(c => c.ContainsKey("ScaleCheckboxY")).FirstOrDefault()["ScaleCheckboxY"],
                    Margin = (Thickness)Application.Current.Resources.MergedDictionaries.Where(c => c.ContainsKey("CheckboxMargin")).FirstOrDefault()["CheckboxMargin"]
                });
            }
        }
    }
}