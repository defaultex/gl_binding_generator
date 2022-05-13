public enum LogicOp : GLenum {
    Clear = gl.Constants.GL_CLEAR,
    And = gl.Constants.GL_AND,
    AndReverse = gl.Constants.GL_AND_REVERSE,
    Copy = gl.Constants.GL_COPY,
    AndInverted = gl.Constants.GL_AND_INVERTED,
    Noop = gl.Constants.GL_NOOP,
    Xor = gl.Constants.GL_XOR,
    Or = gl.Constants.GL_OR,
    Nor = gl.Constants.GL_NOR,
    Equiv = gl.Constants.GL_EQUIV,
    Invert = gl.Constants.GL_INVERT,
    OrReverse = gl.Constants.GL_OR_REVERSE,
    CopyInverted = gl.Constants.GL_COPY_INVERTED,
    OrInverted = gl.Constants.GL_OR_INVERTED,
    Nand = gl.Constants.GL_NAND,
    Set = gl.Constants.GL_SET,
}
