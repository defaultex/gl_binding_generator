#if GL_VERSION_1_0

public enum ListMode : GLenum { 
#if GL_VERSION_1_0
    Compile = gl.Constants.GL_COMPILE, 
#endif

#if GL_VERSION_1_0
    CompileAndExecute = gl.Constants.GL_COMPILE_AND_EXECUTE, 
#endif

}

#endif
