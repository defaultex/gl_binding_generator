#if (GL_ES_VERSION_3_0 || GL_VERSION_1_2 || GL_ES_VERSION_3_2 || GL_VERSION_1_0 || GL_VERSION_1_4 || GL_ARB_TEXTURE_FILTER_ANISOTROPIC || GL_VERSION_4_6 || GL_ARM_TEXTURE_UNNORMALIZED_COORDINATES)

public enum SamplerParameterF : GLenum { 
#if (GL_ES_VERSION_3_0 || GL_VERSION_1_2)
    TextureMinLod = gl.Constants.GL_TEXTURE_MIN_LOD, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_2)
    TextureMaxLod = gl.Constants.GL_TEXTURE_MAX_LOD, 
#endif

#if (GL_ES_VERSION_3_2 || GL_VERSION_1_0)
    TextureBorderColor = gl.Constants.GL_TEXTURE_BORDER_COLOR, 
#endif

#if GL_VERSION_1_4
    TextureLodBias = gl.Constants.GL_TEXTURE_LOD_BIAS, 
#endif

#if (GL_ARB_TEXTURE_FILTER_ANISOTROPIC || GL_VERSION_4_6)
    TextureMaxAnisotropy = gl.Constants.GL_TEXTURE_MAX_ANISOTROPY, 
#endif

#if GL_ARM_TEXTURE_UNNORMALIZED_COORDINATES
    TextureUnnormalizedCoordinatesArm = gl.Constants.GL_TEXTURE_UNNORMALIZED_COORDINATES_ARM, 
#endif

}

#endif
