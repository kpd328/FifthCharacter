using System;

namespace FifthCharacter.Plugin {
    public interface IPlugin {
        string Name { get; }
        string Description { get; }
        string Author { get; }
        string Version { get; }
    }
}
