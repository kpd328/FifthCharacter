using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Spells.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace WotC.FifthEd.SRD.Spells.Divination {
    public class ArcaneEye : ASchoolDivination {
        public override SpellLevel SpellLevel => throw new NotImplementedException();
        public override bool Ritual => throw new NotImplementedException();
        public override string CastingTime => throw new NotImplementedException();
        public override string Range => throw new NotImplementedException();
        public override IList<string> Components => throw new NotImplementedException();
        public override string Duration => throw new NotImplementedException();
        public override string Targets => throw new NotImplementedException();
        public override string AreaOfEffect => throw new NotImplementedException();
        public override string Name => throw new NotImplementedException();

        public override IMagic GetInstance() {
            throw new NotImplementedException();
        }
    }
}
