namespace FifthCharacter.Plugin.Interface {
    public interface IRace {
        string Name { get; }
        string ID { get; }

        IRace GetInstance();
    }
}
