#if (GL_ARB_SHADER_OBJECTS || GL_EXT_DEBUG_LABEL)

public enum ContainerType : GLenum { 
#if GL_ARB_SHADER_OBJECTS
    ProgramObjectArb = gl.Constants.GL_PROGRAM_OBJECT_ARB, 
#endif

#if GL_EXT_DEBUG_LABEL
    ProgramObjectExt = gl.Constants.GL_PROGRAM_OBJECT_EXT, 
#endif

}

#endif
