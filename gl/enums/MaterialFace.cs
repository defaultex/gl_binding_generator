#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_ARB_ES3_1_COMPATIBILITY || GL_VERSION_4_5)

public enum MaterialFace : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Front = gl.Constants.GL_FRONT, 
#endif

#if (GL_ARB_ES3_1_COMPATIBILITY || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_4_5 || GL_VERSION_ES_CM_1_0)
    Back = gl.Constants.GL_BACK, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    FrontAndBack = gl.Constants.GL_FRONT_AND_BACK, 
#endif

}

#endif
