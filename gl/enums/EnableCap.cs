#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_EXT_DRAW_BUFFERS_INDEXED || GL_OES_DRAW_BUFFERS_INDEXED || GL_ARB_VIEWPORT_ARRAY || GL_NV_VIEWPORT_ARRAY || GL_OES_VIEWPORT_ARRAY || GL_ARB_INTERNALFORMAT_QUERY2 || GL_EXT_SPARSE_TEXTURE || GL_VERSION_1_1 || GL_VERSION_1_3 || GL_ES_VERSION_3_0 || GL_VERSION_3_0 || GL_ARB_ES3_COMPATIBILITY || GL_VERSION_4_3 || GL_ARB_TEXTURE_MULTISAMPLE || GL_ES_VERSION_3_1 || GL_VERSION_3_2 || GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_4_0 || GL_NV_REGISTER_COMBINERS || GL_ARB_FRAMEBUFFER_SRGB || GL_VERSION_3_1 || GL_ARB_DEPTH_CLAMP || GL_AMD_SEAMLESS_CUBEMAP_PER_TEXTURE || GL_ARB_SEAMLESS_CUBE_MAP || GL_ARB_SEAMLESS_CUBEMAP_PER_TEXTURE || GL_ARB_IMAGING || GL_ARB_TEXTURE_CUBE_MAP || GL_ARB_TEXTURE_RECTANGLE || GL_ARM_SHADER_FRAMEBUFFER_FETCH || GL_EXT_CONVOLUTION || GL_EXT_HISTOGRAM || GL_EXT_RESCALE_NORMAL || GL_EXT_SHARED_TEXTURE_PALETTE || GL_EXT_TEXTURE_CUBE_MAP || GL_EXT_TEXTURE3D || GL_NV_PRIMITIVE_SHADING_RATE || GL_NV_TEXTURE_RECTANGLE || GL_OES_TEXTURE_CUBE_MAP || GL_QCOM_SHADING_RATE || GL_SGI_COLOR_TABLE || GL_SGI_TEXTURE_COLOR_TABLE || GL_SGIS_MULTISAMPLE || GL_SGIS_PIXEL_TEXTURE || GL_SGIS_TEXTURE4D || GL_SGIX_ASYNC_HISTOGRAM || GL_SGIX_ASYNC_PIXEL || GL_SGIX_CALLIGRAPHIC_FRAGMENT || GL_SGIX_FOG_OFFSET || GL_SGIX_FRAGMENT_LIGHTING || GL_SGIX_FRAMEZOOM || GL_SGIX_INTERLACE || GL_SGIX_IR_INSTRUMENT1 || GL_SGIX_PIXEL_TEXTURE || GL_SGIX_REFERENCE_PLANE || GL_SGIX_SPRITE)

public enum EnableCap : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    CullFace = gl.Constants.GL_CULL_FACE, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    DepthTest = gl.Constants.GL_DEPTH_TEST, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    StencilTest = gl.Constants.GL_STENCIL_TEST, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Dither = gl.Constants.GL_DITHER, 
#endif

#if (GL_ES_VERSION_2_0 || GL_EXT_DRAW_BUFFERS_INDEXED || GL_OES_DRAW_BUFFERS_INDEXED || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Blend = gl.Constants.GL_BLEND, 
#endif

#if (GL_ARB_VIEWPORT_ARRAY || GL_ES_VERSION_2_0 || GL_NV_VIEWPORT_ARRAY || GL_OES_VIEWPORT_ARRAY || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    ScissorTest = gl.Constants.GL_SCISSOR_TEST, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_ES_VERSION_2_0 || GL_EXT_SPARSE_TEXTURE || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Texture2D = gl.Constants.GL_TEXTURE_2D, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_1 || GL_VERSION_ES_CM_1_0)
    PolygonOffsetFill = gl.Constants.GL_POLYGON_OFFSET_FILL, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_3 || GL_VERSION_ES_CM_1_0)
    SampleAlphaToCoverage = gl.Constants.GL_SAMPLE_ALPHA_TO_COVERAGE, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_3 || GL_VERSION_ES_CM_1_0)
    SampleCoverage = gl.Constants.GL_SAMPLE_COVERAGE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_ES_VERSION_2_0 || GL_EXT_SPARSE_TEXTURE || GL_VERSION_1_3)
    TextureCubeMap = gl.Constants.GL_TEXTURE_CUBE_MAP, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    RasterizerDiscard = gl.Constants.GL_RASTERIZER_DISCARD, 
