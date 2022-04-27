#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_4_3)

public enum DebugType : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    DontCare = gl.Constants.GL_DONT_CARE, 
#endif

#if (GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_4_3)
    TypeError = gl.Constants.GL_DEBUG_TYPE_ERROR, 
#endif

#if (GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_4_3)
    TypeDeprecatedBehavior = gl.Constants.GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR, 
#endif

#if (GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_4_3)
    TypeUndefinedBehavior = gl.Constants.GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR, 
#endif

#if (GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_4_3)
    TypePortability = gl.Constants.GL_DEBUG_TYPE_PORTABILITY, 
#endif

#if (GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_4_3)
    TypePerformance = gl.Constants.GL_DEBUG_TYPE_PERFORMANCE, 
#endif

#if (GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_4_3)
    TypeOther = gl.Constants.GL_DEBUG_TYPE_OTHER, 
#endif

#if (GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_4_3)
    TypeMarker = gl.Constants.GL_DEBUG_TYPE_MARKER, 
#endif

#if (GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_4_3)
    TypePushGroup = gl.Constants.GL_DEBUG_TYPE_PUSH_GROUP, 
#endif

#if (GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_4_3)
    TypePopGroup = gl.Constants.GL_DEBUG_TYPE_POP_GROUP, 
#endif

}

#endif
