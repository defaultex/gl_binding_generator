#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_ARB_VIEWPORT_ARRAY || GL_NV_VIEWPORT_ARRAY || GL_OES_VIEWPORT_ARRAY || GL_EXT_DRAW_BUFFERS_INDEXED || GL_OES_DRAW_BUFFERS_INDEXED || GL_ARB_INTERNALFORMAT_QUERY2 || GL_EXT_SPARSE_TEXTURE || GL_VERSION_1_1 || GL_ARB_IMAGING || GL_VERSION_1_4 || GL_VERSION_2_0 || GL_ARB_DIRECT_STATE_ACCESS || GL_VERSION_4_5 || GL_VERSION_1_3 || GL_VERSION_1_2 || GL_ARB_FRAMEBUFFER_OBJECT || GL_VERSION_3_0 || GL_VERSION_1_5 || GL_ARB_ES2_COMPATIBILITY || GL_VERSION_4_1 || GL_ES_VERSION_3_0 || GL_ARB_VERTEX_ARRAY_OBJECT || GL_ARB_GET_PROGRAM_BINARY || GL_VERSION_2_1 || GL_ARB_SAMPLER_OBJECTS || GL_VERSION_3_3 || GL_ARB_UNIFORM_BUFFER_OBJECT || GL_VERSION_3_1 || GL_ARB_GEOMETRY_SHADER4 || GL_ARB_ES3_COMPATIBILITY || GL_VERSION_4_3 || GL_ARB_SYNC || GL_VERSION_3_2 || GL_ARB_SEPARATE_SHADER_OBJECTS || GL_ES_VERSION_3_1 || GL_ARB_COMPUTE_SHADER || GL_ARB_EXPLICIT_UNIFORM_LOCATION || GL_ARB_VERTEX_ATTRIB_BINDING || GL_ARB_TEXTURE_MULTISAMPLE || GL_ARB_SHADER_STORAGE_BUFFER_OBJECT || GL_ARB_SHADER_ATOMIC_COUNTERS || GL_VERSION_4_2 || GL_ARB_FRAMEBUFFER_NO_ATTACHMENTS || GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_ARB_TESSELLATION_SHADER || GL_VERSION_4_0 || GL_ARB_TEXTURE_BUFFER_RANGE || GL_NV_REGISTER_COMBINERS || GL_ARB_PROVOKING_VERTEX || GL_ARB_BLEND_FUNC_EXTENDED || GL_ARB_TIMER_QUERY || GL_ARB_MAP_BUFFER_ALIGNMENT || GL_ARB_TEXTURE_CUBE_MAP || GL_ARB_TEXTURE_RECTANGLE || GL_ARM_SHADER_FRAMEBUFFER_FETCH || GL_EXT_BLEND_COLOR || GL_EXT_BLEND_MINMAX || GL_EXT_CMYKA || GL_EXT_CONVOLUTION || GL_EXT_DRAW_BUFFERS || GL_EXT_FRAMEBUFFER_OBJECT || GL_EXT_HISTOGRAM || GL_EXT_MEMORY_OBJECT || GL_EXT_SEMAPHORE || GL_EXT_MEMORY_OBJECT_WIN32 || GL_EXT_SEMAPHORE_WIN32 || GL_EXT_MULTIVIEW_DRAW_BUFFERS || GL_EXT_POLYGON_OFFSET || GL_EXT_RESCALE_NORMAL || GL_EXT_SHARED_TEXTURE_PALETTE || GL_EXT_TEXTURE_CUBE_MAP || GL_EXT_TEXTURE_OBJECT || GL_EXT_TEXTURE3D || GL_EXT_VERTEX_ARRAY || GL_EXT_VERTEX_WEIGHTING || GL_NV_FBO_COLOR_ATTACHMENTS || GL_NV_PRIMITIVE_SHADING_RATE || GL_NV_READ_BUFFER || GL_NV_TEXTURE_RECTANGLE || GL_NV_TIMELINE_SEMAPHORE || GL_OES_TEXTURE_CUBE_MAP || GL_QCOM_ALPHA_TEST || GL_QCOM_MOTION_ESTIMATION || GL_QCOM_SHADING_RATE || GL_SGI_COLOR_MATRIX || GL_SGI_COLOR_TABLE || GL_SGI_TEXTURE_COLOR_TABLE || GL_SGIS_DETAIL_TEXTURE || GL_SGIS_FOG_FUNCTION || GL_SGIS_GENERATE_MIPMAP || GL_SGIS_MULTISAMPLE || GL_SGIS_PIXEL_TEXTURE || GL_SGIS_POINT_PARAMETERS || GL_SGIS_TEXTURE4D || GL_SGIX_ASYNC || GL_SGIX_ASYNC_HISTOGRAM || GL_SGIX_ASYNC_PIXEL || GL_SGIX_CALLIGRAPHIC_FRAGMENT || GL_SGIX_CLIPMAP || GL_SGIX_CONVOLUTION_ACCURACY || GL_SGIX_FOG_OFFSET || GL_SGIX_FRAGMENT_LIGHTING || GL_SGIX_FRAMEZOOM || GL_SGIX_INSTRUMENTS || GL_SGIX_INTERLACE || GL_SGIX_IR_INSTRUMENT1 || GL_SGIX_PIXEL_TEXTURE || GL_SGIX_PIXEL_TILES || GL_SGIX_POLYNOMIAL_FFD || GL_SGIX_REFERENCE_PLANE || GL_SGIX_RESAMPLE || GL_SGIX_SPRITE || GL_SGIX_SUBSAMPLE || GL_SGIX_TEXTURE_SCALE_BIAS || GL_SGIX_VERTEX_PRECLIP)

public enum GetPName : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    LineWidth = gl.Constants.GL_LINE_WIDTH, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    CullFace = gl.Constants.GL_CULL_FACE, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    CullFaceMode = gl.Constants.GL_CULL_FACE_MODE, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    FrontFace = gl.Constants.GL_FRONT_FACE, 
#endif

#if (GL_ARB_VIEWPORT_ARRAY || GL_ES_VERSION_2_0 || GL_NV_VIEWPORT_ARRAY || GL_OES_VIEWPORT_ARRAY || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    DepthRange = gl.Constants.GL_DEPTH_RANGE, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    DepthTest = gl.Constants.GL_DEPTH_TEST, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    DepthWritemask = gl.Constants.GL_DEPTH_WRITEMASK, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    DepthClearValue = gl.Constants.GL_DEPTH_CLEAR_VALUE, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    DepthFunc = gl.Constants.GL_DEPTH_FUNC, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    StencilTest = gl.Constants.GL_STENCIL_TEST, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    StencilClearValue = gl.Constants.GL_STENCIL_CLEAR_VALUE, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    StencilFunc = gl.Constants.GL_STENCIL_FUNC, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    StencilValueMask = gl.Constants.GL_STENCIL_VALUE_MASK, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    StencilFail = gl.Constants.GL_STENCIL_FAIL, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    StencilPassDepthFail = gl.Constants.GL_STENCIL_PASS_DEPTH_FAIL, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    StencilPassDepthPass = gl.Constants.GL_STENCIL_PASS_DEPTH_PASS, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    StencilRef = gl.Constants.GL_STENCIL_REF, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    StencilWritemask = gl.Constants.GL_STENCIL_WRITEMASK, 
#endif

#if (GL_ARB_VIEWPORT_ARRAY || GL_ES_VERSION_2_0 || GL_NV_VIEWPORT_ARRAY || GL_OES_VIEWPORT_ARRAY || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Viewport = gl.Constants.GL_VIEWPORT, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Dither = gl.Constants.GL_DITHER, 
#endif

#if (GL_ES_VERSION_2_0 || GL_EXT_DRAW_BUFFERS_INDEXED || GL_OES_DRAW_BUFFERS_INDEXED || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Blend = gl.Constants.GL_BLEND, 
#endif

#if (GL_ARB_VIEWPORT_ARRAY || GL_ES_VERSION_2_0 || GL_NV_VIEWPORT_ARRAY || GL_OES_VIEWPORT_ARRAY || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    ScissorBox = gl.Constants.GL_SCISSOR_BOX, 
#endif

#if (GL_ARB_VIEWPORT_ARRAY || GL_ES_VERSION_2_0 || GL_NV_VIEWPORT_ARRAY || GL_OES_VIEWPORT_ARRAY || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    ScissorTest = gl.Constants.GL_SCISSOR_TEST, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    ColorClearValue = gl.Constants.GL_COLOR_CLEAR_VALUE, 
#endif

#if (GL_ES_VERSION_2_0 || GL_EXT_DRAW_BUFFERS_INDEXED || GL_OES_DRAW_BUFFERS_INDEXED || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    ColorWritemask = gl.Constants.GL_COLOR_WRITEMASK, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    UnpackAlignment = gl.Constants.GL_UNPACK_ALIGNMENT, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    PackAlignment = gl.Constants.GL_PACK_ALIGNMENT, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    MaxTextureSize = gl.Constants.GL_MAX_TEXTURE_SIZE, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    MaxViewportDims = gl.Constants.GL_MAX_VIEWPORT_DIMS, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Subpixel = gl.Constants.GL_SUBPIXEL_BITS, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Red = gl.Constants.GL_RED_BITS, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Green = gl.Constants.GL_GREEN_BITS, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Blue = gl.Constants.GL_BLUE_BITS, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Alpha = gl.Constants.GL_ALPHA_BITS, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Depth = gl.Constants.GL_DEPTH_BITS, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Stencil = gl.Constants.GL_STENCIL_BITS, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_ES_VERSION_2_0 || GL_EXT_SPARSE_TEXTURE || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Texture2D = gl.Constants.GL_TEXTURE_2D, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_1 || GL_VERSION_ES_CM_1_0)
    PolygonOffsetUnits = gl.Constants.GL_POLYGON_OFFSET_UNITS, 
#endif

#if (GL_ARB_IMAGING || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_4)
    BlendColor = gl.Constants.GL_BLEND_COLOR, 
#endif

#if (GL_ES_VERSION_2_0 || GL_EXT_DRAW_BUFFERS_INDEXED || GL_OES_DRAW_BUFFERS_INDEXED || GL_SC_VERSION_2_0 || GL_VERSION_2_0)
    BlendEquationRgb = gl.Constants.GL_BLEND_EQUATION_RGB, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_1 || GL_VERSION_ES_CM_1_0)
    PolygonOffsetFill = gl.Constants.GL_POLYGON_OFFSET_FILL, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_1 || GL_VERSION_ES_CM_1_0)
    PolygonOffsetFactor = gl.Constants.GL_POLYGON_OFFSET_FACTOR, 
#endif

#if (GL_ARB_DIRECT_STATE_ACCESS || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_1 || GL_VERSION_4_5 || GL_VERSION_ES_CM_1_0)
    TextureBinding2D = gl.Constants.GL_TEXTURE_BINDING_2D, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_3 || GL_VERSION_ES_CM_1_0)
    SampleBuffers = gl.Constants.GL_SAMPLE_BUFFERS, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_3 || GL_VERSION_ES_CM_1_0)
    Samples = gl.Constants.GL_SAMPLES, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_3 || GL_VERSION_ES_CM_1_0)
    SampleCoverageValue = gl.Constants.GL_SAMPLE_COVERAGE_VALUE, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_3 || GL_VERSION_ES_CM_1_0)
    SampleCoverageInvert = gl.Constants.GL_SAMPLE_COVERAGE_INVERT, 
