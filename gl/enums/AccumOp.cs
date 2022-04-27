#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)

public enum AccumOp : GLenum { 
#if GL_VERSION_1_0
    Accum = gl.Constants.GL_ACCUM, 
#endif

#if GL_VERSION_1_0
    Load = gl.Constants.GL_LOAD, 
#endif

#if GL_VERSION_1_0
    Return = gl.Constants.GL_RETURN, 
#endif

#if GL_VERSION_1_0
    Mult = gl.Constants.GL_MULT, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Add = gl.Constants.GL_ADD, 
#endif

}

#endif
