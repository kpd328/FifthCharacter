using System.Text.RegularExpressions;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Paladin.OathOfDevotion {
    public abstract class AFeaturePaladinOathOfDevotion : AFeaturePaladin {
        public override string ID => string.Format("SRD.Feature.Class.Fighter.Champion.{0}", Regex.Replace(Name, @"[^0-9a-zA-Z]+", ""));
        public override string Source => string.Format("{0} (Oath of Devotion)", base.Source);
    }
}