#endif

#if (GL_ES_VERSION_2_0 || GL_EXT_DRAW_BUFFERS_INDEXED || GL_OES_DRAW_BUFFERS_INDEXED || GL_SC_VERSION_2_0 || GL_VERSION_1_4)
    BlendDstRgb = gl.Constants.GL_BLEND_DST_RGB, 
#endif

#if (GL_ES_VERSION_2_0 || GL_EXT_DRAW_BUFFERS_INDEXED || GL_OES_DRAW_BUFFERS_INDEXED || GL_SC_VERSION_2_0 || GL_VERSION_1_4)
    BlendSrcRgb = gl.Constants.GL_BLEND_SRC_RGB, 
#endif

#if (GL_ES_VERSION_2_0 || GL_EXT_DRAW_BUFFERS_INDEXED || GL_OES_DRAW_BUFFERS_INDEXED || GL_SC_VERSION_2_0 || GL_VERSION_1_4)
    BlendDstAlpha = gl.Constants.GL_BLEND_DST_ALPHA, 
#endif

#if (GL_ES_VERSION_2_0 || GL_EXT_DRAW_BUFFERS_INDEXED || GL_OES_DRAW_BUFFERS_INDEXED || GL_SC_VERSION_2_0 || GL_VERSION_1_4)
    BlendSrcAlpha = gl.Constants.GL_BLEND_SRC_ALPHA, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_2 || GL_VERSION_ES_CM_1_0)
    AliasedPointSizeRange = gl.Constants.GL_ALIASED_POINT_SIZE_RANGE, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_2 || GL_VERSION_ES_CM_1_0)
    AliasedLineWidthRange = gl.Constants.GL_ALIASED_LINE_WIDTH_RANGE, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_3 || GL_VERSION_ES_CM_1_0)
    ActiveTexture = gl.Constants.GL_ACTIVE_TEXTURE, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_3_0)
    MaxRenderbufferSize = gl.Constants.GL_MAX_RENDERBUFFER_SIZE, 
#endif

#if (GL_ARB_DIRECT_STATE_ACCESS || GL_ES_VERSION_2_0 || GL_VERSION_1_3 || GL_VERSION_4_5)
    TextureBindingCubeMap = gl.Constants.GL_TEXTURE_BINDING_CUBE_MAP, 
#endif

#if (GL_ES_VERSION_2_0 || GL_VERSION_1_3)
    MaxCubeMapTextureSize = gl.Constants.GL_MAX_CUBE_MAP_TEXTURE_SIZE, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_3 || GL_VERSION_ES_CM_1_0)
    NumCompressedTextureFormats = gl.Constants.GL_NUM_COMPRESSED_TEXTURE_FORMATS, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_3 || GL_VERSION_ES_CM_1_0)
    CompressedTextureFormats = gl.Constants.GL_COMPRESSED_TEXTURE_FORMATS, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_2_0)
    StencilBackFunc = gl.Constants.GL_STENCIL_BACK_FUNC, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_2_0)
    StencilBackFail = gl.Constants.GL_STENCIL_BACK_FAIL, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_2_0)
    StencilBackPassDepthFail = gl.Constants.GL_STENCIL_BACK_PASS_DEPTH_FAIL, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_2_0)
    StencilBackPassDepthPass = gl.Constants.GL_STENCIL_BACK_PASS_DEPTH_PASS, 
#endif

#if (GL_ES_VERSION_2_0 || GL_EXT_DRAW_BUFFERS_INDEXED || GL_OES_DRAW_BUFFERS_INDEXED || GL_SC_VERSION_2_0 || GL_VERSION_2_0)
    BlendEquationAlpha = gl.Constants.GL_BLEND_EQUATION_ALPHA, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_2_0)
    MaxVertexAttribs = gl.Constants.GL_MAX_VERTEX_ATTRIBS, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_2_0)
    MaxTextureImageUnits = gl.Constants.GL_MAX_TEXTURE_IMAGE_UNITS, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_5 || GL_VERSION_ES_CM_1_0)
    ArrayBufferBinding = gl.Constants.GL_ARRAY_BUFFER_BINDING, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_5 || GL_VERSION_ES_CM_1_0)
    ElementArrayBufferBinding = gl.Constants.GL_ELEMENT_ARRAY_BUFFER_BINDING, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_2_0)
    MaxVertexTextureImageUnits = gl.Constants.GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_2_0)
    MaxCombinedTextureImageUnits = gl.Constants.GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_2_0)
    CurrentProgram = gl.Constants.GL_CURRENT_PROGRAM, 
#endif

#if (GL_ARB_ES2_COMPATIBILITY || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_4_1)
    ImplementationColorReadType = gl.Constants.GL_IMPLEMENTATION_COLOR_READ_TYPE, 
#endif

#if (GL_ARB_ES2_COMPATIBILITY || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_4_1)
    ImplementationColorReadFormat = gl.Constants.GL_IMPLEMENTATION_COLOR_READ_FORMAT, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_2_0)
    StencilBackRef = gl.Constants.GL_STENCIL_BACK_REF, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_2_0)
    StencilBackValueMask = gl.Constants.GL_STENCIL_BACK_VALUE_MASK, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_2_0)
    StencilBackWritemask = gl.Constants.GL_STENCIL_BACK_WRITEMASK, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_3_0)
    RenderbufferBinding = gl.Constants.GL_RENDERBUFFER_BINDING, 
#endif

#if (GL_ARB_ES2_COMPATIBILITY || GL_ES_VERSION_2_0 || GL_VERSION_4_1)
    ShaderBinaryFormats = gl.Constants.GL_SHADER_BINARY_FORMATS, 
#endif

#if (GL_ARB_ES2_COMPATIBILITY || GL_ES_VERSION_2_0 || GL_VERSION_4_1)
    NumShaderBinaryFormats = gl.Constants.GL_NUM_SHADER_BINARY_FORMATS, 
#endif

#if (GL_ARB_ES2_COMPATIBILITY || GL_ES_VERSION_2_0 || GL_VERSION_4_1)
    ShaderCompiler = gl.Constants.GL_SHADER_COMPILER, 
#endif

#if (GL_ARB_ES2_COMPATIBILITY || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_4_1)
    MaxVertexUniformVectors = gl.Constants.GL_MAX_VERTEX_UNIFORM_VECTORS, 
#endif

#if (GL_ARB_ES2_COMPATIBILITY || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_4_1)
    MaxVaryingVectors = gl.Constants.GL_MAX_VARYING_VECTORS, 
#endif

#if (GL_ARB_ES2_COMPATIBILITY || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_4_1)
    MaxFragmentUniformVectors = gl.Constants.GL_MAX_FRAGMENT_UNIFORM_VECTORS, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_0)
    ReadBuffer = gl.Constants.GL_READ_BUFFER, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_0)
    UnpackRowLength = gl.Constants.GL_UNPACK_ROW_LENGTH, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_0)
    UnpackSkipRows = gl.Constants.GL_UNPACK_SKIP_ROWS, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_0)
    UnpackSkipPixels = gl.Constants.GL_UNPACK_SKIP_PIXELS, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_0)
    PackRowLength = gl.Constants.GL_PACK_ROW_LENGTH, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_0)
    PackSkipRows = gl.Constants.GL_PACK_SKIP_ROWS, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_0)
    PackSkipPixels = gl.Constants.GL_PACK_SKIP_PIXELS, 
#endif

#if (GL_ARB_DIRECT_STATE_ACCESS || GL_ES_VERSION_3_0 || GL_VERSION_1_2 || GL_VERSION_4_5)
    TextureBinding3D = gl.Constants.GL_TEXTURE_BINDING_3D, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_2)
    UnpackSkipImages = gl.Constants.GL_UNPACK_SKIP_IMAGES, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_2)
    UnpackImageHeight = gl.Constants.GL_UNPACK_IMAGE_HEIGHT, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_2)
    Max3DTextureSize = gl.Constants.GL_MAX_3D_TEXTURE_SIZE, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_2)
    MaxElementsVertices = gl.Constants.GL_MAX_ELEMENTS_VERTICES, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_2)
    MaxElementsIndices = gl.Constants.GL_MAX_ELEMENTS_INDICES, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    MajorVersion = gl.Constants.GL_MAJOR_VERSION, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    MinorVersion = gl.Constants.GL_MINOR_VERSION, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    NumExtensions = gl.Constants.GL_NUM_EXTENSIONS, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_4)
    MaxTextureLodBias = gl.Constants.GL_MAX_TEXTURE_LOD_BIAS, 
#endif

#if (GL_ARB_VERTEX_ARRAY_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    VertexArrayBinding = gl.Constants.GL_VERTEX_ARRAY_BINDING, 
#endif

#if (GL_ARB_GET_PROGRAM_BINARY || GL_ES_VERSION_3_0 || GL_SC_VERSION_2_0 || GL_VERSION_4_1)
    NumProgramBinaryFormats = gl.Constants.GL_NUM_PROGRAM_BINARY_FORMATS, 
#endif

#if (GL_ARB_GET_PROGRAM_BINARY || GL_ES_VERSION_3_0 || GL_SC_VERSION_2_0 || GL_VERSION_4_1)
    ProgramBinaryFormats = gl.Constants.GL_PROGRAM_BINARY_FORMATS, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_2_0)
    MaxDrawBuffers = gl.Constants.GL_MAX_DRAW_BUFFERS, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_2_1)
    PixelPackBufferBinding = gl.Constants.GL_PIXEL_PACK_BUFFER_BINDING, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_2_1)
    PixelUnpackBufferBinding = gl.Constants.GL_PIXEL_UNPACK_BUFFER_BINDING, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    MaxArrayTextureLayers = gl.Constants.GL_MAX_ARRAY_TEXTURE_LAYERS, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    MinProgramTexelOffset = gl.Constants.GL_MIN_PROGRAM_TEXEL_OFFSET, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    MaxProgramTexelOffset = gl.Constants.GL_MAX_PROGRAM_TEXEL_OFFSET, 
#endif

#if (GL_ARB_SAMPLER_OBJECTS || GL_ES_VERSION_3_0 || GL_VERSION_3_3)
    SamplerBinding = gl.Constants.GL_SAMPLER_BINDING, 
#endif

#if (GL_ARB_UNIFORM_BUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_1)
    UniformBufferBinding = gl.Constants.GL_UNIFORM_BUFFER_BINDING, 
#endif

#if (GL_ARB_UNIFORM_BUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_1)
    UniformBufferStart = gl.Constants.GL_UNIFORM_BUFFER_START, 
#endif

#if (GL_ARB_UNIFORM_BUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_1)
    UniformBufferSize = gl.Constants.GL_UNIFORM_BUFFER_SIZE, 
