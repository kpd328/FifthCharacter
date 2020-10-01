using System;

namespace WotC.FifthEd.SRD.Equipment.Currency {
    public static class CurrencyTools {
        //Down to Copper
        /// <summary>
        /// Converts Silver Pieces to Copper Pieces
        /// </summary>
        /// <param name="sp">the source SilverPiece object to be converted</param>
        /// <returns>the new CopperPiece object, containing an equivalent value of the source SilverPiece object</returns>
        public static CopperPiece ToCopperPieces(this SilverPiece sp) {
            return new CopperPiece(sp.Count * 10);
        }

        /// <summary>
        /// Converts Electrum Pieces to Copper Pieces
        /// </summary>
        /// <param name="ep">the source ElectrumPiece object to be converted</param>
        /// <returns>the new CopperPiece object, containing an equivalent value of the source ElectrumPiece object</returns>
        public static CopperPiece ToCopperPieces(this ElectrumPiece ep) {
            return new CopperPiece(ep.Count * 50);
        }

        /// <summary>
        /// Converts Gold Pieces to Copper Pieces
        /// </summary>
        /// <param name="gp">the source GoldPiece object to be converted</param>
        /// <returns>the new CopperPiece object, containing an equivalent value of the source GoldPiece object</returns>
        public static CopperPiece ToCopperPieces(this GoldPiece gp) {
            return new CopperPiece(gp.Count * 100);
        }

        /// <summary>
        /// Converts Platinum Pieces to Copper Pieces
        /// </summary>
        /// <param name="pp">the source PlatinumPiece object to be converted</param>
        /// <returns>the new CopperPiece object, containing an equivalent value of the source PlatinumPiece object</returns>
        public static CopperPiece ToCopperPieces(this PlatinumPiece pp) {
            return new CopperPiece(pp.Count * 1000);
        }

        //Down To Silver
        /// <summary>
        /// Converts Electrum Pieces to Silver Pieces
        /// </summary>
        /// <param name="ep">the source ElectrumPiece object to be converted</param>
        /// <returns>the new SilverPiece object, containing an equivalent value of the source ElectrumPiece object</returns>
        public static SilverPiece ToSilverPieces(this ElectrumPiece ep) {
            return new SilverPiece(ep.Count * 5);
        }

        /// <summary>
        /// Converts Gold Pieces to Silver Pieces
        /// </summary>
        /// <param name="gp">the source GoldPiece object to be converted</param>
        /// <returns>the new SilverPiece object, containing an equivalent value of the source GoldPiece object</returns>
        public static SilverPiece ToSilverPieces(this GoldPiece gp) {
            return new SilverPiece(gp.Count * 10);
        }

        /// <summary>
        /// Converts Platinum Pieces to Silver Pieces
        /// </summary>
        /// <param name="pp">the source PlatinumPiece object to be converted</param>
        /// <returns>the new SilverPiece object, containing an equivalent value of the source PlatinumPiece object</returns>
        public static SilverPiece ToSilverPieces(this PlatinumPiece pp) {
            return new SilverPiece(pp.Count * 100);
        }

        //Down to Electrum
        /// <summary>
        /// Converts Gold Pieces to Electrum Pieces
        /// </summary>
        /// <param name="gp">the source GoldPiece object to be converted</param>
        /// <returns>the new ElectrumPiece object, containing an equivalent value of the source GoldPiece object</returns>
        public static ElectrumPiece ToElectrumPieces(this GoldPiece gp) {
            return new ElectrumPiece(gp.Count * 2);
        }

        /// <summary>
        /// Converts Platinum Pieces to Electrum Pieces
        /// </summary>
        /// <param name="pp">the source PlatinumPiece object to be converted</param>
        /// <returns>the new ElectrumPiece object, containing an equivalent value of the source PlatinumPiece object</returns>
        public static ElectrumPiece ToElectrumPieces(this PlatinumPiece pp) {
            return new ElectrumPiece(pp.Count * 20);
        }

        //Down to Gold
        /// <summary>
        /// Converts Platinum Pieces to Gold Pieces
        /// </summary>
        /// <param name="pp">the source PlatinumPiece object to be converted</param>
        /// <returns>the new GoldPiece object, containing an equivalent value of the source PlatinumPiece object</returns>
        public static GoldPiece ToGoldPieces(this PlatinumPiece pp) {
            return new GoldPiece(pp.Count * 10);
        }

        //Up to Silver
        /// <summary>
        /// Converts Copper Pieces to Silver Pieces, keeping the remainder in the original CopperPiece object
        /// </summary>
        /// <param name="cp">the source CopperPiece object. Will be mutated to include the remainder of non-converted value.</param>
        /// <returns>the new SilverPiece object, containing an equivalent value of the source CopperPiece object, sans the incompatible remainder of the conversion.</returns>
        public static SilverPiece ToSilverPieces(this CopperPiece cp) {
            var sp = (int)Math.Floor(cp.Count / 10.0);
            cp.Count = cp.Count % 10;
            return new SilverPiece(sp);
        }

        //Up to Electrum
        /// <summary>
        /// Converts Copper Pieces to Electrum Pieces, keeping the remainder in the original CopperPiece object
        /// </summary>
        /// <param name="cp">the source CopperPiece object. Will be mutated to include the remainder of non-converted value.</param>
        /// <returns>the new ElectrumPiece object, containing an equivalent value of the source CopperPiece object, sans the incompatible remainder of the conversion.</returns>
        public static ElectrumPiece ToElectrumPieces(this CopperPiece cp) {
            var ep = (int)Math.Floor(cp.Count / 50.0);
            cp.Count = cp.Count % 50;
            return new ElectrumPiece(ep);
        }

