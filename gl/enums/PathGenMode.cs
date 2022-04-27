#if (GL_ES_VERSION_2_0 || GL_KHR_CONTEXT_FLUSH_CONTROL || GL_NV_REGISTER_COMBINERS || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_4_5 || GL_VERSION_4_6 || GL_VERSION_1_3 || GL_VERSION_ES_CM_1_0 || GL_NV_PATH_RENDERING)

public enum PathGenMode : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_KHR_CONTEXT_FLUSH_CONTROL || GL_NV_REGISTER_COMBINERS || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_4_5 || GL_VERSION_4_6)
    None = gl.Constants.GL_NONE, 
#endif

#if GL_VERSION_1_0
    EyeLinear = gl.Constants.GL_EYE_LINEAR, 
#endif

#if GL_VERSION_1_0
    ObjectLinear = gl.Constants.GL_OBJECT_LINEAR, 
#endif

#if (GL_VERSION_1_3 || GL_VERSION_ES_CM_1_0)
    Constant = gl.Constants.GL_CONSTANT, 
#endif

#if GL_NV_PATH_RENDERING
    ObjectBoundingBoxNv = gl.Constants.GL_PATH_OBJECT_BOUNDING_BOX_NV, 
#endif

}

#endif
