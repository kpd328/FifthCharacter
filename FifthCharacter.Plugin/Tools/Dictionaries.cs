using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace FifthCharacter.Plugin.Tools {
    public class RaceDictionary : KeyedCollection<string, IRace> {
        protected override string GetKeyForItem(IRace item) => item.Name;
        public void AddAll(IEnumerable<IRace> toAdd) {
            foreach(IRace race in toAdd) {
                Add(race);
            }
        }
    }

    public class MagicDictionary : KeyedCollection<string, IMagic> {
        protected override string GetKeyForItem(IMagic item) => item.Name;
        public void AddAll(IEnumerable<IMagic> toAdd) {
            foreach (IMagic magic in toAdd) {
                Add(magic);
            }
        }
    }

    public class AttackDictionary : KeyedCollection<string, IAttack> {
        protected override string GetKeyForItem(IAttack item) => item.Name;
        public void AddAll(IEnumerable<IAttack> toAdd) {
            foreach (IAttack attack in toAdd) {
                Add(attack);
            }
        }
    }

    public class FeatureDictionary : KeyedCollection<string, IFeature> {
        protected override string GetKeyForItem(IFeature item) => item.Name;
        public void AddAll(IEnumerable<IFeature> toAdd) {
            foreach (IFeature feature in toAdd) {
                Add(feature);
            }
        }
    }

    public class PlayerClassDictionary : KeyedCollection<string, IPlayerClass> {
        protected override string GetKeyForItem(IPlayerClass item) => item.Name;
        public void AddAll(IEnumerable<IPlayerClass> toAdd) {
            foreach (IPlayerClass playerClass in toAdd) {
                Add(playerClass);
            }
        }
    }
}
