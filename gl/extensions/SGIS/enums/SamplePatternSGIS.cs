#if (GL_EXT_MULTISAMPLE || GL_SGIS_MULTISAMPLE)

public enum SamplePatternSGIS : GLenum { 
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

#if GL_SGIS_MULTISAMPLE
    _1passSgis = gl.Constants.GL_1PASS_SGIS, 
#endif

#if GL_SGIS_MULTISAMPLE
    _2pass0Sgis = gl.Constants.GL_2PASS_0_SGIS, 
#endif

#if GL_SGIS_MULTISAMPLE
    _2pass1Sgis = gl.Constants.GL_2PASS_1_SGIS, 
#endif

#if GL_SGIS_MULTISAMPLE
    _4pass0Sgis = gl.Constants.GL_4PASS_0_SGIS, 
#endif

#if GL_SGIS_MULTISAMPLE
    _4pass1Sgis = gl.Constants.GL_4PASS_1_SGIS, 
#endif

#if GL_SGIS_MULTISAMPLE
    _4pass2Sgis = gl.Constants.GL_4PASS_2_SGIS, 
#endif

#if GL_SGIS_MULTISAMPLE
    _4pass3Sgis = gl.Constants.GL_4PASS_3_SGIS, 
#endif

}

#endif
