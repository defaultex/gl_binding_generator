#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0)

public enum ShaderParameterName : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0)
    Type = gl.Constants.GL_SHADER_TYPE, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0)
    DeleteStatus = gl.Constants.GL_DELETE_STATUS, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0)
    CompileStatus = gl.Constants.GL_COMPILE_STATUS, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0)
    InfoLogLength = gl.Constants.GL_INFO_LOG_LENGTH, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_2_0)
    SourceLength = gl.Constants.GL_SHADER_SOURCE_LENGTH, 
#endif

}

#endif
