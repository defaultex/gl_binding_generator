#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_3 || GL_VERSION_ES_CM_1_0 || GL_ARB_INTERNALFORMAT_QUERY || GL_ES_VERSION_3_0 || GL_VERSION_4_2 || GL_ES_VERSION_3_1 || GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_VERSION_1_4 || GL_VERSION_4_3 || GL_ARB_CLEAR_TEXTURE || GL_VERSION_4_4 || GL_EXT_TEXTURE_STORAGE_COMPRESSION)

public enum InternalFormatPName : GLenum { 
#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_3 || GL_VERSION_ES_CM_1_0)
    Samples = gl.Constants.GL_SAMPLES, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY || GL_ARB_INTERNALFORMAT_QUERY2 || GL_ES_VERSION_3_0 || GL_VERSION_4_2)
    NumSampleCounts = gl.Constants.GL_NUM_SAMPLE_COUNTS, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_ES_VERSION_3_1 || GL_VERSION_1_3)
    TextureCompressed = gl.Constants.GL_TEXTURE_COMPRESSED, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_ARB_SHADER_IMAGE_LOAD_STORE || GL_ES_VERSION_3_1 || GL_VERSION_4_2)
    ImageCompatibilityType = gl.Constants.GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, 
#endif

#if (GL_VERSION_1_4 || GL_VERSION_ES_CM_1_0)
    GenerateMipmap = gl.Constants.GL_GENERATE_MIPMAP, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    InternalformatSupported = gl.Constants.GL_INTERNALFORMAT_SUPPORTED, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    InternalformatPreferred = gl.Constants.GL_INTERNALFORMAT_PREFERRED, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    InternalformatRedSize = gl.Constants.GL_INTERNALFORMAT_RED_SIZE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    InternalformatGreenSize = gl.Constants.GL_INTERNALFORMAT_GREEN_SIZE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    InternalformatBlueSize = gl.Constants.GL_INTERNALFORMAT_BLUE_SIZE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    InternalformatAlphaSize = gl.Constants.GL_INTERNALFORMAT_ALPHA_SIZE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    InternalformatDepthSize = gl.Constants.GL_INTERNALFORMAT_DEPTH_SIZE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    InternalformatStencilSize = gl.Constants.GL_INTERNALFORMAT_STENCIL_SIZE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    InternalformatSharedSize = gl.Constants.GL_INTERNALFORMAT_SHARED_SIZE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    InternalformatRedType = gl.Constants.GL_INTERNALFORMAT_RED_TYPE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    InternalformatGreenType = gl.Constants.GL_INTERNALFORMAT_GREEN_TYPE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    InternalformatBlueType = gl.Constants.GL_INTERNALFORMAT_BLUE_TYPE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    InternalformatAlphaType = gl.Constants.GL_INTERNALFORMAT_ALPHA_TYPE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    InternalformatDepthType = gl.Constants.GL_INTERNALFORMAT_DEPTH_TYPE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    InternalformatStencilType = gl.Constants.GL_INTERNALFORMAT_STENCIL_TYPE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    MaxWidth = gl.Constants.GL_MAX_WIDTH, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    MaxHeight = gl.Constants.GL_MAX_HEIGHT, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    MaxDepth = gl.Constants.GL_MAX_DEPTH, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    MaxLayers = gl.Constants.GL_MAX_LAYERS, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    ColorComponents = gl.Constants.GL_COLOR_COMPONENTS, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    ColorRenderable = gl.Constants.GL_COLOR_RENDERABLE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    DepthRenderable = gl.Constants.GL_DEPTH_RENDERABLE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    StencilRenderable = gl.Constants.GL_STENCIL_RENDERABLE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    FramebufferRenderable = gl.Constants.GL_FRAMEBUFFER_RENDERABLE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    FramebufferRenderableLayered = gl.Constants.GL_FRAMEBUFFER_RENDERABLE_LAYERED, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    FramebufferBlend = gl.Constants.GL_FRAMEBUFFER_BLEND, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    ReadPixels = gl.Constants.GL_READ_PIXELS, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    ReadPixelsFormat = gl.Constants.GL_READ_PIXELS_FORMAT, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    ReadPixelsType = gl.Constants.GL_READ_PIXELS_TYPE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    TextureImageFormat = gl.Constants.GL_TEXTURE_IMAGE_FORMAT, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    TextureImageType = gl.Constants.GL_TEXTURE_IMAGE_TYPE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    GetTextureImageFormat = gl.Constants.GL_GET_TEXTURE_IMAGE_FORMAT, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    GetTextureImageType = gl.Constants.GL_GET_TEXTURE_IMAGE_TYPE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    Mipmap = gl.Constants.GL_MIPMAP, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    AutoGenerateMipmap = gl.Constants.GL_AUTO_GENERATE_MIPMAP, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    ColorEncoding = gl.Constants.GL_COLOR_ENCODING, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    SrgbRead = gl.Constants.GL_SRGB_READ, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    SrgbWrite = gl.Constants.GL_SRGB_WRITE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    Filter = gl.Constants.GL_FILTER, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    VertexTexture = gl.Constants.GL_VERTEX_TEXTURE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    TessControlTexture = gl.Constants.GL_TESS_CONTROL_TEXTURE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    TessEvaluationTexture = gl.Constants.GL_TESS_EVALUATION_TEXTURE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    GeometryTexture = gl.Constants.GL_GEOMETRY_TEXTURE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    FragmentTexture = gl.Constants.GL_FRAGMENT_TEXTURE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    ComputeTexture = gl.Constants.GL_COMPUTE_TEXTURE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    TextureShadow = gl.Constants.GL_TEXTURE_SHADOW, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    TextureGather = gl.Constants.GL_TEXTURE_GATHER, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    TextureGatherShadow = gl.Constants.GL_TEXTURE_GATHER_SHADOW, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    ShaderImageLoad = gl.Constants.GL_SHADER_IMAGE_LOAD, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    ShaderImageStore = gl.Constants.GL_SHADER_IMAGE_STORE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    ShaderImageAtomic = gl.Constants.GL_SHADER_IMAGE_ATOMIC, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    ImageTexelSize = gl.Constants.GL_IMAGE_TEXEL_SIZE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    ImageCompatibilityClass = gl.Constants.GL_IMAGE_COMPATIBILITY_CLASS, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    ImagePixelFormat = gl.Constants.GL_IMAGE_PIXEL_FORMAT, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    ImagePixelType = gl.Constants.GL_IMAGE_PIXEL_TYPE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    SimultaneousTextureAndDepthTest = gl.Constants.GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    SimultaneousTextureAndStencilTest = gl.Constants.GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    SimultaneousTextureAndDepthWrite = gl.Constants.GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    SimultaneousTextureAndStencilWrite = gl.Constants.GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    TextureCompressedBlockWidth = gl.Constants.GL_TEXTURE_COMPRESSED_BLOCK_WIDTH, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    TextureCompressedBlockHeight = gl.Constants.GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    TextureCompressedBlockSize = gl.Constants.GL_TEXTURE_COMPRESSED_BLOCK_SIZE, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    ClearBuffer = gl.Constants.GL_CLEAR_BUFFER, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    TextureView = gl.Constants.GL_TEXTURE_VIEW, 
#endif

#if (GL_ARB_INTERNALFORMAT_QUERY2 || GL_VERSION_4_3)
    ViewCompatibilityClass = gl.Constants.GL_VIEW_COMPATIBILITY_CLASS, 
#endif

#if (GL_ARB_CLEAR_TEXTURE || GL_VERSION_4_4)
    ClearTexture = gl.Constants.GL_CLEAR_TEXTURE, 
#endif

#if GL_EXT_TEXTURE_STORAGE_COMPRESSION
    NumSurfaceCompressionFixedRatesExt = gl.Constants.GL_NUM_SURFACE_COMPRESSION_FIXED_RATES_EXT, 
#endif

}

#endif
