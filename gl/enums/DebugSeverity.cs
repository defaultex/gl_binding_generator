#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_4_3)

public enum DebugSeverity : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    DontCare = gl.Constants.GL_DONT_CARE, 
#endif

#if (GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_4_3)
    SeverityNotification = gl.Constants.GL_DEBUG_SEVERITY_NOTIFICATION, 
#endif

#if (GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_4_3)
    SeverityHigh = gl.Constants.GL_DEBUG_SEVERITY_HIGH, 
#endif

#if (GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_4_3)
    SeverityMedium = gl.Constants.GL_DEBUG_SEVERITY_MEDIUM, 
#endif

#if (GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_4_3)
    SeverityLow = gl.Constants.GL_DEBUG_SEVERITY_LOW, 
#endif

}

#endif
