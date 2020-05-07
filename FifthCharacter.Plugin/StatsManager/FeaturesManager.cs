using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace FifthCharacter.Plugin.StatsManager {
    public static class FeaturesManager {
        public static ObservableCollection<IFeature> Features { get; } = new ObservableCollection<IFeature>();

        public static void RemoveClassFeatures() {
            var _toDelete = new List<IFeature>();
            foreach(var f in Features) {
                if (f.Source.StartsWith("Class")) {
                    _toDelete.Add(f);
                }
            }
            foreach(var f in _toDelete) {
                Features.Remove(f);
            }
        }

        public static void RemoveRaceFeatures() {
            var _toDelete = new List<IFeature>();
            foreach (var f in Features) {
                if (f.Source.StartsWith("Race")) {
                    _toDelete.Add(f);
                }
            }
            foreach (var f in _toDelete) {
                Features.Remove(f);
            }
        }

        public static void RemoveBackgroundFeatures() {
            var _toDelete = new List<IFeature>();
            foreach (var f in Features) {
                if (f.Source.StartsWith("Background")) {
                    _toDelete.Add(f);
                }
            }
            foreach (var f in _toDelete) {
                Features.Remove(f);
            }
        }
    }
}