#endif

#if (GL_ARB_UNIFORM_BUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_1)
    MaxVertexUniformBlocks = gl.Constants.GL_MAX_VERTEX_UNIFORM_BLOCKS, 
#endif

#if (GL_ARB_UNIFORM_BUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_1)
    MaxFragmentUniformBlocks = gl.Constants.GL_MAX_FRAGMENT_UNIFORM_BLOCKS, 
#endif

#if (GL_ARB_UNIFORM_BUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_1)
    MaxCombinedUniformBlocks = gl.Constants.GL_MAX_COMBINED_UNIFORM_BLOCKS, 
#endif

#if (GL_ARB_UNIFORM_BUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_1)
    MaxUniformBufferBindings = gl.Constants.GL_MAX_UNIFORM_BUFFER_BINDINGS, 
#endif

#if (GL_ARB_UNIFORM_BUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_1)
    MaxUniformBlockSize = gl.Constants.GL_MAX_UNIFORM_BLOCK_SIZE, 
#endif

#if (GL_ARB_UNIFORM_BUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_1)
    MaxCombinedVertexUniformComponents = gl.Constants.GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS, 
#endif

#if (GL_ARB_UNIFORM_BUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_1)
    MaxCombinedFragmentUniformComponents = gl.Constants.GL_MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS, 
#endif

#if (GL_ARB_UNIFORM_BUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_1)
    UniformBufferOffsetAlignment = gl.Constants.GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_2_0)
    MaxFragmentUniformComponents = gl.Constants.GL_MAX_FRAGMENT_UNIFORM_COMPONENTS, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_2_0)
    MaxVertexUniformComponents = gl.Constants.GL_MAX_VERTEX_UNIFORM_COMPONENTS, 
#endif

#if (GL_ARB_GEOMETRY_SHADER4 || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    MaxVaryingComponents = gl.Constants.GL_MAX_VARYING_COMPONENTS, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_2_0)
    FragmentShaderDerivativeHint = gl.Constants.GL_FRAGMENT_SHADER_DERIVATIVE_HINT, 
#endif

#if (GL_ARB_DIRECT_STATE_ACCESS || GL_ES_VERSION_3_0 || GL_VERSION_3_0 || GL_VERSION_4_5)
    TextureBinding2DArray = gl.Constants.GL_TEXTURE_BINDING_2D_ARRAY, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    TransformFeedbackBufferStart = gl.Constants.GL_TRANSFORM_FEEDBACK_BUFFER_START, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    TransformFeedbackBufferSize = gl.Constants.GL_TRANSFORM_FEEDBACK_BUFFER_SIZE, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    TransformFeedbackBufferBinding = gl.Constants.GL_TRANSFORM_FEEDBACK_BUFFER_BINDING, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    DrawFramebufferBinding = gl.Constants.GL_DRAW_FRAMEBUFFER_BINDING, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    ReadFramebufferBinding = gl.Constants.GL_READ_FRAMEBUFFER_BINDING, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    MaxColorAttachments = gl.Constants.GL_MAX_COLOR_ATTACHMENTS, 
#endif

#if (GL_ARB_ES3_COMPATIBILITY || GL_ES_VERSION_3_0 || GL_VERSION_4_3)
    MaxElementIndex = gl.Constants.GL_MAX_ELEMENT_INDEX, 
#endif

#if (GL_ARB_SYNC || GL_ES_VERSION_3_0 || GL_VERSION_3_2)
    MaxServerWaitTimeout = gl.Constants.GL_MAX_SERVER_WAIT_TIMEOUT, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_2)
    MaxVertexOutputComponents = gl.Constants.GL_MAX_VERTEX_OUTPUT_COMPONENTS, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_2)
    MaxFragmentInputComponents = gl.Constants.GL_MAX_FRAGMENT_INPUT_COMPONENTS, 
#endif

#if (GL_ARB_SEPARATE_SHADER_OBJECTS || GL_ES_VERSION_3_1 || GL_VERSION_4_1)
    ProgramPipelineBinding = gl.Constants.GL_PROGRAM_PIPELINE_BINDING, 
#endif

#if (GL_ARB_COMPUTE_SHADER || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    MaxComputeUniformComponents = gl.Constants.GL_MAX_COMPUTE_UNIFORM_COMPONENTS, 
#endif

#if (GL_ARB_COMPUTE_SHADER || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    MaxComputeAtomicCounterBuffers = gl.Constants.GL_MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS, 
#endif

#if (GL_ARB_COMPUTE_SHADER || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    MaxComputeAtomicCounters = gl.Constants.GL_MAX_COMPUTE_ATOMIC_COUNTERS, 
#endif

#if (GL_ARB_COMPUTE_SHADER || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    MaxCombinedComputeUniformComponents = gl.Constants.GL_MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS, 
#endif

#if (GL_ARB_EXPLICIT_UNIFORM_LOCATION || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    MaxUniformLocations = gl.Constants.GL_MAX_UNIFORM_LOCATIONS, 
#endif

#if (GL_ARB_VERTEX_ATTRIB_BINDING || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    VertexBindingDivisor = gl.Constants.GL_VERTEX_BINDING_DIVISOR, 
#endif

#if (GL_ARB_VERTEX_ATTRIB_BINDING || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    VertexBindingOffset = gl.Constants.GL_VERTEX_BINDING_OFFSET, 
#endif

#if (GL_ARB_VERTEX_ATTRIB_BINDING || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    VertexBindingStride = gl.Constants.GL_VERTEX_BINDING_STRIDE, 
#endif

#if (GL_ARB_VERTEX_ATTRIB_BINDING || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    MaxVertexAttribRelativeOffset = gl.Constants.GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET, 
#endif

#if (GL_ARB_VERTEX_ATTRIB_BINDING || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    MaxVertexAttribBindings = gl.Constants.GL_MAX_VERTEX_ATTRIB_BINDINGS, 
#endif

#if (GL_ARB_TEXTURE_MULTISAMPLE || GL_ES_VERSION_3_1 || GL_VERSION_3_2)
    MaxSampleMaskWords = gl.Constants.GL_MAX_SAMPLE_MASK_WORDS, 
#endif

#if (GL_ARB_SHADER_STORAGE_BUFFER_OBJECT || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    ShaderStorageBufferBinding = gl.Constants.GL_SHADER_STORAGE_BUFFER_BINDING, 
#endif

#if (GL_ARB_SHADER_STORAGE_BUFFER_OBJECT || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    ShaderStorageBufferStart = gl.Constants.GL_SHADER_STORAGE_BUFFER_START, 
#endif

#if (GL_ARB_SHADER_STORAGE_BUFFER_OBJECT || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    ShaderStorageBufferSize = gl.Constants.GL_SHADER_STORAGE_BUFFER_SIZE, 
#endif

#if (GL_ARB_SHADER_STORAGE_BUFFER_OBJECT || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    MaxVertexShaderStorageBlocks = gl.Constants.GL_MAX_VERTEX_SHADER_STORAGE_BLOCKS, 
#endif

#if (GL_ARB_SHADER_STORAGE_BUFFER_OBJECT || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    MaxFragmentShaderStorageBlocks = gl.Constants.GL_MAX_FRAGMENT_SHADER_STORAGE_BLOCKS, 
#endif

#if (GL_ARB_SHADER_STORAGE_BUFFER_OBJECT || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    MaxComputeShaderStorageBlocks = gl.Constants.GL_MAX_COMPUTE_SHADER_STORAGE_BLOCKS, 
#endif

#if (GL_ARB_SHADER_STORAGE_BUFFER_OBJECT || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    MaxCombinedShaderStorageBlocks = gl.Constants.GL_MAX_COMBINED_SHADER_STORAGE_BLOCKS, 
#endif

#if (GL_ARB_SHADER_STORAGE_BUFFER_OBJECT || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    MaxShaderStorageBufferBindings = gl.Constants.GL_MAX_SHADER_STORAGE_BUFFER_BINDINGS, 
#endif

#if (GL_ARB_SHADER_STORAGE_BUFFER_OBJECT || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    ShaderStorageBufferOffsetAlignment = gl.Constants.GL_SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT, 
#endif

#if (GL_ARB_COMPUTE_SHADER || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    MaxComputeWorkGroupInvocations = gl.Constants.GL_MAX_COMPUTE_WORK_GROUP_INVOCATIONS, 
#endif

#if (GL_ARB_COMPUTE_SHADER || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    DispatchIndirectBufferBinding = gl.Constants.GL_DISPATCH_INDIRECT_BUFFER_BINDING, 
#endif

#if (GL_ARB_DIRECT_STATE_ACCESS || GL_ARB_TEXTURE_MULTISAMPLE || GL_ES_VERSION_3_1 || GL_VERSION_3_2 || GL_VERSION_4_5)
    TextureBinding2DMultisample = gl.Constants.GL_TEXTURE_BINDING_2D_MULTISAMPLE, 
#endif

#if (GL_ARB_TEXTURE_MULTISAMPLE || GL_ES_VERSION_3_1 || GL_VERSION_3_2)
    MaxColorTextureSamples = gl.Constants.GL_MAX_COLOR_TEXTURE_SAMPLES, 
#endif

#if (GL_ARB_TEXTURE_MULTISAMPLE || GL_ES_VERSION_3_1 || GL_VERSION_3_2)
    MaxDepthTextureSamples = gl.Constants.GL_MAX_DEPTH_TEXTURE_SAMPLES, 
#endif

#if (GL_ARB_TEXTURE_MULTISAMPLE || GL_ES_VERSION_3_1 || GL_VERSION_3_2)
    MaxIntegerSamples = gl.Constants.GL_MAX_INTEGER_SAMPLES, 
#endif

#if (GL_ARB_COMPUTE_SHADER || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    MaxComputeUniformBlocks = gl.Constants.GL_MAX_COMPUTE_UNIFORM_BLOCKS, 
#endif

#if (GL_ARB_COMPUTE_SHADER || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    MaxComputeTextureImageUnits = gl.Constants.GL_MAX_COMPUTE_TEXTURE_IMAGE_UNITS, 
#endif

#if (GL_ARB_COMPUTE_SHADER || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    MaxComputeWorkGroupCount = gl.Constants.GL_MAX_COMPUTE_WORK_GROUP_COUNT, 
#endif

#if (GL_ARB_COMPUTE_SHADER || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    MaxComputeWorkGroupSize = gl.Constants.GL_MAX_COMPUTE_WORK_GROUP_SIZE, 
#endif

#if (GL_ARB_SHADER_ATOMIC_COUNTERS || GL_ES_VERSION_3_1 || GL_VERSION_4_2)
    MaxVertexAtomicCounters = gl.Constants.GL_MAX_VERTEX_ATOMIC_COUNTERS, 
#endif

#if (GL_ARB_SHADER_ATOMIC_COUNTERS || GL_ES_VERSION_3_1 || GL_VERSION_4_2)
    MaxFragmentAtomicCounters = gl.Constants.GL_MAX_FRAGMENT_ATOMIC_COUNTERS, 
