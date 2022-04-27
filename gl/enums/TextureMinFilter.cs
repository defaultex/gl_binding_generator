#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_SGIS_TEXTURE_FILTER4 || GL_SGIX_CLIPMAP)

public enum TextureMinFilter : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Nearest = gl.Constants.GL_NEAREST, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Linear = gl.Constants.GL_LINEAR, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    NearestMipmapNearest = gl.Constants.GL_NEAREST_MIPMAP_NEAREST, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    LinearMipmapNearest = gl.Constants.GL_LINEAR_MIPMAP_NEAREST, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    NearestMipmapLinear = gl.Constants.GL_NEAREST_MIPMAP_LINEAR, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    LinearMipmapLinear = gl.Constants.GL_LINEAR_MIPMAP_LINEAR, 
#endif

#if GL_SGIS_TEXTURE_FILTER4
    Filter4Sgis = gl.Constants.GL_FILTER4_SGIS, 
#endif

#if GL_SGIX_CLIPMAP
    LinearClipmapLinearSgix = gl.Constants.GL_LINEAR_CLIPMAP_LINEAR_SGIX, 
#endif

#if GL_SGIX_CLIPMAP
    NearestClipmapNearestSgix = gl.Constants.GL_NEAREST_CLIPMAP_NEAREST_SGIX, 
#endif

#if GL_SGIX_CLIPMAP
    NearestClipmapLinearSgix = gl.Constants.GL_NEAREST_CLIPMAP_LINEAR_SGIX, 
#endif

#if GL_SGIX_CLIPMAP
    LinearClipmapNearestSgix = gl.Constants.GL_LINEAR_CLIPMAP_NEAREST_SGIX, 
#endif

}

#endif
