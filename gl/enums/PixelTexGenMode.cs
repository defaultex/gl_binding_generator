#if (GL_ES_VERSION_2_0 || GL_KHR_CONTEXT_FLUSH_CONTROL || GL_NV_REGISTER_COMBINERS || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_4_5 || GL_VERSION_4_6 || GL_VERSION_ES_CM_1_0)

public enum PixelTexGenMode : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_KHR_CONTEXT_FLUSH_CONTROL || GL_NV_REGISTER_COMBINERS || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_4_5 || GL_VERSION_4_6)
    None = gl.Constants.GL_NONE, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Rgb = gl.Constants.GL_RGB, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Rgba = gl.Constants.GL_RGBA, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Luminance = gl.Constants.GL_LUMINANCE, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    LuminanceAlpha = gl.Constants.GL_LUMINANCE_ALPHA, 
#endif

}

#endif
