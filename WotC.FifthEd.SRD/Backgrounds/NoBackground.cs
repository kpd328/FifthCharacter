using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Backgrounds {
    public class NoBackground : IBackground {
        public string Name => "No Background";
        public string ID => "SRD.Background.None";

        public IBackground GetInstance() => new NoBackground();
    }
}
