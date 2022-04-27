#if (GL_VERSION_1_4 || GL_VERSION_ES_CM_1_0 || GL_EXT_POINT_PARAMETERS)

public enum PointParameterNameARB : GLenum { 
#if (GL_VERSION_1_4 || GL_VERSION_ES_CM_1_0)
    FadeThresholdSize = gl.Constants.GL_POINT_FADE_THRESHOLD_SIZE, 
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

}

#endif
