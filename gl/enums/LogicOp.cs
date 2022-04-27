#if (GL_ES_VERSION_2_0 || GL_NV_BLEND_EQUATION_ADVANCED || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)

public enum LogicOp : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_NV_BLEND_EQUATION_ADVANCED || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Invert = gl.Constants.GL_INVERT, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Clear = gl.Constants.GL_CLEAR, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    And = gl.Constants.GL_AND, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    AndReverse = gl.Constants.GL_AND_REVERSE, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Copy = gl.Constants.GL_COPY, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    AndInverted = gl.Constants.GL_AND_INVERTED, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Noop = gl.Constants.GL_NOOP, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Xor = gl.Constants.GL_XOR, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Or = gl.Constants.GL_OR, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Nor = gl.Constants.GL_NOR, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Equiv = gl.Constants.GL_EQUIV, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    OrReverse = gl.Constants.GL_OR_REVERSE, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    CopyInverted = gl.Constants.GL_COPY_INVERTED, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    OrInverted = gl.Constants.GL_OR_INVERTED, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Nand = gl.Constants.GL_NAND, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Set = gl.Constants.GL_SET, 
#endif

}

#endif
