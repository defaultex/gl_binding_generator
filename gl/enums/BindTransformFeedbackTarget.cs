#if (GL_ARB_TRANSFORM_FEEDBACK2 || GL_ES_VERSION_3_0 || GL_EXT_DEBUG_LABEL || GL_VERSION_4_0)

public enum BindTransformFeedbackTarget : GLenum { 
#if (GL_ARB_TRANSFORM_FEEDBACK2 || GL_ES_VERSION_3_0 || GL_EXT_DEBUG_LABEL || GL_VERSION_4_0)
    TransformFeedback = gl.Constants.GL_TRANSFORM_FEEDBACK, 
#endif

}

#endif
