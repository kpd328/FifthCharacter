namespace FifthCharacter.Plugin.Interface {
    public interface IProficiency {
        string Name { get; }
        string Source { get; }
        string ID { get; }
        ProficiencyType ProficiencyType { get; }
    }

    public enum ProficiencyType {
        ARMOR,
        WEAPON,
        TOOL,
        SAVING_THROW,
        SKILL,
        LANGUAGE
    }
}
