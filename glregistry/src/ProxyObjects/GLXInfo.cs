namespace glregistry;

/// <summary>
/// Represents information about the GLX protocol for a command.
/// </summary>
public class GLXInfo {
    /// <summary>
    /// Type of GLX protocol.
    /// </summary>
    [XmlAttribute("type")]
    public string Type { get; init; }

    /// <summary>
    /// GLX protocol opcode. -1 if no opcode was specified.
    /// </summary>
    [XmlAttribute("opcode")]
    public int OpCode { get; init; } = -1;

    /// <summary>
    /// Equivalent command at GLX dispatch level.
    /// </summary>
    [XmlAttribute("name")]
    public string Name { get; init; }

    public override string ToString() => Name;
}
