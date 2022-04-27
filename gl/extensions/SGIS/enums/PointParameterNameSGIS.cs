#if (GL_VERSION_1_4 || GL_VERSION_ES_CM_1_0 || GL_ARB_POINT_PARAMETERS || GL_EXT_POINT_PARAMETERS || GL_SGIS_POINT_PARAMETERS)

public enum PointParameterNameSGIS : GLenum { 
#if (GL_VERSION_1_4 || GL_VERSION_ES_CM_1_0)
    SizeMin = gl.Constants.GL_POINT_SIZE_MIN, 
#endif

#if (GL_VERSION_1_4 || GL_VERSION_ES_CM_1_0)
    SizeMax = gl.Constants.GL_POINT_SIZE_MAX, 
#endif

#if (GL_VERSION_1_4 || GL_VERSION_ES_CM_1_0)
    FadeThresholdSize = gl.Constants.GL_POINT_FADE_THRESHOLD_SIZE, 
#endif

#if (GL_VERSION_1_4 || GL_VERSION_ES_CM_1_0)
    DistanceAttenuation = gl.Constants.GL_POINT_DISTANCE_ATTENUATION, 
#endif

#if GL_ARB_POINT_PARAMETERS
    SizeMinArb = gl.Constants.GL_POINT_SIZE_MIN_ARB, 
#endif

#if GL_ARB_POINT_PARAMETERS
    SizeMaxArb = gl.Constants.GL_POINT_SIZE_MAX_ARB, 
#endif

#if GL_ARB_POINT_PARAMETERS
    FadeThresholdSizeArb = gl.Constants.GL_POINT_FADE_THRESHOLD_SIZE_ARB, 
#endif

#if GL_ARB_POINT_PARAMETERS
    DistanceAttenuationArb = gl.Constants.GL_POINT_DISTANCE_ATTENUATION_ARB, 
#endif

#if GL_EXT_POINT_PARAMETERS
    SizeMinExt = gl.Constants.GL_POINT_SIZE_MIN_EXT, 
#endif

#if GL_EXT_POINT_PARAMETERS
    SizeMaxExt = gl.Constants.GL_POINT_SIZE_MAX_EXT, 
#endif

#if GL_EXT_POINT_PARAMETERS
    FadeThresholdSizeExt = gl.Constants.GL_POINT_FADE_THRESHOLD_SIZE_EXT, 
#endif

#if GL_EXT_POINT_PARAMETERS
    DistanceAttenuationExt = gl.Constants.GL_DISTANCE_ATTENUATION_EXT, 
#endif

#if GL_SGIS_POINT_PARAMETERS
    SizeMinSgis = gl.Constants.GL_POINT_SIZE_MIN_SGIS, 
#endif

#if GL_SGIS_POINT_PARAMETERS
    SizeMaxSgis = gl.Constants.GL_POINT_SIZE_MAX_SGIS, 
#endif

#if GL_SGIS_POINT_PARAMETERS
    FadeThresholdSizeSgis = gl.Constants.GL_POINT_FADE_THRESHOLD_SIZE_SGIS, 
#endif

#if GL_SGIS_POINT_PARAMETERS
    DistanceAttenuationSgis = gl.Constants.GL_DISTANCE_ATTENUATION_SGIS, 
#endif

}

#endif
