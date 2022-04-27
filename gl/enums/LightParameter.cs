#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)

public enum LightParameter : GLenum { 
#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Position = gl.Constants.GL_POSITION, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    SpotDirection = gl.Constants.GL_SPOT_DIRECTION, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    SpotExponent = gl.Constants.GL_SPOT_EXPONENT, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    SpotCutoff = gl.Constants.GL_SPOT_CUTOFF, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    ConstantAttenuation = gl.Constants.GL_CONSTANT_ATTENUATION, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    LinearAttenuation = gl.Constants.GL_LINEAR_ATTENUATION, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    QuadraticAttenuation = gl.Constants.GL_QUADRATIC_ATTENUATION, 
#endif

}

#endif
