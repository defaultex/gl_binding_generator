#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_SGIX_FRAGMENT_LIGHTING)

public enum LightName : GLenum { 
#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Light0 = gl.Constants.GL_LIGHT0, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Light1 = gl.Constants.GL_LIGHT1, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Light2 = gl.Constants.GL_LIGHT2, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Light3 = gl.Constants.GL_LIGHT3, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Light4 = gl.Constants.GL_LIGHT4, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Light5 = gl.Constants.GL_LIGHT5, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Light6 = gl.Constants.GL_LIGHT6, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Light7 = gl.Constants.GL_LIGHT7, 
#endif

#if GL_SGIX_FRAGMENT_LIGHTING
    FragmentLight0Sgix = gl.Constants.GL_FRAGMENT_LIGHT0_SGIX, 
#endif

#if GL_SGIX_FRAGMENT_LIGHTING
    FragmentLight1Sgix = gl.Constants.GL_FRAGMENT_LIGHT1_SGIX, 
#endif

#if GL_SGIX_FRAGMENT_LIGHTING
    FragmentLight2Sgix = gl.Constants.GL_FRAGMENT_LIGHT2_SGIX, 
#endif

#if GL_SGIX_FRAGMENT_LIGHTING
    FragmentLight3Sgix = gl.Constants.GL_FRAGMENT_LIGHT3_SGIX, 
#endif

#if GL_SGIX_FRAGMENT_LIGHTING
    FragmentLight4Sgix = gl.Constants.GL_FRAGMENT_LIGHT4_SGIX, 
#endif

#if GL_SGIX_FRAGMENT_LIGHTING
    FragmentLight5Sgix = gl.Constants.GL_FRAGMENT_LIGHT5_SGIX, 
#endif

#if GL_SGIX_FRAGMENT_LIGHTING
    FragmentLight6Sgix = gl.Constants.GL_FRAGMENT_LIGHT6_SGIX, 
#endif

#if GL_SGIX_FRAGMENT_LIGHTING
    FragmentLight7Sgix = gl.Constants.GL_FRAGMENT_LIGHT7_SGIX, 
#endif

}

#endif