#endif

#if (GL_ARB_SHADER_ATOMIC_COUNTERS || GL_ES_VERSION_3_1 || GL_VERSION_4_2)
    MaxCombinedAtomicCounters = gl.Constants.GL_MAX_COMBINED_ATOMIC_COUNTERS, 
#endif

#if (GL_ARB_FRAMEBUFFER_NO_ATTACHMENTS || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    MaxFramebufferWidth = gl.Constants.GL_MAX_FRAMEBUFFER_WIDTH, 
#endif

#if (GL_ARB_FRAMEBUFFER_NO_ATTACHMENTS || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    MaxFramebufferHeight = gl.Constants.GL_MAX_FRAMEBUFFER_HEIGHT, 
#endif

#if (GL_ARB_FRAMEBUFFER_NO_ATTACHMENTS || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    MaxFramebufferSamples = gl.Constants.GL_MAX_FRAMEBUFFER_SAMPLES, 
#endif

#if (GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_1_1 || GL_VERSION_4_3 || GL_VERSION_ES_CM_1_0)
    VertexArray = gl.Constants.GL_VERTEX_ARRAY, 
#endif

#if (GL_ES_VERSION_3_2 || GL_VERSION_3_0)
    ContextFlags = gl.Constants.GL_CONTEXT_FLAGS, 
#endif

#if (GL_ARB_VIEWPORT_ARRAY || GL_ES_VERSION_3_2 || GL_VERSION_4_1)
    LayerProvokingVertex = gl.Constants.GL_LAYER_PROVOKING_VERTEX, 
#endif

#if (GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_4_3)
    MaxDebugGroupStackDepth = gl.Constants.GL_MAX_DEBUG_GROUP_STACK_DEPTH, 
#endif

#if (GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_4_3)
    DebugGroupStackDepth = gl.Constants.GL_DEBUG_GROUP_STACK_DEPTH, 
#endif

#if (GL_ES_VERSION_3_2 || GL_KHR_DEBUG || GL_VERSION_4_3)
    MaxLabelLength = gl.Constants.GL_MAX_LABEL_LENGTH, 
#endif

#if (GL_ARB_UNIFORM_BUFFER_OBJECT || GL_ES_VERSION_3_2 || GL_VERSION_3_1)
    MaxGeometryUniformBlocks = gl.Constants.GL_MAX_GEOMETRY_UNIFORM_BLOCKS, 
#endif

#if (GL_ARB_UNIFORM_BUFFER_OBJECT || GL_ES_VERSION_3_2 || GL_VERSION_3_1)
    MaxCombinedGeometryUniformComponents = gl.Constants.GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS, 
#endif

#if (GL_ES_VERSION_3_2 || GL_VERSION_3_2)
    MaxGeometryTextureImageUnits = gl.Constants.GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS, 
#endif

#if (GL_ES_VERSION_3_2 || GL_VERSION_3_1)
    MaxTextureBufferSize = gl.Constants.GL_MAX_TEXTURE_BUFFER_SIZE, 
#endif

#if (GL_ARB_DIRECT_STATE_ACCESS || GL_ES_VERSION_3_2 || GL_VERSION_3_1 || GL_VERSION_4_5)
    TextureBindingBuffer = gl.Constants.GL_TEXTURE_BINDING_BUFFER, 
#endif

#if (GL_ES_VERSION_3_2 || GL_VERSION_3_2)
    MaxGeometryUniformComponents = gl.Constants.GL_MAX_GEOMETRY_UNIFORM_COMPONENTS, 
#endif

#if (GL_ARB_TESSELLATION_SHADER || GL_ES_VERSION_3_2 || GL_VERSION_4_0)
    MaxTessControlUniformBlocks = gl.Constants.GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS, 
#endif

#if (GL_ARB_TESSELLATION_SHADER || GL_ES_VERSION_3_2 || GL_VERSION_4_0)
    MaxTessEvaluationUniformBlocks = gl.Constants.GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS, 
#endif

#if (GL_ARB_SHADER_STORAGE_BUFFER_OBJECT || GL_ES_VERSION_3_2 || GL_VERSION_4_3)
    MaxGeometryShaderStorageBlocks = gl.Constants.GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS, 
#endif

#if (GL_ARB_SHADER_STORAGE_BUFFER_OBJECT || GL_ES_VERSION_3_2 || GL_VERSION_4_3)
    MaxTessControlShaderStorageBlocks = gl.Constants.GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS, 
#endif

#if (GL_ARB_SHADER_STORAGE_BUFFER_OBJECT || GL_ES_VERSION_3_2 || GL_VERSION_4_3)
    MaxTessEvaluationShaderStorageBlocks = gl.Constants.GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS, 
#endif

#if (GL_ARB_DIRECT_STATE_ACCESS || GL_ARB_TEXTURE_MULTISAMPLE || GL_ES_VERSION_3_2 || GL_VERSION_3_2 || GL_VERSION_4_5)
    TextureBinding2DMultisampleArray = gl.Constants.GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY, 
#endif

#if (GL_ES_VERSION_3_2 || GL_VERSION_3_2)
    MaxGeometryInputComponents = gl.Constants.GL_MAX_GEOMETRY_INPUT_COMPONENTS, 
#endif

#if (GL_ES_VERSION_3_2 || GL_VERSION_3_2)
    MaxGeometryOutputComponents = gl.Constants.GL_MAX_GEOMETRY_OUTPUT_COMPONENTS, 
#endif

#if (GL_ARB_TEXTURE_BUFFER_RANGE || GL_ES_VERSION_3_2 || GL_VERSION_4_3)
    TextureBufferOffsetAlignment = gl.Constants.GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT, 
#endif

#if (GL_ARB_SHADER_ATOMIC_COUNTERS || GL_ES_VERSION_3_2 || GL_VERSION_4_2)
    MaxTessControlAtomicCounters = gl.Constants.GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS, 
#endif

#if (GL_ARB_SHADER_ATOMIC_COUNTERS || GL_ES_VERSION_3_2 || GL_VERSION_4_2)
    MaxTessEvaluationAtomicCounters = gl.Constants.GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS, 
#endif

#if (GL_ARB_SHADER_ATOMIC_COUNTERS || GL_ES_VERSION_3_2 || GL_VERSION_4_2)
    MaxGeometryAtomicCounters = gl.Constants.GL_MAX_GEOMETRY_ATOMIC_COUNTERS, 
#endif

#if (GL_ARB_FRAMEBUFFER_NO_ATTACHMENTS || GL_ES_VERSION_3_2 || GL_VERSION_4_3)
    MaxFramebufferLayers = gl.Constants.GL_MAX_FRAMEBUFFER_LAYERS, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    CurrentColor = gl.Constants.GL_CURRENT_COLOR, 
#endif

#if GL_VERSION_1_0
    CurrentIndex = gl.Constants.GL_CURRENT_INDEX, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    CurrentNormal = gl.Constants.GL_CURRENT_NORMAL, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    CurrentTextureCoords = gl.Constants.GL_CURRENT_TEXTURE_COORDS, 
#endif

#if GL_VERSION_1_0
    CurrentRasterColor = gl.Constants.GL_CURRENT_RASTER_COLOR, 
#endif

#if GL_VERSION_1_0
    CurrentRasterIndex = gl.Constants.GL_CURRENT_RASTER_INDEX, 
#endif

#if GL_VERSION_1_0
    CurrentRasterTextureCoords = gl.Constants.GL_CURRENT_RASTER_TEXTURE_COORDS, 
#endif

#if GL_VERSION_1_0
    CurrentRasterPosition = gl.Constants.GL_CURRENT_RASTER_POSITION, 
#endif

#if GL_VERSION_1_0
    CurrentRasterPositionValid = gl.Constants.GL_CURRENT_RASTER_POSITION_VALID, 
#endif

#if GL_VERSION_1_0
    CurrentRasterDistance = gl.Constants.GL_CURRENT_RASTER_DISTANCE, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    PointSmooth = gl.Constants.GL_POINT_SMOOTH, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    PointSize = gl.Constants.GL_POINT_SIZE, 
#endif

#if GL_VERSION_1_0
    PointSizeRange = gl.Constants.GL_POINT_SIZE_RANGE, 
#endif

#if GL_VERSION_1_0
    PointSizeGranularity = gl.Constants.GL_POINT_SIZE_GRANULARITY, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    LineSmooth = gl.Constants.GL_LINE_SMOOTH, 
#endif

#if GL_VERSION_1_0
    LineWidthRange = gl.Constants.GL_LINE_WIDTH_RANGE, 
#endif

#if GL_VERSION_1_0
    LineWidthGranularity = gl.Constants.GL_LINE_WIDTH_GRANULARITY, 
#endif

#if GL_VERSION_1_0
    LineStipple = gl.Constants.GL_LINE_STIPPLE, 
#endif

#if GL_VERSION_1_0
    LineStipplePattern = gl.Constants.GL_LINE_STIPPLE_PATTERN, 
#endif

#if GL_VERSION_1_0
    LineStippleRepeat = gl.Constants.GL_LINE_STIPPLE_REPEAT, 
#endif

#if GL_VERSION_1_0
    ListMode = gl.Constants.GL_LIST_MODE, 
#endif

#if GL_VERSION_1_0
    MaxListNesting = gl.Constants.GL_MAX_LIST_NESTING, 
#endif

#if GL_VERSION_1_0
    ListBase = gl.Constants.GL_LIST_BASE, 
#endif

#if GL_VERSION_1_0
    ListIndex = gl.Constants.GL_LIST_INDEX, 
#endif

#if GL_VERSION_1_0
    PolygonMode = gl.Constants.GL_POLYGON_MODE, 
#endif

#if GL_VERSION_1_0
    PolygonSmooth = gl.Constants.GL_POLYGON_SMOOTH, 
#endif

#if GL_VERSION_1_0
    PolygonStipple = gl.Constants.GL_POLYGON_STIPPLE, 
#endif

#if GL_VERSION_1_0
    EdgeFlag = gl.Constants.GL_EDGE_FLAG, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Lighting = gl.Constants.GL_LIGHTING, 
#endif

#if GL_VERSION_1_0
    LightModelLocalViewer = gl.Constants.GL_LIGHT_MODEL_LOCAL_VIEWER, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    LightModelTwoSide = gl.Constants.GL_LIGHT_MODEL_TWO_SIDE, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    LightModelAmbient = gl.Constants.GL_LIGHT_MODEL_AMBIENT, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    ShadeModel = gl.Constants.GL_SHADE_MODEL, 
#endif

#if GL_VERSION_1_0
    ColorMaterialFace = gl.Constants.GL_COLOR_MATERIAL_FACE, 
#endif

#if GL_VERSION_1_0
    ColorMaterialParameter = gl.Constants.GL_COLOR_MATERIAL_PARAMETER, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    ColorMaterial = gl.Constants.GL_COLOR_MATERIAL, 
#endif

#if (GL_NV_REGISTER_COMBINERS || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Fog = gl.Constants.GL_FOG, 
#endif

