#if GL_VERSION_1_1

public enum InterleavedArrayFormat : GLenum { 
#if GL_VERSION_1_1
    V2f = gl.Constants.GL_V2F, 
#endif

#if GL_VERSION_1_1
    V3f = gl.Constants.GL_V3F, 
#endif

#if GL_VERSION_1_1
    C4ubV2f = gl.Constants.GL_C4UB_V2F, 
#endif

#if GL_VERSION_1_1
    C4ubV3f = gl.Constants.GL_C4UB_V3F, 
#endif

#if GL_VERSION_1_1
    C3fV3f = gl.Constants.GL_C3F_V3F, 
#endif

#if GL_VERSION_1_1
    N3fV3f = gl.Constants.GL_N3F_V3F, 
#endif

#if GL_VERSION_1_1
    C4fN3fV3f = gl.Constants.GL_C4F_N3F_V3F, 
#endif

#if GL_VERSION_1_1
    T2fV3f = gl.Constants.GL_T2F_V3F, 
#endif

#if GL_VERSION_1_1
    T4fV4f = gl.Constants.GL_T4F_V4F, 
#endif

#if GL_VERSION_1_1
    T2fC4ubV3f = gl.Constants.GL_T2F_C4UB_V3F, 
#endif

#if GL_VERSION_1_1
    T2fC3fV3f = gl.Constants.GL_T2F_C3F_V3F, 
#endif

#if GL_VERSION_1_1
    T2fN3fV3f = gl.Constants.GL_T2F_N3F_V3F, 
#endif

#if GL_VERSION_1_1
    T2fC4fN3fV3f = gl.Constants.GL_T2F_C4F_N3F_V3F, 
#endif

#if GL_VERSION_1_1
    T4fC4fN3fV4f = gl.Constants.GL_T4F_C4F_N3F_V4F, 
#endif

}

#endif
