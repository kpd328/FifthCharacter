using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace WotC.FifthEd.SRD.Race {
    public class Tiefling : IRace {
        public string Name => "Tiefling";
        public string ID => "SRD.Race.Tiefling";

        public IRace GetInstance() => new Tiefling();
    }
}
