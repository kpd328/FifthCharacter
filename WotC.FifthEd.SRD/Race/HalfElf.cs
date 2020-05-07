using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace WotC.FifthEd.SRD.Race {
    public class HalfElf : IRace {
        public string Name => "Half-Elf";
        public string ID => "SRD.Race.HalfElf";

        public IRace GetInstance() => new HalfElf();
    }
}