#if GL_VERSION_1_0
    FogIndex = gl.Constants.GL_FOG_INDEX, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    FogDensity = gl.Constants.GL_FOG_DENSITY, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    FogStart = gl.Constants.GL_FOG_START, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    FogEnd = gl.Constants.GL_FOG_END, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    FogMode = gl.Constants.GL_FOG_MODE, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    FogColor = gl.Constants.GL_FOG_COLOR, 
#endif

#if GL_VERSION_1_0
    AccumClearValue = gl.Constants.GL_ACCUM_CLEAR_VALUE, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    MatrixMode = gl.Constants.GL_MATRIX_MODE, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    Normalize = gl.Constants.GL_NORMALIZE, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    ModelviewStackDepth = gl.Constants.GL_MODELVIEW_STACK_DEPTH, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    ProjectionStackDepth = gl.Constants.GL_PROJECTION_STACK_DEPTH, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    TextureStackDepth = gl.Constants.GL_TEXTURE_STACK_DEPTH, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    ModelviewMatrix = gl.Constants.GL_MODELVIEW_MATRIX, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    ProjectionMatrix = gl.Constants.GL_PROJECTION_MATRIX, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    TextureMatrix = gl.Constants.GL_TEXTURE_MATRIX, 
#endif

#if GL_VERSION_1_0
    AttribStackDepth = gl.Constants.GL_ATTRIB_STACK_DEPTH, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    AlphaTest = gl.Constants.GL_ALPHA_TEST, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    AlphaTestFunc = gl.Constants.GL_ALPHA_TEST_FUNC, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    AlphaTestRef = gl.Constants.GL_ALPHA_TEST_REF, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    BlendDst = gl.Constants.GL_BLEND_DST, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    BlendSrc = gl.Constants.GL_BLEND_SRC, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    LogicOpMode = gl.Constants.GL_LOGIC_OP_MODE, 
#endif

#if GL_VERSION_1_0
    LogicOp = gl.Constants.GL_LOGIC_OP, 
#endif

#if GL_VERSION_1_0
    AuxBuffers = gl.Constants.GL_AUX_BUFFERS, 
#endif

#if GL_VERSION_1_0
    DrawBuffer = gl.Constants.GL_DRAW_BUFFER, 
#endif

#if GL_VERSION_1_0
    IndexClearValue = gl.Constants.GL_INDEX_CLEAR_VALUE, 
#endif

#if GL_VERSION_1_0
    IndexWritemask = gl.Constants.GL_INDEX_WRITEMASK, 
#endif

#if GL_VERSION_1_0
    IndexMode = gl.Constants.GL_INDEX_MODE, 
#endif

#if GL_VERSION_1_0
    RgbaMode = gl.Constants.GL_RGBA_MODE, 
#endif

#if GL_VERSION_1_0
    Doublebuffer = gl.Constants.GL_DOUBLEBUFFER, 
#endif

#if GL_VERSION_1_0
    Stereo = gl.Constants.GL_STEREO, 
#endif

#if GL_VERSION_1_0
    RenderMode = gl.Constants.GL_RENDER_MODE, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    PerspectiveCorrectionHint = gl.Constants.GL_PERSPECTIVE_CORRECTION_HINT, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    PointSmoothHint = gl.Constants.GL_POINT_SMOOTH_HINT, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    LineSmoothHint = gl.Constants.GL_LINE_SMOOTH_HINT, 
#endif

#if GL_VERSION_1_0
    PolygonSmoothHint = gl.Constants.GL_POLYGON_SMOOTH_HINT, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    FogHint = gl.Constants.GL_FOG_HINT, 
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
    PixelMapIToISize = gl.Constants.GL_PIXEL_MAP_I_TO_I_SIZE, 
#endif

#if GL_VERSION_1_0
    PixelMapSToSSize = gl.Constants.GL_PIXEL_MAP_S_TO_S_SIZE, 
#endif

#if GL_VERSION_1_0
    PixelMapIToRSize = gl.Constants.GL_PIXEL_MAP_I_TO_R_SIZE, 
#endif

#if GL_VERSION_1_0
    PixelMapIToGSize = gl.Constants.GL_PIXEL_MAP_I_TO_G_SIZE, 
#endif

#if GL_VERSION_1_0
    PixelMapIToBSize = gl.Constants.GL_PIXEL_MAP_I_TO_B_SIZE, 
#endif

#if GL_VERSION_1_0
    PixelMapIToASize = gl.Constants.GL_PIXEL_MAP_I_TO_A_SIZE, 
#endif

#if GL_VERSION_1_0
    PixelMapRToRSize = gl.Constants.GL_PIXEL_MAP_R_TO_R_SIZE, 
#endif

#if GL_VERSION_1_0
    PixelMapGToGSize = gl.Constants.GL_PIXEL_MAP_G_TO_G_SIZE, 
#endif

#if GL_VERSION_1_0
    PixelMapBToBSize = gl.Constants.GL_PIXEL_MAP_B_TO_B_SIZE, 
#endif

#if GL_VERSION_1_0
    PixelMapAToASize = gl.Constants.GL_PIXEL_MAP_A_TO_A_SIZE, 
#endif

#if GL_VERSION_1_0
    UnpackSwapBytes = gl.Constants.GL_UNPACK_SWAP_BYTES, 
#endif

#if GL_VERSION_1_0
    UnpackLsbFirst = gl.Constants.GL_UNPACK_LSB_FIRST, 
#endif

#if GL_VERSION_1_0
    PackSwapBytes = gl.Constants.GL_PACK_SWAP_BYTES, 
#endif

#if GL_VERSION_1_0
    PackLsbFirst = gl.Constants.GL_PACK_LSB_FIRST, 
#endif

#if GL_VERSION_1_0
    MapColor = gl.Constants.GL_MAP_COLOR, 
#endif

#if GL_VERSION_1_0
    MapStencil = gl.Constants.GL_MAP_STENCIL, 
#endif

#if GL_VERSION_1_0
    IndexShift = gl.Constants.GL_INDEX_SHIFT, 
#endif

#if GL_VERSION_1_0
    IndexOffset = gl.Constants.GL_INDEX_OFFSET, 
#endif

#if GL_VERSION_1_0
    RedScale = gl.Constants.GL_RED_SCALE, 
#endif

#if GL_VERSION_1_0
    RedBias = gl.Constants.GL_RED_BIAS, 
#endif

#if GL_VERSION_1_0
    ZoomX = gl.Constants.GL_ZOOM_X, 
#endif

#if GL_VERSION_1_0
    ZoomY = gl.Constants.GL_ZOOM_Y, 
#endif

#if GL_VERSION_1_0
    GreenScale = gl.Constants.GL_GREEN_SCALE, 
#endif

#if GL_VERSION_1_0
    GreenBias = gl.Constants.GL_GREEN_BIAS, 
#endif

#if GL_VERSION_1_0
    BlueScale = gl.Constants.GL_BLUE_SCALE, 
#endif

#if GL_VERSION_1_0
    BlueBias = gl.Constants.GL_BLUE_BIAS, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    AlphaScale = gl.Constants.GL_ALPHA_SCALE, 
#endif

#if GL_VERSION_1_0
    AlphaBias = gl.Constants.GL_ALPHA_BIAS, 
#endif

#if GL_VERSION_1_0
    DepthScale = gl.Constants.GL_DEPTH_SCALE, 
#endif

#if GL_VERSION_1_0
    DepthBias = gl.Constants.GL_DEPTH_BIAS, 
#endif

#if GL_VERSION_1_0
    MaxEvalOrder = gl.Constants.GL_MAX_EVAL_ORDER, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    MaxLights = gl.Constants.GL_MAX_LIGHTS, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    MaxClipPlanes = gl.Constants.GL_MAX_CLIP_PLANES, 
#endif

#if GL_VERSION_1_0
    MaxPixelMapTable = gl.Constants.GL_MAX_PIXEL_MAP_TABLE, 
#endif

#if GL_VERSION_1_0
    MaxAttribStackDepth = gl.Constants.GL_MAX_ATTRIB_STACK_DEPTH, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    MaxModelviewStackDepth = gl.Constants.GL_MAX_MODELVIEW_STACK_DEPTH, 
#endif

#if GL_VERSION_1_0
    MaxNameStackDepth = gl.Constants.GL_MAX_NAME_STACK_DEPTH, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    MaxProjectionStackDepth = gl.Constants.GL_MAX_PROJECTION_STACK_DEPTH, 
#endif

#if (GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    MaxTextureStackDepth = gl.Constants.GL_MAX_TEXTURE_STACK_DEPTH, 
#endif

#if GL_VERSION_1_0
    Index = gl.Constants.GL_INDEX_BITS, 
#endif

#if GL_VERSION_1_0
    AccumRed = gl.Constants.GL_ACCUM_RED_BITS, 
#endif

#if GL_VERSION_1_0
    AccumGreen = gl.Constants.GL_ACCUM_GREEN_BITS, 
#endif

#if GL_VERSION_1_0
    AccumBlue = gl.Constants.GL_ACCUM_BLUE_BITS, 
#endif

#if GL_VERSION_1_0
    AccumAlpha = gl.Constants.GL_ACCUM_ALPHA_BITS, 
#endif

#if GL_VERSION_1_0
    NameStackDepth = gl.Constants.GL_NAME_STACK_DEPTH, 
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

#if GL_VERSION_1_0
    Map1GridDomain = gl.Constants.GL_MAP1_GRID_DOMAIN, 
#endif

#if GL_VERSION_1_0
    Map1GridSegments = gl.Constants.GL_MAP1_GRID_SEGMENTS, 
#endif

#if GL_VERSION_1_0
    Map2GridDomain = gl.Constants.GL_MAP2_GRID_DOMAIN, 
#endif

#if GL_VERSION_1_0
    Map2GridSegments = gl.Constants.GL_MAP2_GRID_SEGMENTS, 
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
    ClientAttribStackDepth = gl.Constants.GL_CLIENT_ATTRIB_STACK_DEPTH, 
#endif

#if GL_VERSION_1_1
    IndexLogicOp = gl.Constants.GL_INDEX_LOGIC_OP, 
#endif

#if (GL_VERSION_1_1 || GL_VERSION_ES_CM_1_0)
    ColorLogicOp = gl.Constants.GL_COLOR_LOGIC_OP, 
#endif

#if GL_VERSION_1_1
    MaxClientAttribStackDepth = gl.Constants.GL_MAX_CLIENT_ATTRIB_STACK_DEPTH, 
#endif

#if GL_VERSION_1_1
    FeedbackBufferSize = gl.Constants.GL_FEEDBACK_BUFFER_SIZE, 
#endif

#if GL_VERSION_1_1
    FeedbackBufferType = gl.Constants.GL_FEEDBACK_BUFFER_TYPE, 
#endif

#if GL_VERSION_1_1
    SelectionBufferSize = gl.Constants.GL_SELECTION_BUFFER_SIZE, 
#endif

#if GL_VERSION_1_1
    PolygonOffsetPoint = gl.Constants.GL_POLYGON_OFFSET_POINT, 
#endif

