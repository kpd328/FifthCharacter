using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace WotC.FifthEd.SRD.Race {
    public class Human : IRace {
        public string Name => "Human";
        public string ID => "SRD.Race.Human";

        public IRace GetInstance() => new Human();
    }
}
