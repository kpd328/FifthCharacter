using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace WotC.FifthEd.SRD.Race {
    public class Dragonborn : IRace {
        public string Name => "Dragonborn";
        public string ID => "SRD.Race.Dragonborn";

        public IRace GetInstance() => new Dragonborn();
    }
}
