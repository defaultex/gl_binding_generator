#if (GL_AMD_INTERLEAVED_ELEMENTS || GL_ES_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_SC_VERSION_2_0)

public enum CombinerPortionNV : GLenum { 
#if (GL_AMD_INTERLEAVED_ELEMENTS || GL_ES_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Alpha = gl.Constants.GL_ALPHA, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Rgb = gl.Constants.GL_RGB, 
#endif

}

#endif
