#if (GL_ARB_CLIP_CONTROL || GL_VERSION_2_0 || GL_VERSION_4_5)

public enum ClipControlOrigin : GLenum { 
#if (GL_ARB_CLIP_CONTROL || GL_VERSION_2_0 || GL_VERSION_4_5)
    LowerLeft = gl.Constants.GL_LOWER_LEFT, 
#endif

#if (GL_ARB_CLIP_CONTROL || GL_VERSION_2_0 || GL_VERSION_4_5)
    UpperLeft = gl.Constants.GL_UPPER_LEFT, 
#endif

}

#endif