#endif

#if (GL_ARB_ES3_COMPATIBILITY || GL_ES_VERSION_3_0 || GL_VERSION_4_3)
    PrimitiveRestartFixedIndex = gl.Constants.GL_PRIMITIVE_RESTART_FIXED_INDEX, 
#endif

#if (GL_ARB_TEXTURE_MULTISAMPLE || GL_ES_VERSION_3_1 || GL_VERSION_3_2)
    SampleMask = gl.Constants.GL_SAMPLE_MASK, 
#endif

#if (GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_1_1 || GL_VERSION_4_3 || GL_VERSION_ES_CM_1_0)
    VertexArray = gl.Constants.GL_VERTEX_ARRAY, 
#endif

#if (GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_4_3)
    DebugOutputSynchronous = gl.Constants.GL_DEBUG_OUTPUT_SYNCHRONOUS, 
#endif

#if (GL_ES_VERSION_3_2 || GL_VERSION_4_0)
    SampleShading = gl.Constants.GL_SAMPLE_SHADING, 
#endif

#if (GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_4_3)
    DebugOutput = gl.Constants.GL_DEBUG_OUTPUT, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    PointSmooth = gl.Constants.GL_POINT_SMOOTH, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    LineSmooth = gl.Constants.GL_LINE_SMOOTH, 
#endif

#if GL_VERSION_1_0
    LineStipple = gl.Constants.GL_LINE_STIPPLE, 
#endif

#if GL_VERSION_1_0
    PolygonSmooth = gl.Constants.GL_POLYGON_SMOOTH, 
#endif

#if GL_VERSION_1_0
    PolygonStipple = gl.Constants.GL_POLYGON_STIPPLE, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Lighting = gl.Constants.GL_LIGHTING, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    ColorMaterial = gl.Constants.GL_COLOR_MATERIAL, 
#endif

#if (GL_NV_REGISTER_COMBINERS || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Fog = gl.Constants.GL_FOG, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Normalize = gl.Constants.GL_NORMALIZE, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    AlphaTest = gl.Constants.GL_ALPHA_TEST, 
#endif

#if GL_VERSION_1_0
    TextureGenS = gl.Constants.GL_TEXTURE_GEN_S, 
#endif

#if GL_VERSION_1_0
    TextureGenT = gl.Constants.GL_TEXTURE_GEN_T, 
#endif

#if GL_VERSION_1_0
    TextureGenR = gl.Constants.GL_TEXTURE_GEN_R, 
#endif

#if GL_VERSION_1_0
    TextureGenQ = gl.Constants.GL_TEXTURE_GEN_Q, 
#endif

#if GL_VERSION_1_0
    AutoNormal = gl.Constants.GL_AUTO_NORMAL, 
#endif

#if GL_VERSION_1_0
    Map1Color4 = gl.Constants.GL_MAP1_COLOR_4, 
#endif

#if GL_VERSION_1_0
    Map1Index = gl.Constants.GL_MAP1_INDEX, 
#endif

#if GL_VERSION_1_0
    Map1Normal = gl.Constants.GL_MAP1_NORMAL, 
#endif

#if GL_VERSION_1_0
    Map1TextureCoord1 = gl.Constants.GL_MAP1_TEXTURE_COORD_1, 
#endif

#if GL_VERSION_1_0
    Map1TextureCoord2 = gl.Constants.GL_MAP1_TEXTURE_COORD_2, 
#endif

#if GL_VERSION_1_0
    Map1TextureCoord3 = gl.Constants.GL_MAP1_TEXTURE_COORD_3, 
#endif

#if GL_VERSION_1_0
    Map1TextureCoord4 = gl.Constants.GL_MAP1_TEXTURE_COORD_4, 
#endif

#if GL_VERSION_1_0
    Map1Vertex3 = gl.Constants.GL_MAP1_VERTEX_3, 
#endif

#if GL_VERSION_1_0
    Map1Vertex4 = gl.Constants.GL_MAP1_VERTEX_4, 
#endif

#if GL_VERSION_1_0
    Map2Color4 = gl.Constants.GL_MAP2_COLOR_4, 
#endif

#if GL_VERSION_1_0
    Map2Index = gl.Constants.GL_MAP2_INDEX, 
