using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Sorcerer {
    public class FSorcererMetamagic : AFeatureSorcerer {
        public override string Name => Metamagic switch { 
            Metamagic.CAREFUL_SPELL => "Metamagic (Careful Spell)",
            Metamagic.DISTANT_SPELL => "Metamagic (Distant Spell)",
            Metamagic.EMPOWERED_SPELL => "Metamagic (Empowered Spell)",
            Metamagic.EXTENDED_SPELL => "Metamagic (Extended Spell)",
            Metamagic.HEIGHTENED_SPELL => "Metamagic (Heightened Spell)",
            Metamagic.QUICKENED_SPELL => "Metamagic (Quickened Spell)",
            Metamagic.SUBTLE_SPELL => "Metamagic (Subtle Spell)",
            Metamagic.TWINNED_SPELL => "Metamagic (Twinned Spell)",
            _ => "Metamagic", 
        };
        public override string Text => Metamagic switch {
            Metamagic.CAREFUL_SPELL => FeatureSorcererText.Metamagic__Careful_Spell,
            Metamagic.DISTANT_SPELL => FeatureSorcererText.Metamagic__Distant_Spell,
            Metamagic.EMPOWERED_SPELL => FeatureSorcererText.Metamagic__Empowered_Spell,
            Metamagic.EXTENDED_SPELL => FeatureSorcererText.Metamagic__Extended_Spell,
            Metamagic.HEIGHTENED_SPELL => FeatureSorcererText.Metamagic__Heightened_Spell,
            Metamagic.QUICKENED_SPELL => FeatureSorcererText.Metamagic__Quickened_Spell,
            Metamagic.SUBTLE_SPELL => FeatureSorcererText.Metamagic__Subtle_Spell,
            Metamagic.TWINNED_SPELL => FeatureSorcererText.Metamagic__Twinned_Spell,
            _ => FeatureSorcererText.Metamagic,
        };
        public Metamagic Metamagic;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        internal FSorcererMetamagic() { }

        public FSorcererMetamagic(bool isTaken) {
            //TODO: Prompt to pick metamagic
        }

        public override IFeature GetInstance() => new FSorcererMetamagic(true);
    }

    public enum Metamagic {
        CAREFUL_SPELL,
        DISTANT_SPELL,
        EMPOWERED_SPELL,
        EXTENDED_SPELL,
        HEIGHTENED_SPELL,
        QUICKENED_SPELL,
        SUBTLE_SPELL,
        TWINNED_SPELL
    }
}
