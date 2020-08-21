using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace FifthCharacter.Plugin.Tools {
    public class RaceDictionary : KeyedCollection<string, IRace> {
        protected override string GetKeyForItem(IRace item) => item.Name;
        public void AddAll(IEnumerable<IRace> toAdd) {
            if (toAdd == null) {
                return;
            }
            foreach (IRace race in toAdd) {
                Add(race);
            }
        }
    }

    public class MagicDictionary : KeyedCollection<string, IMagic> {
        protected override string GetKeyForItem(IMagic item) => item.Name;
        public void AddAll(IEnumerable<IMagic> toAdd) {
            if (toAdd == null) {
                return;
            }
            foreach (IMagic magic in toAdd) {
                Add(magic);
            }
        }
    }

    public class AttackDictionary : KeyedCollection<string, IAttack> {
        protected override string GetKeyForItem(IAttack item) => item.Name;
        public void AddAll(IEnumerable<IAttack> toAdd) {
            if (toAdd == null) {
                return;
            }
            foreach (IAttack attack in toAdd) {
                Add(attack);
            }
        }
    }

    public class FeatureDictionary : KeyedCollection<string, IFeature> {
        protected override string GetKeyForItem(IFeature item) => item.Name;
        public void AddAll(IEnumerable<IFeature> toAdd) {
            if (toAdd == null) {
                return;
            }
            foreach (IFeature feature in toAdd) {
                Add(feature);
            }
        }
    }

    public class PlayerClassDictionary : KeyedCollection<string, IPlayerClass> {
        protected override string GetKeyForItem(IPlayerClass item) => item.Name;
        public void AddAll(IEnumerable<IPlayerClass> toAdd) {
            if (toAdd == null) {
                return;
            }
            foreach (IPlayerClass playerClass in toAdd) {
                Add(playerClass);
            }
        }
    }

    public class BackgroundDictionary : KeyedCollection<string, IBackground> {
        protected override string GetKeyForItem(IBackground item) => item.Name;
        public void AddAll(IEnumerable<IBackground> toAdd) {
            if(toAdd == null) {
                return;
            }
            foreach(IBackground background in toAdd) {
                Add(background);
            }
        }
    }

    public class ProficiencyDictionary : KeyedCollection<string, IProficiency> {
        protected override string GetKeyForItem(IProficiency item) => item.Name;
        public void AddAll(IEnumerable<IProficiency> toAdd) {
            if(toAdd == null) {
                return;
            }
            foreach(IProficiency proficiency in toAdd) {
                Add(proficiency);
            }
        }
        public IEnumerable<IProficiency> GetAllForType(ProficiencyType type) {
            return this.Where(p => p.ProficiencyType == type);
        }
    }

    public class ArmorDictionary : KeyedCollection<string, IArmor> {
        protected override string GetKeyForItem(IArmor item) => item.Name;
        public void AddAll(IEnumerable<IArmor> toAdd) {
            if(toAdd == null) {
                return;
            }
            foreach(IArmor armor in toAdd) {
                Add(armor);
            }
        }
        public IEnumerable<IArmor> GetAllForType(ArmorWeightClass type) {
            return this.Where(a => a.ArmorWeightClass == type);
        }
    }

    public class EquipmentDictionary : KeyedCollection<string, IEquipment> {
        protected override string GetKeyForItem(IEquipment item) => item.Name;
        public void AddAll(IEnumerable<IEquipment> toAdd) {
            if(toAdd == null) {
                return;
            }
            foreach(IEquipment equipment in toAdd) {
                Add(equipment);
            }
        }
    }
}