#endif

#if GL_VERSION_1_0
    Map2Normal = gl.Constants.GL_MAP2_NORMAL, 
#endif

#if GL_VERSION_1_0
    Map2TextureCoord1 = gl.Constants.GL_MAP2_TEXTURE_COORD_1, 
#endif

#if GL_VERSION_1_0
    Map2TextureCoord2 = gl.Constants.GL_MAP2_TEXTURE_COORD_2, 
#endif

#if GL_VERSION_1_0
    Map2TextureCoord3 = gl.Constants.GL_MAP2_TEXTURE_COORD_3, 
#endif

#if GL_VERSION_1_0
    Map2TextureCoord4 = gl.Constants.GL_MAP2_TEXTURE_COORD_4, 
#endif

#if GL_VERSION_1_0
    Map2Vertex3 = gl.Constants.GL_MAP2_VERTEX_3, 
#endif

#if GL_VERSION_1_0
    Map2Vertex4 = gl.Constants.GL_MAP2_VERTEX_4, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_1_0)
    Texture1D = gl.Constants.GL_TEXTURE_1D, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    ClipPlane0 = gl.Constants.GL_CLIP_PLANE0, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    ClipPlane1 = gl.Constants.GL_CLIP_PLANE1, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    ClipPlane2 = gl.Constants.GL_CLIP_PLANE2, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    ClipPlane3 = gl.Constants.GL_CLIP_PLANE3, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    ClipPlane4 = gl.Constants.GL_CLIP_PLANE4, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    ClipPlane5 = gl.Constants.GL_CLIP_PLANE5, 
#endif

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

#if GL_VERSION_1_1
    IndexLogicOp = gl.Constants.GL_INDEX_LOGIC_OP, 
#endif

#if (GL_VERSION_1_1 || GL_VERSION_ES_CM_1_0)
    ColorLogicOp = gl.Constants.GL_COLOR_LOGIC_OP, 
#endif

#if GL_VERSION_1_1
    PolygonOffsetPoint = gl.Constants.GL_POLYGON_OFFSET_POINT, 
#endif

#if GL_VERSION_1_1
    PolygonOffsetLine = gl.Constants.GL_POLYGON_OFFSET_LINE, 
#endif

#if (GL_VERSION_1_1 || GL_VERSION_ES_CM_1_0)
    NormalArray = gl.Constants.GL_NORMAL_ARRAY, 
#endif

#if (GL_VERSION_1_1 || GL_VERSION_ES_CM_1_0)
    ColorArray = gl.Constants.GL_COLOR_ARRAY, 
#endif

#if GL_VERSION_1_1
    IndexArray = gl.Constants.GL_INDEX_ARRAY, 
#endif

#if (GL_VERSION_1_1 || GL_VERSION_ES_CM_1_0)
    TextureCoordArray = gl.Constants.GL_TEXTURE_COORD_ARRAY, 
#endif

#if GL_VERSION_1_1
    EdgeFlagArray = gl.Constants.GL_EDGE_FLAG_ARRAY, 
#endif

#if (GL_VERSION_1_3 || GL_VERSION_ES_CM_1_0)
    Multisample = gl.Constants.GL_MULTISAMPLE, 
#endif

#if (GL_VERSION_1_3 || GL_VERSION_ES_CM_1_0)
    SampleAlphaToOne = gl.Constants.GL_SAMPLE_ALPHA_TO_ONE, 
#endif

#if GL_VERSION_3_0
    ClipDistance0 = gl.Constants.GL_CLIP_DISTANCE0, 
#endif

#if GL_VERSION_3_0
    ClipDistance1 = gl.Constants.GL_CLIP_DISTANCE1, 
#endif

#if GL_VERSION_3_0
    ClipDistance2 = gl.Constants.GL_CLIP_DISTANCE2, 
#endif

#if GL_VERSION_3_0
    ClipDistance3 = gl.Constants.GL_CLIP_DISTANCE3, 
#endif

#if GL_VERSION_3_0
    ClipDistance4 = gl.Constants.GL_CLIP_DISTANCE4, 
#endif

#if GL_VERSION_3_0
    ClipDistance5 = gl.Constants.GL_CLIP_DISTANCE5, 
#endif

#if GL_VERSION_3_0
    ClipDistance6 = gl.Constants.GL_CLIP_DISTANCE6, 
