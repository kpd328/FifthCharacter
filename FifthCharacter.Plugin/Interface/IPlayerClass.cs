namespace FifthCharacter.Plugin.Interface {
    public interface IPlayerClass {
        string Name { get; }
        string ID { get; }

        IPlayerClass GetInstance();
    }
}
