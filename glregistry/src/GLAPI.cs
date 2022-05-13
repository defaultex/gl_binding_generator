namespace glregistry;

[Flags]
public enum GLAPI {
    None = 0,

    [XmlEnum("gl")]
    GL = 1 << 0,

    [XmlEnum("glcore")]
    GLCore = 1 << 1,

    [XmlEnum("gles1")]
    GLES1 = 1 << 2,

    [XmlEnum("gles2")]
    GLES2 = 1 << 3,

    [XmlEnum("glsc2")]
    GLSC2 = 1 << 4
}