#if GL_VERSION_1_1
    PolygonOffsetLine = gl.Constants.GL_POLYGON_OFFSET_LINE, 
#endif

#if (GL_ARB_DIRECT_STATE_ACCESS || GL_VERSION_1_1 || GL_VERSION_4_5)
    TextureBinding1D = gl.Constants.GL_TEXTURE_BINDING_1D, 
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

#if (GL_VERSION_1_1 || GL_VERSION_ES_CM_1_0)
    VertexArraySize = gl.Constants.GL_VERTEX_ARRAY_SIZE, 
#endif

#if (GL_VERSION_1_1 || GL_VERSION_ES_CM_1_0)
    VertexArrayType = gl.Constants.GL_VERTEX_ARRAY_TYPE, 
#endif

#if (GL_VERSION_1_1 || GL_VERSION_ES_CM_1_0)
    VertexArrayStride = gl.Constants.GL_VERTEX_ARRAY_STRIDE, 
#endif

#if (GL_VERSION_1_1 || GL_VERSION_ES_CM_1_0)
    NormalArrayType = gl.Constants.GL_NORMAL_ARRAY_TYPE, 
#endif

#if (GL_VERSION_1_1 || GL_VERSION_ES_CM_1_0)
    NormalArrayStride = gl.Constants.GL_NORMAL_ARRAY_STRIDE, 
#endif

#if (GL_VERSION_1_1 || GL_VERSION_ES_CM_1_0)
    ColorArraySize = gl.Constants.GL_COLOR_ARRAY_SIZE, 
#endif

#if (GL_VERSION_1_1 || GL_VERSION_ES_CM_1_0)
    ColorArrayType = gl.Constants.GL_COLOR_ARRAY_TYPE, 
#endif

#if (GL_VERSION_1_1 || GL_VERSION_ES_CM_1_0)
    ColorArrayStride = gl.Constants.GL_COLOR_ARRAY_STRIDE, 
#endif

#if GL_VERSION_1_1
    IndexArrayType = gl.Constants.GL_INDEX_ARRAY_TYPE, 
#endif

#if GL_VERSION_1_1
    IndexArrayStride = gl.Constants.GL_INDEX_ARRAY_STRIDE, 
#endif

#if (GL_VERSION_1_1 || GL_VERSION_ES_CM_1_0)
    TextureCoordArraySize = gl.Constants.GL_TEXTURE_COORD_ARRAY_SIZE, 
#endif

#if (GL_VERSION_1_1 || GL_VERSION_ES_CM_1_0)
    TextureCoordArrayType = gl.Constants.GL_TEXTURE_COORD_ARRAY_TYPE, 
#endif

#if (GL_VERSION_1_1 || GL_VERSION_ES_CM_1_0)
    TextureCoordArrayStride = gl.Constants.GL_TEXTURE_COORD_ARRAY_STRIDE, 
#endif

#if GL_VERSION_1_1
    EdgeFlagArrayStride = gl.Constants.GL_EDGE_FLAG_ARRAY_STRIDE, 
#endif

#if (GL_VERSION_1_2 || GL_VERSION_ES_CM_1_0)
    SmoothPointSizeRange = gl.Constants.GL_SMOOTH_POINT_SIZE_RANGE, 
#endif

#if GL_VERSION_1_2
    SmoothPointSizeGranularity = gl.Constants.GL_SMOOTH_POINT_SIZE_GRANULARITY, 
#endif

#if (GL_VERSION_1_2 || GL_VERSION_ES_CM_1_0)
    SmoothLineWidthRange = gl.Constants.GL_SMOOTH_LINE_WIDTH_RANGE, 
#endif

#if GL_VERSION_1_2
    SmoothLineWidthGranularity = gl.Constants.GL_SMOOTH_LINE_WIDTH_GRANULARITY, 
#endif

#if GL_VERSION_1_2
    PackSkipImages = gl.Constants.GL_PACK_SKIP_IMAGES, 
#endif

#if GL_VERSION_1_2
    PackImageHeight = gl.Constants.GL_PACK_IMAGE_HEIGHT, 
#endif

#if GL_VERSION_1_2
    LightModelColorControl = gl.Constants.GL_LIGHT_MODEL_COLOR_CONTROL, 
#endif

#if GL_VERSION_1_3
    TextureCompressionHint = gl.Constants.GL_TEXTURE_COMPRESSION_HINT, 
#endif

#if (GL_VERSION_1_4 || GL_VERSION_ES_CM_1_0)
    PointFadeThresholdSize = gl.Constants.GL_POINT_FADE_THRESHOLD_SIZE, 
#endif

#if GL_VERSION_2_0
    MaxVaryingFloats = gl.Constants.GL_MAX_VARYING_FLOATS, 
#endif

#if GL_VERSION_3_0
    MaxClipDistances = gl.Constants.GL_MAX_CLIP_DISTANCES, 
#endif

#if (GL_ARB_DIRECT_STATE_ACCESS || GL_VERSION_3_0 || GL_VERSION_4_5)
    TextureBinding1DArray = gl.Constants.GL_TEXTURE_BINDING_1D_ARRAY, 
#endif

#if (GL_ARB_DIRECT_STATE_ACCESS || GL_VERSION_3_1 || GL_VERSION_4_5)
    TextureBindingRectangle = gl.Constants.GL_TEXTURE_BINDING_RECTANGLE, 
#endif

#if GL_VERSION_3_1
    MaxRectangleTextureSize = gl.Constants.GL_MAX_RECTANGLE_TEXTURE_SIZE, 
#endif

#if GL_VERSION_3_1
    PrimitiveRestartIndex = gl.Constants.GL_PRIMITIVE_RESTART_INDEX, 
#endif

#if GL_VERSION_3_2
    ProgramPointSize = gl.Constants.GL_PROGRAM_POINT_SIZE, 
#endif

#if (GL_ARB_PROVOKING_VERTEX || GL_ARB_VIEWPORT_ARRAY || GL_VERSION_3_2)
    ProvokingVertex = gl.Constants.GL_PROVOKING_VERTEX, 
#endif

#if GL_VERSION_3_2
    ContextProfileMask = gl.Constants.GL_CONTEXT_PROFILE_MASK, 
#endif

#if (GL_ARB_BLEND_FUNC_EXTENDED || GL_VERSION_3_3)
    MaxDualSourceDrawBuffers = gl.Constants.GL_MAX_DUAL_SOURCE_DRAW_BUFFERS, 
#endif

#if (GL_ARB_TIMER_QUERY || GL_VERSION_3_3)
    Timestamp = gl.Constants.GL_TIMESTAMP, 
#endif

#if (GL_ARB_VIEWPORT_ARRAY || GL_VERSION_4_1)
    MaxViewports = gl.Constants.GL_MAX_VIEWPORTS, 
#endif

#if (GL_ARB_VIEWPORT_ARRAY || GL_VERSION_4_1)
    ViewportSubpixel = gl.Constants.GL_VIEWPORT_SUBPIXEL_BITS, 
#endif

#if (GL_ARB_VIEWPORT_ARRAY || GL_VERSION_4_1)
    ViewportBoundsRange = gl.Constants.GL_VIEWPORT_BOUNDS_RANGE, 
#endif

#if (GL_ARB_VIEWPORT_ARRAY || GL_VERSION_4_1)
    ViewportIndexProvokingVertex = gl.Constants.GL_VIEWPORT_INDEX_PROVOKING_VERTEX, 
#endif

#if (GL_ARB_MAP_BUFFER_ALIGNMENT || GL_VERSION_4_2)
    MinMapBufferAlignment = gl.Constants.GL_MIN_MAP_BUFFER_ALIGNMENT, 
#endif

#if GL_ARB_TEXTURE_CUBE_MAP
    TextureBindingCubeMapArb = gl.Constants.GL_TEXTURE_BINDING_CUBE_MAP_ARB, 
#endif

#if GL_ARB_TEXTURE_RECTANGLE
    TextureBindingRectangleArb = gl.Constants.GL_TEXTURE_BINDING_RECTANGLE_ARB, 
#endif

#if GL_ARM_SHADER_FRAMEBUFFER_FETCH
    FetchPerSampleArm = gl.Constants.GL_FETCH_PER_SAMPLE_ARM, 
#endif

#if GL_ARM_SHADER_FRAMEBUFFER_FETCH
    FragmentShaderFramebufferFetchMrtArm = gl.Constants.GL_FRAGMENT_SHADER_FRAMEBUFFER_FETCH_MRT_ARM, 
#endif

#if GL_EXT_BLEND_COLOR
    BlendColorExt = gl.Constants.GL_BLEND_COLOR_EXT, 
#endif

#if GL_EXT_BLEND_MINMAX
    BlendEquationExt = gl.Constants.GL_BLEND_EQUATION_EXT, 
#endif

#if GL_EXT_CMYKA
    PackCmykHintExt = gl.Constants.GL_PACK_CMYK_HINT_EXT, 
#endif

#if GL_EXT_CMYKA
    UnpackCmykHintExt = gl.Constants.GL_UNPACK_CMYK_HINT_EXT, 
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

#if GL_EXT_CONVOLUTION
    PostConvolutionRedScaleExt = gl.Constants.GL_POST_CONVOLUTION_RED_SCALE_EXT, 
#endif

#if GL_EXT_CONVOLUTION
    PostConvolutionGreenScaleExt = gl.Constants.GL_POST_CONVOLUTION_GREEN_SCALE_EXT, 
#endif

#if GL_EXT_CONVOLUTION
    PostConvolutionBlueScaleExt = gl.Constants.GL_POST_CONVOLUTION_BLUE_SCALE_EXT, 
#endif

#if GL_EXT_CONVOLUTION
    PostConvolutionAlphaScaleExt = gl.Constants.GL_POST_CONVOLUTION_ALPHA_SCALE_EXT, 
#endif

#if GL_EXT_CONVOLUTION
    PostConvolutionRedBiasExt = gl.Constants.GL_POST_CONVOLUTION_RED_BIAS_EXT, 
#endif

#if GL_EXT_CONVOLUTION
    PostConvolutionGreenBiasExt = gl.Constants.GL_POST_CONVOLUTION_GREEN_BIAS_EXT, 
#endif

#if GL_EXT_CONVOLUTION
    PostConvolutionBlueBiasExt = gl.Constants.GL_POST_CONVOLUTION_BLUE_BIAS_EXT, 
#endif

#if GL_EXT_CONVOLUTION
    PostConvolutionAlphaBiasExt = gl.Constants.GL_POST_CONVOLUTION_ALPHA_BIAS_EXT, 
#endif

#if (GL_EXT_DRAW_BUFFERS || GL_EXT_FRAMEBUFFER_OBJECT)
    MaxColorAttachmentsExt = gl.Constants.GL_MAX_COLOR_ATTACHMENTS_EXT, 
#endif

#if GL_EXT_HISTOGRAM
    HistogramExt = gl.Constants.GL_HISTOGRAM_EXT, 
#endif

#if GL_EXT_HISTOGRAM
    MinmaxExt = gl.Constants.GL_MINMAX_EXT, 
#endif

