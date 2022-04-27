#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0 || GL_VERSION_4_2)

public enum TransformFeedbackPName : GLenum { 
#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    BufferStart = gl.Constants.GL_TRANSFORM_FEEDBACK_BUFFER_START, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    BufferSize = gl.Constants.GL_TRANSFORM_FEEDBACK_BUFFER_SIZE, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    BufferBinding = gl.Constants.GL_TRANSFORM_FEEDBACK_BUFFER_BINDING, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_4_2)
    Paused = gl.Constants.GL_TRANSFORM_FEEDBACK_PAUSED, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_4_2)
    Active = gl.Constants.GL_TRANSFORM_FEEDBACK_ACTIVE, 
#endif

}

#endif
