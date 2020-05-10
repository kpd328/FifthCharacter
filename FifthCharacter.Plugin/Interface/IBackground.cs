namespace FifthCharacter.Plugin.Interface {
    public interface IBackground {
        string Name { get; }
        string ID { get; }

        IBackground GetInstance();
    }
}
