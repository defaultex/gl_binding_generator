public enum MultisampleParameter : GLenum {
    SamplePosition = gl.Constants.GL_SAMPLE_POSITION,
#if GL_ARB_sample_locations
    SampleLocationArb = gl.Constants.GL_SAMPLE_LOCATION_ARB,
#endif

#if GL_ARB_sample_locations
    ProgrammableSampleLocationArb = gl.Constants.GL_PROGRAMMABLE_SAMPLE_LOCATION_ARB,
#endif
}
