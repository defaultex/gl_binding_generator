#if (GL_ARB_CLIP_CONTROL || GL_VERSION_4_5)

public enum ClipControlDepth : GLenum { 
#if (GL_ARB_CLIP_CONTROL || GL_VERSION_4_5)
    NegativeOneToOne = gl.Constants.GL_NEGATIVE_ONE_TO_ONE, 
#endif

#if (GL_ARB_CLIP_CONTROL || GL_VERSION_4_5)
    ZeroToOne = gl.Constants.GL_ZERO_TO_ONE, 
#endif

}

#endif
