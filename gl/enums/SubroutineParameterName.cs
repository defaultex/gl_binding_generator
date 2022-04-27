#if (GL_ARB_SHADER_SUBROUTINE || GL_ARB_UNIFORM_BUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_1 || GL_ARB_PROGRAM_INTERFACE_QUERY || GL_VERSION_4_0)

public enum SubroutineParameterName : GLenum { 
#if (GL_ARB_SHADER_SUBROUTINE || GL_ARB_UNIFORM_BUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_1)
    UniformSize = gl.Constants.GL_UNIFORM_SIZE, 
#endif

#if (GL_ARB_SHADER_SUBROUTINE || GL_ARB_UNIFORM_BUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_1)
    UniformNameLength = gl.Constants.GL_UNIFORM_NAME_LENGTH, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ARB_SHADER_SUBROUTINE || GL_VERSION_4_0)
    NumCompatibleSubroutines = gl.Constants.GL_NUM_COMPATIBLE_SUBROUTINES, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ARB_SHADER_SUBROUTINE || GL_VERSION_4_0)
    CompatibleSubroutines = gl.Constants.GL_COMPATIBLE_SUBROUTINES, 
#endif

}

#endif
