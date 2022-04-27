#if GL_EXT_MULTISAMPLE

public enum SamplePatternEXT : GLenum { 
#if GL_EXT_MULTISAMPLE
    _1passExt = gl.Constants.GL_1PASS_EXT, 
#endif

#if GL_EXT_MULTISAMPLE
    _2pass0Ext = gl.Constants.GL_2PASS_0_EXT, 
#endif

#if GL_EXT_MULTISAMPLE
    _2pass1Ext = gl.Constants.GL_2PASS_1_EXT, 
#endif

#if GL_EXT_MULTISAMPLE
    _4pass0Ext = gl.Constants.GL_4PASS_0_EXT, 
#endif

#if GL_EXT_MULTISAMPLE
    _4pass1Ext = gl.Constants.GL_4PASS_1_EXT, 
#endif

#if GL_EXT_MULTISAMPLE
    _4pass2Ext = gl.Constants.GL_4PASS_2_EXT, 
#endif

#if GL_EXT_MULTISAMPLE
    _4pass3Ext = gl.Constants.GL_4PASS_3_EXT, 
#endif

}

#endif
