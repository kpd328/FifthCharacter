using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace WotC.FifthEd.SRD.Race {
    public class HalfOrc : IRace {
        public string Name => "Half-Orc";
        public string ID => "SRD.Race.HalfOrc";

        public IRace GetInstance() => new HalfOrc();
    }
}
