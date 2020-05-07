using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace WotC.FifthEd.SRD.Race {
    public class HighElf : AElf {
        public new string Name => "High Elf";
        public override string ID => "SRD.Race.Elf.High";

        public override IRace GetInstance() => new HighElf();
    }
}
