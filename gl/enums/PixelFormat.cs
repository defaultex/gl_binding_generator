#if (GL_ANGLE_DEPTH_TEXTURE || GL_ES_VERSION_2_0 || GL_OES_DEPTH_TEXTURE || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_OES_ELEMENT_INDEX_UINT || GL_AMD_INTERLEAVED_ELEMENTS || GL_ES_VERSION_3_0 || GL_ARB_TEXTURE_RG || GL_VERSION_3_0 || GL_ARB_FRAMEBUFFER_OBJECT || GL_ARB_TEXTURE_STENCIL8 || GL_ES_VERSION_3_1 || GL_ES_VERSION_3_2 || GL_VERSION_4_4 || GL_VERSION_1_2 || GL_ARB_VERTEX_ARRAY_BGRA || GL_EXT_VERTEX_ARRAY_BGRA || GL_EXT_ABGR || GL_EXT_CMYKA || GL_EXT_TEXTURE_RG || GL_SGIX_YCRCB)

public enum PixelFormat : GLenum { 
#if (GL_ANGLE_DEPTH_TEXTURE || GL_ES_VERSION_2_0 || GL_OES_DEPTH_TEXTURE || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    UnsignedShort = gl.Constants.GL_UNSIGNED_SHORT, 
#endif

#if (GL_ANGLE_DEPTH_TEXTURE || GL_ES_VERSION_2_0 || GL_OES_DEPTH_TEXTURE || GL_OES_ELEMENT_INDEX_UINT || GL_SC_VERSION_2_0 || GL_VERSION_1_0)
    UnsignedInt = gl.Constants.GL_UNSIGNED_INT, 
#endif

#if (GL_ANGLE_DEPTH_TEXTURE || GL_ES_VERSION_2_0 || GL_OES_DEPTH_TEXTURE || GL_VERSION_1_0)
    DepthComponent = gl.Constants.GL_DEPTH_COMPONENT, 
#endif

#if (GL_AMD_INTERLEAVED_ELEMENTS || GL_ES_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Alpha = gl.Constants.GL_ALPHA, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Rgb = gl.Constants.GL_RGB, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Rgba = gl.Constants.GL_RGBA, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Luminance = gl.Constants.GL_LUMINANCE, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    LuminanceAlpha = gl.Constants.GL_LUMINANCE_ALPHA, 
#endif

#if (GL_AMD_INTERLEAVED_ELEMENTS || GL_ES_VERSION_3_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0)
    Red = gl.Constants.GL_RED, 
#endif

#if (GL_AMD_INTERLEAVED_ELEMENTS || GL_ES_VERSION_3_0 || GL_VERSION_1_0)
    Green = gl.Constants.GL_GREEN, 
#endif

#if (GL_AMD_INTERLEAVED_ELEMENTS || GL_ES_VERSION_3_0 || GL_VERSION_1_0)
    Blue = gl.Constants.GL_BLUE, 
#endif

#if (GL_ARB_TEXTURE_RG || GL_ES_VERSION_3_0 || GL_SC_VERSION_2_0 || GL_VERSION_3_0)
    Rg = gl.Constants.GL_RG, 
#endif

#if (GL_ARB_TEXTURE_RG || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    RgInteger = gl.Constants.GL_RG_INTEGER, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    DepthStencil = gl.Constants.GL_DEPTH_STENCIL, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    RedInteger = gl.Constants.GL_RED_INTEGER, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    RgbInteger = gl.Constants.GL_RGB_INTEGER, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    RgbaInteger = gl.Constants.GL_RGBA_INTEGER, 
#endif

#if (GL_ARB_TEXTURE_STENCIL8 || GL_ES_VERSION_3_1 || GL_ES_VERSION_3_2 || GL_VERSION_1_0 || GL_VERSION_4_4)
    StencilIndex = gl.Constants.GL_STENCIL_INDEX, 
#endif

#if GL_VERSION_1_0
    ColorIndex = gl.Constants.GL_COLOR_INDEX, 
#endif

#if GL_VERSION_1_2
    Bgr = gl.Constants.GL_BGR, 
#endif

#if (GL_ARB_VERTEX_ARRAY_BGRA || GL_EXT_VERTEX_ARRAY_BGRA || GL_VERSION_1_2)
    Bgra = gl.Constants.GL_BGRA, 
#endif

#if GL_VERSION_3_0
    GreenInteger = gl.Constants.GL_GREEN_INTEGER, 
#endif

#if GL_VERSION_3_0
    BlueInteger = gl.Constants.GL_BLUE_INTEGER, 
#endif

#if GL_VERSION_3_0
    BgrInteger = gl.Constants.GL_BGR_INTEGER, 
#endif

#if GL_VERSION_3_0
    BgraInteger = gl.Constants.GL_BGRA_INTEGER, 
#endif

#if GL_EXT_ABGR
    AbgrExt = gl.Constants.GL_ABGR_EXT, 
#endif

#if GL_EXT_CMYKA
    CmykExt = gl.Constants.GL_CMYK_EXT, 
#endif

#if GL_EXT_CMYKA
    CmykaExt = gl.Constants.GL_CMYKA_EXT, 
#endif

#if GL_EXT_TEXTURE_RG
    RedExt = gl.Constants.GL_RED_EXT, 
#endif

#if GL_SGIX_YCRCB
    Ycrcb422Sgix = gl.Constants.GL_YCRCB_422_SGIX, 
#endif

#if GL_SGIX_YCRCB
    Ycrcb444Sgix = gl.Constants.GL_YCRCB_444_SGIX, 
#endif

}

#endif
