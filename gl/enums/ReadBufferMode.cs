#if (GL_ES_VERSION_2_0 || GL_KHR_CONTEXT_FLUSH_CONTROL || GL_NV_REGISTER_COMBINERS || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_4_5 || GL_VERSION_4_6 || GL_VERSION_ES_CM_1_0 || GL_ARB_ES3_1_COMPATIBILITY || GL_ARB_FRAMEBUFFER_OBJECT || GL_VERSION_3_0 || GL_ES_VERSION_3_0 || GL_OES_FRAMEBUFFER_OBJECT)

public enum ReadBufferMode : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_KHR_CONTEXT_FLUSH_CONTROL || GL_NV_REGISTER_COMBINERS || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_4_5 || GL_VERSION_4_6)
    None = gl.Constants.GL_NONE, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Front = gl.Constants.GL_FRONT, 
#endif

#if (GL_ARB_ES3_1_COMPATIBILITY || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_4_5 || GL_VERSION_ES_CM_1_0)
    Back = gl.Constants.GL_BACK, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_3_0)
    ColorAttachment0 = gl.Constants.GL_COLOR_ATTACHMENT0, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment1 = gl.Constants.GL_COLOR_ATTACHMENT1, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment2 = gl.Constants.GL_COLOR_ATTACHMENT2, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment3 = gl.Constants.GL_COLOR_ATTACHMENT3, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment4 = gl.Constants.GL_COLOR_ATTACHMENT4, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment5 = gl.Constants.GL_COLOR_ATTACHMENT5, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment6 = gl.Constants.GL_COLOR_ATTACHMENT6, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment7 = gl.Constants.GL_COLOR_ATTACHMENT7, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment8 = gl.Constants.GL_COLOR_ATTACHMENT8, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment9 = gl.Constants.GL_COLOR_ATTACHMENT9, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment10 = gl.Constants.GL_COLOR_ATTACHMENT10, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment11 = gl.Constants.GL_COLOR_ATTACHMENT11, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment12 = gl.Constants.GL_COLOR_ATTACHMENT12, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment13 = gl.Constants.GL_COLOR_ATTACHMENT13, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment14 = gl.Constants.GL_COLOR_ATTACHMENT14, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ColorAttachment15 = gl.Constants.GL_COLOR_ATTACHMENT15, 
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

#if GL_VERSION_1_0
    Aux0 = gl.Constants.GL_AUX0, 
#endif

#if GL_VERSION_1_0
    Aux1 = gl.Constants.GL_AUX1, 
#endif

#if GL_VERSION_1_0
    Aux2 = gl.Constants.GL_AUX2, 
#endif

#if GL_VERSION_1_0
    Aux3 = gl.Constants.GL_AUX3, 
#endif

#if GL_OES_FRAMEBUFFER_OBJECT
    NoneOes = gl.Constants.GL_NONE_OES, 
#endif

}

#endif
