using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace WotC.FifthEd.SRD.Race {
    public class RockGnome : AGnome {
        public new string Name => "Rock Gnome";
        public override string ID => "SRD.Race.Gnome.Rock";

        public override IRace GetInstance() => new RockGnome();
    }
}
