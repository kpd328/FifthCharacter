using System.Text.RegularExpressions;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Wizard.SchoolOfEvocation {
    public abstract class AFeatureWizardEvocation : AFeatureWizard {
        public override string ID => string.Format("SRD.Feature.Class.Wizard.Evocation.{0}", Regex.Replace(Name, @"[^0-9a-zA-Z]+", ""));
        public override string Source => string.Format("{0} (School of Evocation)", base.Source);
    }
}
