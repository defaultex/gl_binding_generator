#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_VERSION_1_2 || GL_VERSION_1_4 || GL_ES_VERSION_3_2 || GL_VERSION_1_3 || GL_ARB_TEXTURE_BORDER_CLAMP || GL_NV_TEXTURE_BORDER_CLAMP || GL_SGIS_TEXTURE_BORDER_CLAMP || GL_SGIS_TEXTURE_EDGE_CLAMP)

public enum TextureWrapMode : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    LinearMipmapLinear = gl.Constants.GL_LINEAR_MIPMAP_LINEAR, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Repeat = gl.Constants.GL_REPEAT, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_2 || GL_VERSION_ES_CM_1_0)
    ClampToEdge = gl.Constants.GL_CLAMP_TO_EDGE, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_4)
    MirroredRepeat = gl.Constants.GL_MIRRORED_REPEAT, 
#endif

#if (GL_ES_VERSION_3_2 || GL_VERSION_1_3)
    ClampToBorder = gl.Constants.GL_CLAMP_TO_BORDER, 
#endif

#if GL_VERSION_1_0
    Clamp = gl.Constants.GL_CLAMP, 
#endif

#if GL_ARB_TEXTURE_BORDER_CLAMP
    ClampToBorderArb = gl.Constants.GL_CLAMP_TO_BORDER_ARB, 
#endif

#if GL_NV_TEXTURE_BORDER_CLAMP
    ClampToBorderNv = gl.Constants.GL_CLAMP_TO_BORDER_NV, 
#endif

#if GL_SGIS_TEXTURE_BORDER_CLAMP
    ClampToBorderSgis = gl.Constants.GL_CLAMP_TO_BORDER_SGIS, 
#endif

#if GL_SGIS_TEXTURE_EDGE_CLAMP
    ClampToEdgeSgis = gl.Constants.GL_CLAMP_TO_EDGE_SGIS, 
#endif

}

#endif
