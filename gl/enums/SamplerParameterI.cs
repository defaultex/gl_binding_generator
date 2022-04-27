#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_ES_VERSION_3_0 || GL_VERSION_1_2 || GL_VERSION_1_4 || GL_ARM_TEXTURE_UNNORMALIZED_COORDINATES)

public enum SamplerParameterI : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    TextureMagFilter = gl.Constants.GL_TEXTURE_MAG_FILTER, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    TextureMinFilter = gl.Constants.GL_TEXTURE_MIN_FILTER, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    TextureWrapS = gl.Constants.GL_TEXTURE_WRAP_S, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    TextureWrapT = gl.Constants.GL_TEXTURE_WRAP_T, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_2)
    TextureWrapR = gl.Constants.GL_TEXTURE_WRAP_R, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_4)
    TextureCompareMode = gl.Constants.GL_TEXTURE_COMPARE_MODE, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_4)
    TextureCompareFunc = gl.Constants.GL_TEXTURE_COMPARE_FUNC, 
#endif

#if GL_ARM_TEXTURE_UNNORMALIZED_COORDINATES
    TextureUnnormalizedCoordinatesArm = gl.Constants.GL_TEXTURE_UNNORMALIZED_COORDINATES_ARM, 
#endif

}

#endif