#endif

#if GL_VERSION_3_0
    ClipDistance7 = gl.Constants.GL_CLIP_DISTANCE7, 
#endif

#if (GL_ARB_FRAMEBUFFER_SRGB || GL_VERSION_3_0)
    FramebufferSrgb = gl.Constants.GL_FRAMEBUFFER_SRGB, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_3_1)
    TextureRectangle = gl.Constants.GL_TEXTURE_RECTANGLE, 
#endif

#if GL_VERSION_3_1
    PrimitiveRestart = gl.Constants.GL_PRIMITIVE_RESTART, 
#endif

#if GL_VERSION_3_2
    ProgramPointSize = gl.Constants.GL_PROGRAM_POINT_SIZE, 
#endif

#if (GL_ARB_DEPTH_CLAMP || GL_VERSION_3_2)
    DepthClamp = gl.Constants.GL_DEPTH_CLAMP, 
#endif

#if (GL_AMD_SEAMLESS_CUBEMAP_PER_TEXTURE || GL_ARB_SEAMLESS_CUBE_MAP || GL_ARB_SEAMLESS_CUBEMAP_PER_TEXTURE || GL_VERSION_3_2)
    TextureCubeMapSeamless = gl.Constants.GL_TEXTURE_CUBE_MAP_SEAMLESS, 
#endif

#if GL_ARB_IMAGING
    ColorTable = gl.Constants.GL_COLOR_TABLE, 
#endif

#if GL_ARB_IMAGING
    PostConvolutionColorTable = gl.Constants.GL_POST_CONVOLUTION_COLOR_TABLE, 
#endif

#if GL_ARB_IMAGING
    PostColorMatrixColorTable = gl.Constants.GL_POST_COLOR_MATRIX_COLOR_TABLE, 
#endif

#if GL_ARB_TEXTURE_CUBE_MAP
    TextureCubeMapArb = gl.Constants.GL_TEXTURE_CUBE_MAP_ARB, 
#endif

#if GL_ARB_TEXTURE_RECTANGLE
    TextureRectangleArb = gl.Constants.GL_TEXTURE_RECTANGLE_ARB, 
#endif

#if GL_ARM_SHADER_FRAMEBUFFER_FETCH
    FetchPerSampleArm = gl.Constants.GL_FETCH_PER_SAMPLE_ARM, 
#endif

#if GL_EXT_CONVOLUTION
    Convolution1DExt = gl.Constants.GL_CONVOLUTION_1D_EXT, 
#endif

#if GL_EXT_CONVOLUTION
    Convolution2DExt = gl.Constants.GL_CONVOLUTION_2D_EXT, 
#endif

#if GL_EXT_CONVOLUTION
    Separable2DExt = gl.Constants.GL_SEPARABLE_2D_EXT, 
#endif

#if GL_EXT_HISTOGRAM
    HistogramExt = gl.Constants.GL_HISTOGRAM_EXT, 
#endif

#if GL_EXT_HISTOGRAM
    MinmaxExt = gl.Constants.GL_MINMAX_EXT, 
#endif

#if GL_EXT_RESCALE_NORMAL
    RescaleNormalExt = gl.Constants.GL_RESCALE_NORMAL_EXT, 
#endif

#if GL_EXT_SHARED_TEXTURE_PALETTE
    SharedTexturePaletteExt = gl.Constants.GL_SHARED_TEXTURE_PALETTE_EXT, 
#endif

#if GL_EXT_TEXTURE_CUBE_MAP
    TextureCubeMapExt = gl.Constants.GL_TEXTURE_CUBE_MAP_EXT, 
#endif

#if GL_EXT_TEXTURE3D
    Texture3DExt = gl.Constants.GL_TEXTURE_3D_EXT, 
#endif

#if GL_NV_PRIMITIVE_SHADING_RATE
    ShadingRateImagePerPrimitiveNv = gl.Constants.GL_SHADING_RATE_IMAGE_PER_PRIMITIVE_NV, 
#endif

#if GL_NV_TEXTURE_RECTANGLE
    TextureRectangleNv = gl.Constants.GL_TEXTURE_RECTANGLE_NV, 
#endif

#if GL_OES_TEXTURE_CUBE_MAP
    TextureCubeMapOes = gl.Constants.GL_TEXTURE_CUBE_MAP_OES, 
#endif

