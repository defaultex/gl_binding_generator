#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_4_3)

public enum DebugSource : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    DontCare = gl.Constants.GL_DONT_CARE, 
#endif

#if (GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_4_3)
    SourceApi = gl.Constants.GL_DEBUG_SOURCE_API, 
#endif

#if (GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_4_3)
    SourceWindowSystem = gl.Constants.GL_DEBUG_SOURCE_WINDOW_SYSTEM, 
#endif

#if (GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_4_3)
    SourceShaderCompiler = gl.Constants.GL_DEBUG_SOURCE_SHADER_COMPILER, 
#endif

#if (GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_4_3)
    SourceThirdParty = gl.Constants.GL_DEBUG_SOURCE_THIRD_PARTY, 
#endif

#if (GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_4_3)
    SourceApplication = gl.Constants.GL_DEBUG_SOURCE_APPLICATION, 
#endif

#if (GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_4_3)
    SourceOther = gl.Constants.GL_DEBUG_SOURCE_OTHER, 
#endif

}

#endif
