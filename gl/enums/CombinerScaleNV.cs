#if (GL_ES_VERSION_2_0 || GL_KHR_CONTEXT_FLUSH_CONTROL || GL_NV_REGISTER_COMBINERS || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_4_5 || GL_VERSION_4_6)

public enum CombinerScaleNV : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_KHR_CONTEXT_FLUSH_CONTROL || GL_NV_REGISTER_COMBINERS || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_4_5 || GL_VERSION_4_6)
    None = gl.Constants.GL_NONE, 
#endif

#if GL_NV_REGISTER_COMBINERS
    ScaleByTwoNv = gl.Constants.GL_SCALE_BY_TWO_NV, 
#endif

#if GL_NV_REGISTER_COMBINERS
    ScaleByFourNv = gl.Constants.GL_SCALE_BY_FOUR_NV, 
#endif

#if GL_NV_REGISTER_COMBINERS
    ScaleByOneHalfNv = gl.Constants.GL_SCALE_BY_ONE_HALF_NV, 
#endif

}

#endif