#if GL_QCOM_SHADING_RATE
    ShadingRatePreserveAspectRatioQcom = gl.Constants.GL_SHADING_RATE_PRESERVE_ASPECT_RATIO_QCOM, 
#endif

#if GL_SGI_COLOR_TABLE
    ColorTableSgi = gl.Constants.GL_COLOR_TABLE_SGI, 
#endif

#if GL_SGI_COLOR_TABLE
    PostConvolutionColorTableSgi = gl.Constants.GL_POST_CONVOLUTION_COLOR_TABLE_SGI, 
#endif

#if GL_SGI_COLOR_TABLE
    PostColorMatrixColorTableSgi = gl.Constants.GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI, 
#endif

#if GL_SGI_TEXTURE_COLOR_TABLE
    TextureColorTableSgi = gl.Constants.GL_TEXTURE_COLOR_TABLE_SGI, 
#endif

#if GL_SGIS_MULTISAMPLE
    MultisampleSgis = gl.Constants.GL_MULTISAMPLE_SGIS, 
#endif

#if GL_SGIS_MULTISAMPLE
    SampleAlphaToMaskSgis = gl.Constants.GL_SAMPLE_ALPHA_TO_MASK_SGIS, 
#endif

#if GL_SGIS_MULTISAMPLE
    SampleAlphaToOneSgis = gl.Constants.GL_SAMPLE_ALPHA_TO_ONE_SGIS, 
#endif

#if GL_SGIS_MULTISAMPLE
    SampleMaskSgis = gl.Constants.GL_SAMPLE_MASK_SGIS, 
#endif

#if GL_SGIS_PIXEL_TEXTURE
    PixelTextureSgis = gl.Constants.GL_PIXEL_TEXTURE_SGIS, 
#endif

#if GL_SGIS_TEXTURE4D
    Texture4dSgis = gl.Constants.GL_TEXTURE_4D_SGIS, 
#endif

#if GL_SGIX_ASYNC_HISTOGRAM
    AsyncHistogramSgix = gl.Constants.GL_ASYNC_HISTOGRAM_SGIX, 
#endif

#if GL_SGIX_ASYNC_PIXEL
    AsyncTexImageSgix = gl.Constants.GL_ASYNC_TEX_IMAGE_SGIX, 
#endif

#if GL_SGIX_ASYNC_PIXEL
    AsyncDrawPixelsSgix = gl.Constants.GL_ASYNC_DRAW_PIXELS_SGIX, 
#endif

#if GL_SGIX_ASYNC_PIXEL
    AsyncReadPixelsSgix = gl.Constants.GL_ASYNC_READ_PIXELS_SGIX, 
#endif

#if GL_SGIX_CALLIGRAPHIC_FRAGMENT
    CalligraphicFragmentSgix = gl.Constants.GL_CALLIGRAPHIC_FRAGMENT_SGIX, 
#endif

#if GL_SGIX_FOG_OFFSET
    FogOffsetSgix = gl.Constants.GL_FOG_OFFSET_SGIX, 
#endif

#if GL_SGIX_FRAGMENT_LIGHTING
    FragmentLightingSgix = gl.Constants.GL_FRAGMENT_LIGHTING_SGIX, 
#endif

#if GL_SGIX_FRAGMENT_LIGHTING
    FragmentColorMaterialSgix = gl.Constants.GL_FRAGMENT_COLOR_MATERIAL_SGIX, 
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

#if GL_SGIX_FRAMEZOOM
    FramezoomSgix = gl.Constants.GL_FRAMEZOOM_SGIX, 
#endif

#if GL_SGIX_INTERLACE
    InterlaceSgix = gl.Constants.GL_INTERLACE_SGIX, 
#endif

#if GL_SGIX_IR_INSTRUMENT1
    IrInstrument1Sgix = gl.Constants.GL_IR_INSTRUMENT1_SGIX, 
#endif

#if GL_SGIX_PIXEL_TEXTURE
    PixelTexGenSgix = gl.Constants.GL_PIXEL_TEX_GEN_SGIX, 
#endif

#if GL_SGIX_REFERENCE_PLANE
    ReferencePlaneSgix = gl.Constants.GL_REFERENCE_PLANE_SGIX, 
#endif

#if GL_SGIX_SPRITE
    SpriteSgix = gl.Constants.GL_SPRITE_SGIX, 
#endif

}

#endif
