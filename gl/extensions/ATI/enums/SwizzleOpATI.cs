#if GL_ATI_FRAGMENT_SHADER

public enum SwizzleOpATI : GLenum { 
#if GL_ATI_FRAGMENT_SHADER
    StrAti = gl.Constants.GL_SWIZZLE_STR_ATI, 
#endif

#if GL_ATI_FRAGMENT_SHADER
    StqAti = gl.Constants.GL_SWIZZLE_STQ_ATI, 
#endif

#if GL_ATI_FRAGMENT_SHADER
    StrDrAti = gl.Constants.GL_SWIZZLE_STR_DR_ATI, 
#endif

#if GL_ATI_FRAGMENT_SHADER
    StqDqAti = gl.Constants.GL_SWIZZLE_STQ_DQ_ATI, 
#endif

}

#endif
