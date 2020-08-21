using FifthCharacter.Plugin.Equipment.Abstract;

namespace WotC.FifthEd.SRD.Equipment.Currency {
    public class SilverPiece : ACurrency {
        public override string Name => Count == 1 ? "Silver Piece" : "Silver Pieces";
        public override string ID => "SRD.Equipment.Currency.Silver";
        public override string Cost => "0.1 gp";
    }
}
