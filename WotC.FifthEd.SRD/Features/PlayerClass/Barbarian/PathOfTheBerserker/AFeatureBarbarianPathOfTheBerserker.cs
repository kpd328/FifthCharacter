using System.Text.RegularExpressions;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Barbarian.PathOfTheBerserker {
    public abstract class AFeatureBarbarianPathOfTheBerserker : AFeatureBarbarian {
        public override string Source => string.Format("{0} (Primal Champion)", base.Source);
        public override string ID => string.Format("SRD.Feature.Class.Barbarian.PathOfTheBerserker.{0}", Regex.Replace(Name, @"[^0-9a-zA-Z]+", ""));
    }
}