        /// <summary>
        /// Converts Silver Pieces to Electrum Pieces, keeping the remainder in the original CopperPiece object
        /// </summary>
        /// <param name="sp">the source SilverPiece object. Will be mutated to include the remainder of non-converted value.</param>
        /// <returns>the new ElectrumPiece object, containing an equivalent value of the source CopperPiece object, sans the incompatible remainder of the conversion.</returns>
        public static ElectrumPiece ToElectrumPieces(this SilverPiece sp) {
            var ep = (int)Math.Floor(sp.Count / 5.0);
            sp.Count = sp.Count % 5;
            return new ElectrumPiece(ep);
        }

        //Up to Gold
        /// <summary>
        /// Converts Copper Pieces to Gold Pieces, kegping the remainder in the original CopperPiece object
        /// </summary>
        /// <param name="cp">the source CopperPiece object. Will be mutated to include the remainder of non-converted value.</param>
        /// <returns>the new GoldPiece object, containing an equivalent value of the source CopperPiece object, sans the incompatible remainder of the conversion.</returns>
        public static GoldPiece ToGoldPieces(this CopperPiece cp) {
            var gp = (int)Math.Floor(cp.Count / 100.0);
            cp.Count = cp.Count % 100;
            return new GoldPiece(gp);
        }

        /// <summary>
        /// Converts Silver Pieces to Gold Pieces, kegping the remainder in the original CopperPiece object
        /// </summary>
        /// <param name="sp">the source SilverPiece object. Will be mutated to include the remainder of non-converted value.</param>
        /// <returns>the new GoldPiece object, containing an equivalent value of the source CopperPiece object, sans the incompatible remainder of the conversion.</returns>
        public static GoldPiece ToGoldPieces(this SilverPiece sp) {
            var gp = (int)Math.Floor(sp.Count / 10.0);
            sp.Count = sp.Count % 10;
            return new GoldPiece(gp);
        }

        /// <summary>
        /// Converts Electrum Pieces to Gold Pieces, kegping the remainder in the original CopperPiece object
        /// </summary>
        /// <param name="ep">the source ElectrumPiece object. Will be mutated to include the remainder of non-converted value.</param>
        /// <returns>the new GoldPiece object, containing an equivalent value of the source CopperPiece object, sans the incompatible remainder of the conversion.</returns>
        public static GoldPiece ToGoldPieces(this ElectrumPiece ep) {
            var gp = (int)Math.Floor(ep.Count / 2.0);
            ep.Count = ep.Count % 2;
            return new GoldPiece(gp);
        }

        //Up to Platinum
        /// <summary>
        /// Converts Copper Pieces to Platinum Pieces, kepping the remainder in the original CopperPiece object
        /// </summary>
        /// <param name="cp">the source CopperPiece object. Will be mutated to include the remainder of non-converted value.</param>
        /// <returns>the new PlatinumPiece object, containing an equivalent value of the source CopperPiece object, sans the incompatible remainder of the conversion.</returns>
        public static PlatinumPiece ToPlatinumPieces(this CopperPiece cp) {
            var pp = (int)Math.Floor(cp.Count / 1000.0);
            cp.Count = cp.Count % 1000;
            return new PlatinumPiece(pp);
        }

        /// <summary>
        /// Converts Silver Pieces to Platinum Pieces, kepping the remainder in the original CopperPiece object
        /// </summary>
        /// <param name="sp">the source SilverPiece object. Will be mutated to include the remainder of non-converted value.</param>
        /// <returns>the new PlatinumPiece object, containing an equivalent value of the source CopperPiece object, sans the incompatible remainder of the conversion.</returns>
        public static PlatinumPiece ToPlatinumPieces(this SilverPiece sp) {
            var pp = (int)Math.Floor(sp.Count / 100.0);
            sp.Count = sp.Count % 100;
            return new PlatinumPiece(pp);
        }

        /// <summary>
        /// Converts Electrum Pieces to Platinum Pieces, kepping the remainder in the original CopperPiece object
        /// </summary>
        /// <param name="ep">the source ElectrumPiece object. Will be mutated to include the remainder of non-converted value.</param>
        /// <returns>the new PlatinumPiece object, containing an equivalent value of the source CopperPiece object, sans the incompatible remainder of the conversion.</returns>
        public static PlatinumPiece ToPlatinumPieces(this ElectrumPiece ep) {
            var pp = (int)Math.Floor(ep.Count / 20.0);
            ep.Count = ep.Count % 20;
            return new PlatinumPiece(pp);
        }

        /// <summary>
        /// Converts Gold Pieces to Platinum Pieces, kepping the remainder in the original CopperPiece object
        /// </summary>
        /// <param name="gp">the source GoldPiece object. Will be mutated to include the remainder of non-converted value.</param>
        /// <returns>the new PlatinumPiece object, containing an equivalent value of the source CopperPiece object, sans the incompatible remainder of the conversion.</returns>
        public static PlatinumPiece ToPlatinumPieces(this GoldPiece gp) {
            var pp = (int)Math.Floor(gp.Count / 10.0);
            gp.Count = gp.Count % 100;
            return new PlatinumPiece(pp);
        }
    }
}
