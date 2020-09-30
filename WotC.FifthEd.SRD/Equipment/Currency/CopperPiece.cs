using FifthCharacter.Plugin.Equipment.Abstract;

namespace WotC.FifthEd.SRD.Equipment.Currency {
    public class CopperPiece : ACurrency {
        public override string Name => Count == 1 ? "Copper Piece" : "Copper Pieces";
        public override string ID => "SRD.Equipment.Currency.Copper";
        public override ACurrency Cost => new CopperPiece(1);
        public override string ShortName => "cp";

        public CopperPiece() { }

        public CopperPiece(int count) => Count = count;
    }
}
