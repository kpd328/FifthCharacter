using System.Text.RegularExpressions;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Fighter.Champion {
    public abstract class AFeatureFighterChampion : AFeatureFighter {
        public override string ID => string.Format("SRD.Feature.Class.Fighter.Champion.{0}", Regex.Replace(Name, @"[^0-9a-zA-Z]+", ""));
        public override string Source => string.Format("{0} (Champion)", base.Source);
    }
}
