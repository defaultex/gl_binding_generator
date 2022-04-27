#if (GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_4_3 || GL_VERSION_4_5 || GL_VERSION_3_0 || GL_VERSION_4_6 || GL_ARB_ROBUSTNESS || GL_EXT_PROTECTED_TEXTURES || GL_KHR_NO_ERROR)
[Flags]
public enum ContextFlagMask : GLbitfield { 
    None = 0,
#if (GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_4_3)
    Debug = gl.Constants.GL_CONTEXT_FLAG_DEBUG_BIT, 
#endif

#if (GL_ES_VERSION_3_2 || GL_VERSION_4_5)
    RobustAccess = gl.Constants.GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT, 
#endif

#if GL_VERSION_3_0
    ForwardCompatible = gl.Constants.GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT, 
#endif

#if GL_VERSION_4_6
    NoError = gl.Constants.GL_CONTEXT_FLAG_NO_ERROR_BIT, 
#endif

#if GL_ARB_ROBUSTNESS
    RobustAccessBitArb = gl.Constants.GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB, 
#endif

#if GL_EXT_PROTECTED_TEXTURES
    ProtectedContentBitExt = gl.Constants.GL_CONTEXT_FLAG_PROTECTED_CONTENT_BIT_EXT, 
#endif

#if GL_KHR_DEBUG
    DebugBitKhr = gl.Constants.GL_CONTEXT_FLAG_DEBUG_BIT_KHR, 
#endif

#if GL_KHR_NO_ERROR
    NoErrorBitKhr = gl.Constants.GL_CONTEXT_FLAG_NO_ERROR_BIT_KHR, 
#endif

}

#endif