#if (GL_EXT_MEMORY_OBJECT || GL_EXT_SEMAPHORE)
    NumDeviceUuidsExt = gl.Constants.GL_NUM_DEVICE_UUIDS_EXT, 
#endif

#if (GL_EXT_MEMORY_OBJECT || GL_EXT_SEMAPHORE)
    DeviceUuidExt = gl.Constants.GL_DEVICE_UUID_EXT, 
#endif

#if (GL_EXT_MEMORY_OBJECT || GL_EXT_SEMAPHORE)
    DriverUuidExt = gl.Constants.GL_DRIVER_UUID_EXT, 
#endif

#if (GL_EXT_MEMORY_OBJECT_WIN32 || GL_EXT_SEMAPHORE_WIN32)
    DeviceLuidExt = gl.Constants.GL_DEVICE_LUID_EXT, 
#endif

#if (GL_EXT_MEMORY_OBJECT_WIN32 || GL_EXT_SEMAPHORE_WIN32)
    DeviceNodeMaskExt = gl.Constants.GL_DEVICE_NODE_MASK_EXT, 
#endif

#if GL_EXT_MULTIVIEW_DRAW_BUFFERS
    DrawBufferExt = gl.Constants.GL_DRAW_BUFFER_EXT, 
#endif

#if GL_EXT_MULTIVIEW_DRAW_BUFFERS
    ReadBufferExt = gl.Constants.GL_READ_BUFFER_EXT, 
#endif

#if GL_EXT_POLYGON_OFFSET
    PolygonOffsetBiasExt = gl.Constants.GL_POLYGON_OFFSET_BIAS_EXT, 
#endif

#if GL_EXT_RESCALE_NORMAL
    RescaleNormalExt = gl.Constants.GL_RESCALE_NORMAL_EXT, 
#endif

#if GL_EXT_SHARED_TEXTURE_PALETTE
    SharedTexturePaletteExt = gl.Constants.GL_SHARED_TEXTURE_PALETTE_EXT, 
#endif

#if GL_EXT_TEXTURE_CUBE_MAP
    TextureBindingCubeMapExt = gl.Constants.GL_TEXTURE_BINDING_CUBE_MAP_EXT, 
#endif

#if GL_EXT_TEXTURE_OBJECT
    Texture3DBindingExt = gl.Constants.GL_TEXTURE_3D_BINDING_EXT, 
#endif

#if GL_EXT_TEXTURE3D
    PackSkipImagesExt = gl.Constants.GL_PACK_SKIP_IMAGES_EXT, 
#endif

#if GL_EXT_TEXTURE3D
    PackImageHeightExt = gl.Constants.GL_PACK_IMAGE_HEIGHT_EXT, 
#endif

#if GL_EXT_TEXTURE3D
    UnpackSkipImagesExt = gl.Constants.GL_UNPACK_SKIP_IMAGES_EXT, 
#endif

#if GL_EXT_TEXTURE3D
    UnpackImageHeightExt = gl.Constants.GL_UNPACK_IMAGE_HEIGHT_EXT, 
#endif

#if GL_EXT_TEXTURE3D
    Texture3DExt = gl.Constants.GL_TEXTURE_3D_EXT, 
#endif

#if GL_EXT_TEXTURE3D
    Max3DTextureSizeExt = gl.Constants.GL_MAX_3D_TEXTURE_SIZE_EXT, 
#endif

#if GL_EXT_VERTEX_ARRAY
    VertexArrayCountExt = gl.Constants.GL_VERTEX_ARRAY_COUNT_EXT, 
#endif

#if GL_EXT_VERTEX_ARRAY
    NormalArrayCountExt = gl.Constants.GL_NORMAL_ARRAY_COUNT_EXT, 
#endif

#if GL_EXT_VERTEX_ARRAY
    ColorArrayCountExt = gl.Constants.GL_COLOR_ARRAY_COUNT_EXT, 
#endif

#if GL_EXT_VERTEX_ARRAY
    IndexArrayCountExt = gl.Constants.GL_INDEX_ARRAY_COUNT_EXT, 
#endif

#if GL_EXT_VERTEX_ARRAY
    TextureCoordArrayCountExt = gl.Constants.GL_TEXTURE_COORD_ARRAY_COUNT_EXT, 
#endif

#if GL_EXT_VERTEX_ARRAY
    EdgeFlagArrayCountExt = gl.Constants.GL_EDGE_FLAG_ARRAY_COUNT_EXT, 
#endif

#if GL_EXT_VERTEX_WEIGHTING
    Modelview0StackDepthExt = gl.Constants.GL_MODELVIEW0_STACK_DEPTH_EXT, 
#endif

#if GL_EXT_VERTEX_WEIGHTING
    Modelview0MatrixExt = gl.Constants.GL_MODELVIEW0_MATRIX_EXT, 
#endif

#if GL_NV_FBO_COLOR_ATTACHMENTS
    MaxColorAttachmentsNv = gl.Constants.GL_MAX_COLOR_ATTACHMENTS_NV, 
#endif

#if GL_NV_PRIMITIVE_SHADING_RATE
    ShadingRateImagePerPrimitiveNv = gl.Constants.GL_SHADING_RATE_IMAGE_PER_PRIMITIVE_NV, 
#endif

#if GL_NV_PRIMITIVE_SHADING_RATE
    ShadingRateImagePaletteCountNv = gl.Constants.GL_SHADING_RATE_IMAGE_PALETTE_COUNT_NV, 
#endif

#if GL_NV_READ_BUFFER
    ReadBufferNv = gl.Constants.GL_READ_BUFFER_NV, 
#endif

#if GL_NV_TEXTURE_RECTANGLE
    TextureBindingRectangleNv = gl.Constants.GL_TEXTURE_BINDING_RECTANGLE_NV, 
#endif

#if GL_NV_TIMELINE_SEMAPHORE
    MaxTimelineSemaphoreValueDifferenceNv = gl.Constants.GL_MAX_TIMELINE_SEMAPHORE_VALUE_DIFFERENCE_NV, 
#endif

#if GL_OES_TEXTURE_CUBE_MAP
    TextureBindingCubeMapOes = gl.Constants.GL_TEXTURE_BINDING_CUBE_MAP_OES, 
#endif

#if GL_QCOM_ALPHA_TEST
    AlphaTestQcom = gl.Constants.GL_ALPHA_TEST_QCOM, 
#endif

#if GL_QCOM_ALPHA_TEST
    AlphaTestFuncQcom = gl.Constants.GL_ALPHA_TEST_FUNC_QCOM, 
#endif

#if GL_QCOM_ALPHA_TEST
    AlphaTestRefQcom = gl.Constants.GL_ALPHA_TEST_REF_QCOM, 
#endif

#if GL_QCOM_MOTION_ESTIMATION
    MotionEstimationSearchBlockXQcom = gl.Constants.GL_MOTION_ESTIMATION_SEARCH_BLOCK_X_QCOM, 
#endif

#if GL_QCOM_MOTION_ESTIMATION
    MotionEstimationSearchBlockYQcom = gl.Constants.GL_MOTION_ESTIMATION_SEARCH_BLOCK_Y_QCOM, 
#endif

#if GL_QCOM_SHADING_RATE
    ShadingRateQcom = gl.Constants.GL_SHADING_RATE_QCOM, 
#endif

#if GL_SGI_COLOR_MATRIX
    ColorMatrixSgi = gl.Constants.GL_COLOR_MATRIX_SGI, 
#endif

#if GL_SGI_COLOR_MATRIX
    ColorMatrixStackDepthSgi = gl.Constants.GL_COLOR_MATRIX_STACK_DEPTH_SGI, 
#endif

#if GL_SGI_COLOR_MATRIX
    MaxColorMatrixStackDepthSgi = gl.Constants.GL_MAX_COLOR_MATRIX_STACK_DEPTH_SGI, 
#endif

#if GL_SGI_COLOR_MATRIX
    PostColorMatrixRedScaleSgi = gl.Constants.GL_POST_COLOR_MATRIX_RED_SCALE_SGI, 
#endif

#if GL_SGI_COLOR_MATRIX
    PostColorMatrixGreenScaleSgi = gl.Constants.GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI, 
#endif

#if GL_SGI_COLOR_MATRIX
    PostColorMatrixBlueScaleSgi = gl.Constants.GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI, 
#endif

#if GL_SGI_COLOR_MATRIX
    PostColorMatrixAlphaScaleSgi = gl.Constants.GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI, 
#endif

#if GL_SGI_COLOR_MATRIX
    PostColorMatrixRedBiasSgi = gl.Constants.GL_POST_COLOR_MATRIX_RED_BIAS_SGI, 
#endif

#if GL_SGI_COLOR_MATRIX
    PostColorMatrixGreenBiasSgi = gl.Constants.GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI, 
#endif

#if GL_SGI_COLOR_MATRIX
    PostColorMatrixBlueBiasSgi = gl.Constants.GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI, 
#endif

#if GL_SGI_COLOR_MATRIX
    PostColorMatrixAlphaBiasSgi = gl.Constants.GL_POST_COLOR_MATRIX_ALPHA_BIAS_SGI, 
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

#if GL_SGIS_DETAIL_TEXTURE
    DetailTexture2DBindingSgis = gl.Constants.GL_DETAIL_TEXTURE_2D_BINDING_SGIS, 
#endif

#if GL_SGIS_FOG_FUNCTION
    FogFuncPointsSgis = gl.Constants.GL_FOG_FUNC_POINTS_SGIS, 
#endif

#if GL_SGIS_FOG_FUNCTION
    MaxFogFuncPointsSgis = gl.Constants.GL_MAX_FOG_FUNC_POINTS_SGIS, 
#endif

#if GL_SGIS_GENERATE_MIPMAP
    GenerateMipmapHintSgis = gl.Constants.GL_GENERATE_MIPMAP_HINT_SGIS, 
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

#if GL_SGIS_MULTISAMPLE
    SampleBuffersSgis = gl.Constants.GL_SAMPLE_BUFFERS_SGIS, 
#endif

#if GL_SGIS_MULTISAMPLE
    SamplesSgis = gl.Constants.GL_SAMPLES_SGIS, 
#endif

#if GL_SGIS_MULTISAMPLE
    SampleMaskValueSgis = gl.Constants.GL_SAMPLE_MASK_VALUE_SGIS, 
#endif

#if GL_SGIS_MULTISAMPLE
    SampleMaskInvertSgis = gl.Constants.GL_SAMPLE_MASK_INVERT_SGIS, 
#endif

#if GL_SGIS_MULTISAMPLE
    SamplePatternSgis = gl.Constants.GL_SAMPLE_PATTERN_SGIS, 
#endif

#if GL_SGIS_PIXEL_TEXTURE
    PixelTextureSgis = gl.Constants.GL_PIXEL_TEXTURE_SGIS, 
#endif

#if GL_SGIS_POINT_PARAMETERS
    PointSizeMinSgis = gl.Constants.GL_POINT_SIZE_MIN_SGIS, 
#endif

#if GL_SGIS_POINT_PARAMETERS
    PointSizeMaxSgis = gl.Constants.GL_POINT_SIZE_MAX_SGIS, 
