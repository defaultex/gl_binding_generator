#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_SGIS_DETAIL_TEXTURE || GL_SGIS_SHARPEN_TEXTURE || GL_SGIS_TEXTURE_FILTER4)

public enum TextureMagFilter : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Nearest = gl.Constants.GL_NEAREST, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Linear = gl.Constants.GL_LINEAR, 
#endif

#if GL_SGIS_DETAIL_TEXTURE
    LinearDetailSgis = gl.Constants.GL_LINEAR_DETAIL_SGIS, 
#endif

#if GL_SGIS_DETAIL_TEXTURE
    LinearDetailAlphaSgis = gl.Constants.GL_LINEAR_DETAIL_ALPHA_SGIS, 
#endif

#if GL_SGIS_DETAIL_TEXTURE
    LinearDetailColorSgis = gl.Constants.GL_LINEAR_DETAIL_COLOR_SGIS, 
#endif

#if GL_SGIS_SHARPEN_TEXTURE
    LinearSharpenSgis = gl.Constants.GL_LINEAR_SHARPEN_SGIS, 
#endif

#if GL_SGIS_SHARPEN_TEXTURE
    LinearSharpenAlphaSgis = gl.Constants.GL_LINEAR_SHARPEN_ALPHA_SGIS, 
#endif

#if GL_SGIS_SHARPEN_TEXTURE
    LinearSharpenColorSgis = gl.Constants.GL_LINEAR_SHARPEN_COLOR_SGIS, 
#endif

#if GL_SGIS_TEXTURE_FILTER4
    Filter4Sgis = gl.Constants.GL_FILTER4_SGIS, 
#endif

}

#endif
