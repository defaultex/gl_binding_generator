#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_EXT_VERTEX_WEIGHTING)

public enum MatrixMode : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Texture = gl.Constants.GL_TEXTURE, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Modelview = gl.Constants.GL_MODELVIEW, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Projection = gl.Constants.GL_PROJECTION, 
#endif

#if GL_EXT_VERTEX_WEIGHTING
    Modelview0Ext = gl.Constants.GL_MODELVIEW0_EXT, 
#endif

}

#endif
