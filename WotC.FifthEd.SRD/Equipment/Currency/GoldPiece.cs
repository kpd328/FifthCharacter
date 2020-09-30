using FifthCharacter.Plugin.Equipment.Abstract;

namespace WotC.FifthEd.SRD.Equipment.Currency {
    public class GoldPiece : ACurrency {
        public override string Name => Count == 1 ? "Gold Piece" : "Gold Pieces";
        public override string ID => "SRD.Equipment.Currency.Gold";
        public override ACurrency Cost => new CopperPiece(100);
        public override string ShortName => "gp";

        public GoldPiece() { }

        public GoldPiece(int count) => Count = count;
    }
}
