#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_VERSION_1_3 || GL_3DFX_MULTISAMPLE || GL_ARB_MULTISAMPLE || GL_EXT_MULTISAMPLE)
[Flags]
public enum AttribMask : GLbitfield { 
    None = 0,
#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    DepthBuffer = gl.Constants.GL_DEPTH_BUFFER_BIT, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    StencilBuffer = gl.Constants.GL_STENCIL_BUFFER_BIT, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    ColorBuffer = gl.Constants.GL_COLOR_BUFFER_BIT, 
#endif

#if GL_VERSION_1_0
    Current = gl.Constants.GL_CURRENT_BIT, 
#endif

#if GL_VERSION_1_0
    Point = gl.Constants.GL_POINT_BIT, 
#endif

#if GL_VERSION_1_0
    Line = gl.Constants.GL_LINE_BIT, 
#endif

#if GL_VERSION_1_0
    Polygon = gl.Constants.GL_POLYGON_BIT, 
#endif

#if GL_VERSION_1_0
    PolygonStipple = gl.Constants.GL_POLYGON_STIPPLE_BIT, 
#endif

#if GL_VERSION_1_0
    PixelMode = gl.Constants.GL_PIXEL_MODE_BIT, 
#endif

#if GL_VERSION_1_0
    Lighting = gl.Constants.GL_LIGHTING_BIT, 
#endif

#if GL_VERSION_1_0
    Fog = gl.Constants.GL_FOG_BIT, 
#endif

#if GL_VERSION_1_0
    AccumBuffer = gl.Constants.GL_ACCUM_BUFFER_BIT, 
#endif

#if GL_VERSION_1_0
    Viewport = gl.Constants.GL_VIEWPORT_BIT, 
#endif

#if GL_VERSION_1_0
    Transform = gl.Constants.GL_TRANSFORM_BIT, 
#endif

#if GL_VERSION_1_0
    Enable = gl.Constants.GL_ENABLE_BIT, 
#endif

#if GL_VERSION_1_0
    Hint = gl.Constants.GL_HINT_BIT, 
#endif

#if GL_VERSION_1_0
    Eval = gl.Constants.GL_EVAL_BIT, 
#endif

#if GL_VERSION_1_0
    List = gl.Constants.GL_LIST_BIT, 
#endif

#if GL_VERSION_1_0
    Texture = gl.Constants.GL_TEXTURE_BIT, 
#endif

#if GL_VERSION_1_0
    Scissor = gl.Constants.GL_SCISSOR_BIT, 
#endif

#if GL_VERSION_1_0
    AllAttrib = gl.Constants.GL_ALL_ATTRIB_BITS, 
#endif

#if GL_VERSION_1_3
    Multisample = gl.Constants.GL_MULTISAMPLE_BIT, 
#endif

#if GL_3DFX_MULTISAMPLE
    MultisampleBit3dfx = gl.Constants.GL_MULTISAMPLE_BIT_3DFX, 
#endif

#if GL_ARB_MULTISAMPLE
    MultisampleBitArb = gl.Constants.GL_MULTISAMPLE_BIT_ARB, 
#endif

#if GL_EXT_MULTISAMPLE
    MultisampleBitExt = gl.Constants.GL_MULTISAMPLE_BIT_EXT, 
#endif

}

#endif
