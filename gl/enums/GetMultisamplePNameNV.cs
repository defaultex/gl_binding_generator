#if (GL_ARB_TEXTURE_MULTISAMPLE || GL_ES_VERSION_3_1 || GL_VERSION_3_2 || GL_ARB_SAMPLE_LOCATIONS)

public enum GetMultisamplePNameNV : GLenum { 
#if (GL_ARB_TEXTURE_MULTISAMPLE || GL_ES_VERSION_3_1 || GL_VERSION_3_2)
    SamplePosition = gl.Constants.GL_SAMPLE_POSITION, 
#endif

#if GL_ARB_SAMPLE_LOCATIONS
    SampleLocationArb = gl.Constants.GL_SAMPLE_LOCATION_ARB, 
#endif

#if GL_ARB_SAMPLE_LOCATIONS
    ProgrammableSampleLocationArb = gl.Constants.GL_PROGRAMMABLE_SAMPLE_LOCATION_ARB, 
#endif

}

#endif
