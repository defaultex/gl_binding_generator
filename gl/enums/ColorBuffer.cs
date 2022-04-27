#if (GL_ES_VERSION_2_0 || GL_KHR_CONTEXT_FLUSH_CONTROL || GL_NV_REGISTER_COMBINERS || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_4_5 || GL_VERSION_4_6 || GL_VERSION_ES_CM_1_0 || GL_ARB_ES3_1_COMPATIBILITY || GL_ARB_FRAMEBUFFER_OBJECT || GL_VERSION_3_0 || GL_ES_VERSION_3_0)

public enum ColorBuffer : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_KHR_CONTEXT_FLUSH_CONTROL || GL_NV_REGISTER_COMBINERS || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_4_5 || GL_VERSION_4_6)
    None = gl.Constants.GL_NONE, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Front = gl.Constants.GL_FRONT, 
#endif

#if (GL_ARB_ES3_1_COMPATIBILITY || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_4_5 || GL_VERSION_ES_CM_1_0)
    Back = gl.Constants.GL_BACK, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    FrontAndBack = gl.Constants.GL_FRONT_AND_BACK, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_3_0)
    Attachment0 = gl.Constants.GL_COLOR_ATTACHMENT0, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Attachment1 = gl.Constants.GL_COLOR_ATTACHMENT1, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Attachment2 = gl.Constants.GL_COLOR_ATTACHMENT2, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Attachment3 = gl.Constants.GL_COLOR_ATTACHMENT3, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Attachment4 = gl.Constants.GL_COLOR_ATTACHMENT4, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Attachment5 = gl.Constants.GL_COLOR_ATTACHMENT5, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Attachment6 = gl.Constants.GL_COLOR_ATTACHMENT6, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Attachment7 = gl.Constants.GL_COLOR_ATTACHMENT7, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Attachment8 = gl.Constants.GL_COLOR_ATTACHMENT8, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Attachment9 = gl.Constants.GL_COLOR_ATTACHMENT9, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Attachment10 = gl.Constants.GL_COLOR_ATTACHMENT10, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Attachment11 = gl.Constants.GL_COLOR_ATTACHMENT11, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Attachment12 = gl.Constants.GL_COLOR_ATTACHMENT12, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Attachment13 = gl.Constants.GL_COLOR_ATTACHMENT13, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Attachment14 = gl.Constants.GL_COLOR_ATTACHMENT14, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Attachment15 = gl.Constants.GL_COLOR_ATTACHMENT15, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Attachment16 = gl.Constants.GL_COLOR_ATTACHMENT16, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Attachment17 = gl.Constants.GL_COLOR_ATTACHMENT17, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Attachment18 = gl.Constants.GL_COLOR_ATTACHMENT18, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Attachment19 = gl.Constants.GL_COLOR_ATTACHMENT19, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Attachment20 = gl.Constants.GL_COLOR_ATTACHMENT20, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Attachment21 = gl.Constants.GL_COLOR_ATTACHMENT21, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Attachment22 = gl.Constants.GL_COLOR_ATTACHMENT22, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Attachment23 = gl.Constants.GL_COLOR_ATTACHMENT23, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Attachment24 = gl.Constants.GL_COLOR_ATTACHMENT24, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Attachment25 = gl.Constants.GL_COLOR_ATTACHMENT25, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Attachment26 = gl.Constants.GL_COLOR_ATTACHMENT26, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Attachment27 = gl.Constants.GL_COLOR_ATTACHMENT27, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Attachment28 = gl.Constants.GL_COLOR_ATTACHMENT28, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Attachment29 = gl.Constants.GL_COLOR_ATTACHMENT29, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Attachment30 = gl.Constants.GL_COLOR_ATTACHMENT30, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Attachment31 = gl.Constants.GL_COLOR_ATTACHMENT31, 
#endif

#if GL_VERSION_1_0
    FrontLeft = gl.Constants.GL_FRONT_LEFT, 
#endif

#if GL_VERSION_1_0
    FrontRight = gl.Constants.GL_FRONT_RIGHT, 
#endif

#if GL_VERSION_1_0
    BackLeft = gl.Constants.GL_BACK_LEFT, 
#endif

#if GL_VERSION_1_0
    BackRight = gl.Constants.GL_BACK_RIGHT, 
#endif

#if GL_VERSION_1_0
    Left = gl.Constants.GL_LEFT, 
#endif

#if GL_VERSION_1_0
    Right = gl.Constants.GL_RIGHT, 
#endif

}

#endif
