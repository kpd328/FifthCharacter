using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace WotC.FifthEd.SRD.Race {
    public class HillDwarf : ADwarf {
        public new string Name => "Hill Dwarf";
        public override string ID => "SRD.Race.Dwarf.Hill";

        public override IRace GetInstance() => new HillDwarf();
    }
}
