#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_1 || GL_VERSION_4_3)

public enum ProgramInterfacePName : GLenum { 
#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    ActiveResources = gl.Constants.GL_ACTIVE_RESOURCES, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    MaxNameLength = gl.Constants.GL_MAX_NAME_LENGTH, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    MaxNumActiveVariables = gl.Constants.GL_MAX_NUM_ACTIVE_VARIABLES, 
#endif

#if (GL_ARB_PROGRAM_INTERFACE_QUERY || GL_VERSION_4_3)
    MaxNumCompatibleSubroutines = gl.Constants.GL_MAX_NUM_COMPATIBLE_SUBROUTINES, 
#endif

}

#endif
