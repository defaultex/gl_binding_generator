#if (GL_ARB_MULTITEXTURE || GL_NV_REGISTER_COMBINERS || GL_NV_PATH_RENDERING)

public enum CombinerRegisterNV : GLenum { 
#if (GL_ARB_MULTITEXTURE || GL_NV_REGISTER_COMBINERS)
    Texture0Arb = gl.Constants.GL_TEXTURE0_ARB, 
#endif

#if (GL_ARB_MULTITEXTURE || GL_NV_REGISTER_COMBINERS)
    Texture1Arb = gl.Constants.GL_TEXTURE1_ARB, 
#endif

#if (GL_NV_PATH_RENDERING || GL_NV_REGISTER_COMBINERS)
    PrimaryColorNv = gl.Constants.GL_PRIMARY_COLOR_NV, 
#endif

#if (GL_NV_PATH_RENDERING || GL_NV_REGISTER_COMBINERS)
    SecondaryColorNv = gl.Constants.GL_SECONDARY_COLOR_NV, 
#endif

#if GL_NV_REGISTER_COMBINERS
    Spare0Nv = gl.Constants.GL_SPARE0_NV, 
#endif

#if GL_NV_REGISTER_COMBINERS
    Spare1Nv = gl.Constants.GL_SPARE1_NV, 
#endif

#if GL_NV_REGISTER_COMBINERS
    DiscardNv = gl.Constants.GL_DISCARD_NV, 
#endif

}

#endif
