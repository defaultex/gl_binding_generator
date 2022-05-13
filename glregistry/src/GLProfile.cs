namespace glregistry;

public enum GLProfile {
    None = 0,

    [XmlEnum("core")]
    Core = 1,

    [XmlEnum("compatibility")]
    Compatibility = 2,

    [XmlEnum("common")]
    Common = 3
}