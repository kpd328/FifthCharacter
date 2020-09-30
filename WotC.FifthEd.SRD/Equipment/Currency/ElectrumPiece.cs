using FifthCharacter.Plugin.Equipment.Abstract;

namespace WotC.FifthEd.SRD.Equipment.Currency {
    public class ElectrumPiece : ACurrency {
        public override string Name => Count == 1 ? "Electrum Piece" : "Electrum Pieces";
        public override string ID => "SRD.Equipment.Currency.Electrum";
        public override ACurrency Cost => new CopperPiece(50);
        public override string ShortName => "ep";

        public ElectrumPiece() { }

        public ElectrumPiece(int count) => Count = count;
    }
}
