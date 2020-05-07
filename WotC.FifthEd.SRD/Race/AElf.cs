using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace WotC.FifthEd.SRD.Race {
    public abstract class AElf : IRace {
        public string Name => "Elf";
        public abstract string ID { get; }

        public abstract IRace GetInstance();
    }
}
