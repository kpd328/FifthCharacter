using FifthCharacter.Plugin.Equipment.Abstract;

namespace WotC.FifthEd.SRD.Equipment.Currency {
    public class PlatinumPiece : ACurrency {
        public override string Name => Count == 1 ? "Platinum Piece" : "Platinum Pieces";
        public override string ID => "SRD.Equipment.Currency.Platinum";
        public override ACurrency Cost => new CopperPiece(1000);
        public override string ShortName => "pp";

        public PlatinumPiece() { }

        public PlatinumPiece(int count) => Count = count;
    }
}
