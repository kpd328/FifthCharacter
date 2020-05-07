using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace WotC.FifthEd.SRD.Race {
    public class LightfootHalfling : AHalfling {
        public new string Name => "Lightfoot Halfling";
        public override string ID => "SRD.Race.Halfling.Lightfoot";

        public override IRace GetInstance() => new LightfootHalfling();
    }
}
