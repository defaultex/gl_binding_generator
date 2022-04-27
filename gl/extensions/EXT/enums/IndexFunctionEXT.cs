#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_ARB_TESSELLATION_SHADER || GL_ES_VERSION_3_2 || GL_EXT_TESSELLATION_SHADER || GL_OES_TESSELLATION_SHADER)

public enum IndexFunctionEXT : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Never = gl.Constants.GL_NEVER, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Less = gl.Constants.GL_LESS, 
#endif

#if (GL_ARB_TESSELLATION_SHADER || GL_ES_VERSION_2_0 || GL_ES_VERSION_3_2 || GL_EXT_TESSELLATION_SHADER || GL_OES_TESSELLATION_SHADER || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Equal = gl.Constants.GL_EQUAL, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Lequal = gl.Constants.GL_LEQUAL, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Greater = gl.Constants.GL_GREATER, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Notequal = gl.Constants.GL_NOTEQUAL, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Gequal = gl.Constants.GL_GEQUAL, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Always = gl.Constants.GL_ALWAYS, 
#endif

}

#endif