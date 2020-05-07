using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace WotC.FifthEd.SRD.Race {
    public abstract class AHalfling : IRace {
        public string Name => "Halfling";
        public abstract string ID { get; }

        public abstract IRace GetInstance();
    }
}
