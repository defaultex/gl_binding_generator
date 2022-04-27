#if (GL_ARB_SHADER_SUBROUTINE || GL_VERSION_4_0)

public enum ProgramStagePName : GLenum { 
#if (GL_ARB_SHADER_SUBROUTINE || GL_VERSION_4_0)
    ActiveSubroutines = gl.Constants.GL_ACTIVE_SUBROUTINES, 
#endif

#if (GL_ARB_SHADER_SUBROUTINE || GL_VERSION_4_0)
    ActiveSubroutineUniforms = gl.Constants.GL_ACTIVE_SUBROUTINE_UNIFORMS, 
#endif

#if (GL_ARB_SHADER_SUBROUTINE || GL_VERSION_4_0)
    ActiveSubroutineUniformLocations = gl.Constants.GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS, 
#endif

#if (GL_ARB_SHADER_SUBROUTINE || GL_VERSION_4_0)
    ActiveSubroutineMaxLength = gl.Constants.GL_ACTIVE_SUBROUTINE_MAX_LENGTH, 
#endif

#if (GL_ARB_SHADER_SUBROUTINE || GL_VERSION_4_0)
    ActiveSubroutineUniformMaxLength = gl.Constants.GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH, 
#endif

}

#endif
