#if (GL_VERSION_1_0 || GL_NV_FOG_DISTANCE || GL_SGIS_POINT_LINE_TEXGEN)

public enum TextureGenParameter : GLenum { 
#if GL_VERSION_1_0
    Mode = gl.Constants.GL_TEXTURE_GEN_MODE, 
#endif

#if GL_VERSION_1_0
    ObjectPlane = gl.Constants.GL_OBJECT_PLANE, 
#endif

#if (GL_NV_FOG_DISTANCE || GL_VERSION_1_0)
    EyePlane = gl.Constants.GL_EYE_PLANE, 
#endif

#if GL_SGIS_POINT_LINE_TEXGEN
    EyePointSgis = gl.Constants.GL_EYE_POINT_SGIS, 
#endif

#if GL_SGIS_POINT_LINE_TEXGEN
    ObjectPointSgis = gl.Constants.GL_OBJECT_POINT_SGIS, 
#endif

#if GL_SGIS_POINT_LINE_TEXGEN
    EyeLineSgis = gl.Constants.GL_EYE_LINE_SGIS, 
#endif

#if GL_SGIS_POINT_LINE_TEXGEN
    ObjectLineSgis = gl.Constants.GL_OBJECT_LINE_SGIS, 
#endif

}

#endif
