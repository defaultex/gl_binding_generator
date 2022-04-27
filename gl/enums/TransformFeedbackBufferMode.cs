#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)

public enum TransformFeedbackBufferMode : GLenum { 
#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    InterleavedAttribs = gl.Constants.GL_INTERLEAVED_ATTRIBS, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    SeparateAttribs = gl.Constants.GL_SEPARATE_ATTRIBS, 
#endif

}

#endif