#endif

#if GL_SGIS_POINT_PARAMETERS
    PointFadeThresholdSizeSgis = gl.Constants.GL_POINT_FADE_THRESHOLD_SIZE_SGIS, 
#endif

#if GL_SGIS_POINT_PARAMETERS
    DistanceAttenuationSgis = gl.Constants.GL_DISTANCE_ATTENUATION_SGIS, 
#endif

#if GL_SGIS_TEXTURE4D
    PackSkipVolumesSgis = gl.Constants.GL_PACK_SKIP_VOLUMES_SGIS, 
#endif

#if GL_SGIS_TEXTURE4D
    PackImageDepthSgis = gl.Constants.GL_PACK_IMAGE_DEPTH_SGIS, 
#endif

#if GL_SGIS_TEXTURE4D
    UnpackSkipVolumesSgis = gl.Constants.GL_UNPACK_SKIP_VOLUMES_SGIS, 
#endif

#if GL_SGIS_TEXTURE4D
    UnpackImageDepthSgis = gl.Constants.GL_UNPACK_IMAGE_DEPTH_SGIS, 
#endif

#if GL_SGIS_TEXTURE4D
    Texture4dSgis = gl.Constants.GL_TEXTURE_4D_SGIS, 
#endif

#if GL_SGIS_TEXTURE4D
    Max4dTextureSizeSgis = gl.Constants.GL_MAX_4D_TEXTURE_SIZE_SGIS, 
#endif

#if GL_SGIS_TEXTURE4D
    Texture4dBindingSgis = gl.Constants.GL_TEXTURE_4D_BINDING_SGIS, 
#endif

#if GL_SGIX_ASYNC
    AsyncMarkerSgix = gl.Constants.GL_ASYNC_MARKER_SGIX, 
#endif

#if GL_SGIX_ASYNC_HISTOGRAM
    AsyncHistogramSgix = gl.Constants.GL_ASYNC_HISTOGRAM_SGIX, 
#endif

#if GL_SGIX_ASYNC_HISTOGRAM
    MaxAsyncHistogramSgix = gl.Constants.GL_MAX_ASYNC_HISTOGRAM_SGIX, 
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

#if GL_SGIX_ASYNC_PIXEL
    MaxAsyncTexImageSgix = gl.Constants.GL_MAX_ASYNC_TEX_IMAGE_SGIX, 
#endif

#if GL_SGIX_ASYNC_PIXEL
    MaxAsyncDrawPixelsSgix = gl.Constants.GL_MAX_ASYNC_DRAW_PIXELS_SGIX, 
#endif

#if GL_SGIX_ASYNC_PIXEL
    MaxAsyncReadPixelsSgix = gl.Constants.GL_MAX_ASYNC_READ_PIXELS_SGIX, 
#endif

#if GL_SGIX_CALLIGRAPHIC_FRAGMENT
    CalligraphicFragmentSgix = gl.Constants.GL_CALLIGRAPHIC_FRAGMENT_SGIX, 
#endif

#if GL_SGIX_CLIPMAP
    MaxClipmapDepthSgix = gl.Constants.GL_MAX_CLIPMAP_DEPTH_SGIX, 
#endif

#if GL_SGIX_CLIPMAP
    MaxClipmapVirtualDepthSgix = gl.Constants.GL_MAX_CLIPMAP_VIRTUAL_DEPTH_SGIX, 
#endif

#if GL_SGIX_CONVOLUTION_ACCURACY
    ConvolutionHintSgix = gl.Constants.GL_CONVOLUTION_HINT_SGIX, 
#endif

#if GL_SGIX_FOG_OFFSET
    FogOffsetSgix = gl.Constants.GL_FOG_OFFSET_SGIX, 
#endif

#if GL_SGIX_FOG_OFFSET
    FogOffsetValueSgix = gl.Constants.GL_FOG_OFFSET_VALUE_SGIX, 
#endif

#if GL_SGIX_FRAGMENT_LIGHTING
    FragmentLightingSgix = gl.Constants.GL_FRAGMENT_LIGHTING_SGIX, 
#endif

#if GL_SGIX_FRAGMENT_LIGHTING
    FragmentColorMaterialSgix = gl.Constants.GL_FRAGMENT_COLOR_MATERIAL_SGIX, 
#endif

#if GL_SGIX_FRAGMENT_LIGHTING
    FragmentColorMaterialFaceSgix = gl.Constants.GL_FRAGMENT_COLOR_MATERIAL_FACE_SGIX, 
#endif

#if GL_SGIX_FRAGMENT_LIGHTING
    FragmentColorMaterialParameterSgix = gl.Constants.GL_FRAGMENT_COLOR_MATERIAL_PARAMETER_SGIX, 
#endif

#if GL_SGIX_FRAGMENT_LIGHTING
    MaxFragmentLightsSgix = gl.Constants.GL_MAX_FRAGMENT_LIGHTS_SGIX, 
#endif

#if GL_SGIX_FRAGMENT_LIGHTING
    MaxActiveLightsSgix = gl.Constants.GL_MAX_ACTIVE_LIGHTS_SGIX, 
#endif

#if GL_SGIX_FRAGMENT_LIGHTING
    LightEnvModeSgix = gl.Constants.GL_LIGHT_ENV_MODE_SGIX, 
#endif

#if GL_SGIX_FRAGMENT_LIGHTING
    FragmentLightModelLocalViewerSgix = gl.Constants.GL_FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX, 
#endif

#if GL_SGIX_FRAGMENT_LIGHTING
    FragmentLightModelTwoSideSgix = gl.Constants.GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX, 
#endif

#if GL_SGIX_FRAGMENT_LIGHTING
    FragmentLightModelAmbientSgix = gl.Constants.GL_FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX, 
#endif

#if GL_SGIX_FRAGMENT_LIGHTING
    FragmentLightModelNormalInterpolationSgix = gl.Constants.GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX, 
#endif

#if GL_SGIX_FRAGMENT_LIGHTING
    FragmentLight0Sgix = gl.Constants.GL_FRAGMENT_LIGHT0_SGIX, 
#endif

#if GL_SGIX_FRAMEZOOM
    FramezoomSgix = gl.Constants.GL_FRAMEZOOM_SGIX, 
#endif

#if GL_SGIX_FRAMEZOOM
    FramezoomFactorSgix = gl.Constants.GL_FRAMEZOOM_FACTOR_SGIX, 
#endif

#if GL_SGIX_FRAMEZOOM
    MaxFramezoomFactorSgix = gl.Constants.GL_MAX_FRAMEZOOM_FACTOR_SGIX, 
#endif

#if GL_SGIX_INSTRUMENTS
    InstrumentMeasurementsSgix = gl.Constants.GL_INSTRUMENT_MEASUREMENTS_SGIX, 
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

#if GL_SGIX_PIXEL_TEXTURE
    PixelTexGenModeSgix = gl.Constants.GL_PIXEL_TEX_GEN_MODE_SGIX, 
#endif

#if GL_SGIX_PIXEL_TILES
    PixelTileBestAlignmentSgix = gl.Constants.GL_PIXEL_TILE_BEST_ALIGNMENT_SGIX, 
#endif

#if GL_SGIX_PIXEL_TILES
    PixelTileCacheIncrementSgix = gl.Constants.GL_PIXEL_TILE_CACHE_INCREMENT_SGIX, 
#endif

#if GL_SGIX_PIXEL_TILES
    PixelTileWidthSgix = gl.Constants.GL_PIXEL_TILE_WIDTH_SGIX, 
#endif

#if GL_SGIX_PIXEL_TILES
    PixelTileHeightSgix = gl.Constants.GL_PIXEL_TILE_HEIGHT_SGIX, 
#endif

#if GL_SGIX_PIXEL_TILES
    PixelTileGridWidthSgix = gl.Constants.GL_PIXEL_TILE_GRID_WIDTH_SGIX, 
#endif

#if GL_SGIX_PIXEL_TILES
    PixelTileGridHeightSgix = gl.Constants.GL_PIXEL_TILE_GRID_HEIGHT_SGIX, 
#endif

#if GL_SGIX_PIXEL_TILES
    PixelTileGridDepthSgix = gl.Constants.GL_PIXEL_TILE_GRID_DEPTH_SGIX, 
#endif

#if GL_SGIX_PIXEL_TILES
    PixelTileCacheSizeSgix = gl.Constants.GL_PIXEL_TILE_CACHE_SIZE_SGIX, 
#endif

#if GL_SGIX_POLYNOMIAL_FFD
    DeformationsMaskSgix = gl.Constants.GL_DEFORMATIONS_MASK_SGIX, 
#endif

#if GL_SGIX_REFERENCE_PLANE
    ReferencePlaneSgix = gl.Constants.GL_REFERENCE_PLANE_SGIX, 
#endif

#if GL_SGIX_REFERENCE_PLANE
    ReferencePlaneEquationSgix = gl.Constants.GL_REFERENCE_PLANE_EQUATION_SGIX, 
#endif

#if GL_SGIX_RESAMPLE
    PackResampleSgix = gl.Constants.GL_PACK_RESAMPLE_SGIX, 
#endif

#if GL_SGIX_RESAMPLE
    UnpackResampleSgix = gl.Constants.GL_UNPACK_RESAMPLE_SGIX, 
#endif

#if GL_SGIX_SPRITE
    SpriteSgix = gl.Constants.GL_SPRITE_SGIX, 
#endif

#if GL_SGIX_SPRITE
    SpriteModeSgix = gl.Constants.GL_SPRITE_MODE_SGIX, 
#endif

#if GL_SGIX_SPRITE
    SpriteAxisSgix = gl.Constants.GL_SPRITE_AXIS_SGIX, 
#endif

#if GL_SGIX_SPRITE
    SpriteTranslationSgix = gl.Constants.GL_SPRITE_TRANSLATION_SGIX, 
#endif

#if GL_SGIX_SUBSAMPLE
    PackSubsampleRateSgix = gl.Constants.GL_PACK_SUBSAMPLE_RATE_SGIX, 
#endif

#if GL_SGIX_SUBSAMPLE
    UnpackSubsampleRateSgix = gl.Constants.GL_UNPACK_SUBSAMPLE_RATE_SGIX, 
#endif

#if GL_SGIX_TEXTURE_SCALE_BIAS
    PostTextureFilterBiasRangeSgix = gl.Constants.GL_POST_TEXTURE_FILTER_BIAS_RANGE_SGIX, 
#endif

#if GL_SGIX_TEXTURE_SCALE_BIAS
    PostTextureFilterScaleRangeSgix = gl.Constants.GL_POST_TEXTURE_FILTER_SCALE_RANGE_SGIX, 
#endif

#if GL_SGIX_VERTEX_PRECLIP
    VertexPreclipSgix = gl.Constants.GL_VERTEX_PRECLIP_SGIX, 
#endif

#if GL_SGIX_VERTEX_PRECLIP
    VertexPreclipHintSgix = gl.Constants.GL_VERTEX_PRECLIP_HINT_SGIX, 
#endif

}

#endif
