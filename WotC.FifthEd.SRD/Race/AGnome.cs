using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace WotC.FifthEd.SRD.Race {
    public abstract class AGnome : IRace {
        public string Name => "Gnome";
        public abstract string ID { get; }

        public abstract IRace GetInstance();
    }
}
