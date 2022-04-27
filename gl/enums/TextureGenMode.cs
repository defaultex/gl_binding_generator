#if (GL_VERSION_1_0 || GL_SGIS_POINT_LINE_TEXGEN)

public enum TextureGenMode : GLenum { 
#if GL_VERSION_1_0
    EyeLinear = gl.Constants.GL_EYE_LINEAR, 
#endif

#if GL_VERSION_1_0
    ObjectLinear = gl.Constants.GL_OBJECT_LINEAR, 
#endif

#if GL_VERSION_1_0
    SphereMap = gl.Constants.GL_SPHERE_MAP, 
#endif

#if GL_SGIS_POINT_LINE_TEXGEN
    EyeDistanceToPointSgis = gl.Constants.GL_EYE_DISTANCE_TO_POINT_SGIS, 
#endif

#if GL_SGIS_POINT_LINE_TEXGEN
    ObjectDistanceToPointSgis = gl.Constants.GL_OBJECT_DISTANCE_TO_POINT_SGIS, 
#endif

#if GL_SGIS_POINT_LINE_TEXGEN
    EyeDistanceToLineSgis = gl.Constants.GL_EYE_DISTANCE_TO_LINE_SGIS, 
#endif

#if GL_SGIS_POINT_LINE_TEXGEN
    ObjectDistanceToLineSgis = gl.Constants.GL_OBJECT_DISTANCE_TO_LINE_SGIS, 
#endif

}

#endif
