#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_4 || GL_VERSION_ES_CM_1_0 || GL_ARB_GET_PROGRAM_BINARY || GL_ES_VERSION_3_0 || GL_VERSION_4_1 || GL_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_1_3 || GL_APPLE_TEXTURE_RANGE || GL_APPLE_TRANSFORM_HINT || GL_APPLE_VERTEX_ARRAY_RANGE || GL_ARB_FRAGMENT_SHADER || GL_ARB_TEXTURE_COMPRESSION || GL_EXT_CLIP_VOLUME_HINT || GL_EXT_CMYKA || GL_NV_MULTISAMPLE_FILTER_HINT || GL_OES_STANDARD_DERIVATIVES || GL_PGI_MISC_HINTS || GL_PGI_VERTEX_HINTS || GL_QCOM_BINNING_CONTROL || GL_SGIS_GENERATE_MIPMAP || GL_SGIX_CONVOLUTION_ACCURACY || GL_SGIX_SCALEBIAS_HINT || GL_SGIX_TEXTURE_MULTI_BUFFER || GL_SGIX_VERTEX_PRECLIP || GL_WIN_PHONG_SHADING)

public enum HintTarget : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_4 || GL_VERSION_ES_CM_1_0)
    GenerateMipmapHint = gl.Constants.GL_GENERATE_MIPMAP_HINT, 
#endif

#if (GL_ARB_GET_PROGRAM_BINARY || GL_ES_VERSION_3_0 || GL_VERSION_4_1)
    ProgramBinaryRetrievableHint = gl.Constants.GL_PROGRAM_BINARY_RETRIEVABLE_HINT, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_2_0)
    FragmentShaderDerivativeHint = gl.Constants.GL_FRAGMENT_SHADER_DERIVATIVE_HINT, 
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

#if GL_VERSION_1_3
    TextureCompressionHint = gl.Constants.GL_TEXTURE_COMPRESSION_HINT, 
#endif

#if GL_APPLE_TEXTURE_RANGE
    TextureStorageHintApple = gl.Constants.GL_TEXTURE_STORAGE_HINT_APPLE, 
#endif

#if GL_APPLE_TRANSFORM_HINT
    TransformHintApple = gl.Constants.GL_TRANSFORM_HINT_APPLE, 
#endif

#if GL_APPLE_VERTEX_ARRAY_RANGE
    VertexArrayStorageHintApple = gl.Constants.GL_VERTEX_ARRAY_STORAGE_HINT_APPLE, 
#endif

#if GL_ARB_FRAGMENT_SHADER
    FragmentShaderDerivativeHintArb = gl.Constants.GL_FRAGMENT_SHADER_DERIVATIVE_HINT_ARB, 
#endif

#if GL_ARB_TEXTURE_COMPRESSION
    TextureCompressionHintArb = gl.Constants.GL_TEXTURE_COMPRESSION_HINT_ARB, 
#endif

#if GL_EXT_CLIP_VOLUME_HINT
    ClipVolumeClippingHintExt = gl.Constants.GL_CLIP_VOLUME_CLIPPING_HINT_EXT, 
#endif

#if GL_EXT_CMYKA
    PackCmykHintExt = gl.Constants.GL_PACK_CMYK_HINT_EXT, 
#endif

#if GL_EXT_CMYKA
    UnpackCmykHintExt = gl.Constants.GL_UNPACK_CMYK_HINT_EXT, 
#endif

#if GL_NV_MULTISAMPLE_FILTER_HINT
    MultisampleFilterHintNv = gl.Constants.GL_MULTISAMPLE_FILTER_HINT_NV, 
#endif

#if GL_OES_STANDARD_DERIVATIVES
    FragmentShaderDerivativeHintOes = gl.Constants.GL_FRAGMENT_SHADER_DERIVATIVE_HINT_OES, 
#endif

#if GL_PGI_MISC_HINTS
    PreferDoublebufferHintPgi = gl.Constants.GL_PREFER_DOUBLEBUFFER_HINT_PGI, 
#endif

#if GL_PGI_MISC_HINTS
    ConserveMemoryHintPgi = gl.Constants.GL_CONSERVE_MEMORY_HINT_PGI, 
#endif

#if GL_PGI_MISC_HINTS
    ReclaimMemoryHintPgi = gl.Constants.GL_RECLAIM_MEMORY_HINT_PGI, 
#endif

#if GL_PGI_MISC_HINTS
    NativeGraphicsBeginHintPgi = gl.Constants.GL_NATIVE_GRAPHICS_BEGIN_HINT_PGI, 
#endif

#if GL_PGI_MISC_HINTS
    NativeGraphicsEndHintPgi = gl.Constants.GL_NATIVE_GRAPHICS_END_HINT_PGI, 
#endif

#if GL_PGI_MISC_HINTS
    AlwaysFastHintPgi = gl.Constants.GL_ALWAYS_FAST_HINT_PGI, 
#endif

#if GL_PGI_MISC_HINTS
    AlwaysSoftHintPgi = gl.Constants.GL_ALWAYS_SOFT_HINT_PGI, 
#endif

#if GL_PGI_MISC_HINTS
    AllowDrawObjHintPgi = gl.Constants.GL_ALLOW_DRAW_OBJ_HINT_PGI, 
#endif

#if GL_PGI_MISC_HINTS
    AllowDrawWinHintPgi = gl.Constants.GL_ALLOW_DRAW_WIN_HINT_PGI, 
#endif

#if GL_PGI_MISC_HINTS
    AllowDrawFrgHintPgi = gl.Constants.GL_ALLOW_DRAW_FRG_HINT_PGI, 
#endif

#if GL_PGI_MISC_HINTS
    AllowDrawMemHintPgi = gl.Constants.GL_ALLOW_DRAW_MEM_HINT_PGI, 
#endif

#if GL_PGI_MISC_HINTS
    StrictDepthfuncHintPgi = gl.Constants.GL_STRICT_DEPTHFUNC_HINT_PGI, 
#endif

#if GL_PGI_MISC_HINTS
    StrictLightingHintPgi = gl.Constants.GL_STRICT_LIGHTING_HINT_PGI, 
#endif

#if GL_PGI_MISC_HINTS
    StrictScissorHintPgi = gl.Constants.GL_STRICT_SCISSOR_HINT_PGI, 
#endif

#if GL_PGI_MISC_HINTS
    FullStippleHintPgi = gl.Constants.GL_FULL_STIPPLE_HINT_PGI, 
#endif

#if GL_PGI_MISC_HINTS
    ClipNearHintPgi = gl.Constants.GL_CLIP_NEAR_HINT_PGI, 
#endif

#if GL_PGI_MISC_HINTS
    ClipFarHintPgi = gl.Constants.GL_CLIP_FAR_HINT_PGI, 
#endif

#if GL_PGI_MISC_HINTS
    WideLineHintPgi = gl.Constants.GL_WIDE_LINE_HINT_PGI, 
#endif

#if GL_PGI_MISC_HINTS
    BackNormalsHintPgi = gl.Constants.GL_BACK_NORMALS_HINT_PGI, 
#endif

#if GL_PGI_VERTEX_HINTS
    VertexDataHintPgi = gl.Constants.GL_VERTEX_DATA_HINT_PGI, 
#endif

#if GL_PGI_VERTEX_HINTS
    VertexConsistentHintPgi = gl.Constants.GL_VERTEX_CONSISTENT_HINT_PGI, 
#endif

#if GL_PGI_VERTEX_HINTS
    MaterialSideHintPgi = gl.Constants.GL_MATERIAL_SIDE_HINT_PGI, 
#endif

#if GL_PGI_VERTEX_HINTS
    MaxVertexHintPgi = gl.Constants.GL_MAX_VERTEX_HINT_PGI, 
#endif

#if GL_QCOM_BINNING_CONTROL
    BinningControlHintQcom = gl.Constants.GL_BINNING_CONTROL_HINT_QCOM, 
#endif

#if GL_SGIS_GENERATE_MIPMAP
    GenerateMipmapHintSgis = gl.Constants.GL_GENERATE_MIPMAP_HINT_SGIS, 
#endif

#if GL_SGIX_CONVOLUTION_ACCURACY
    ConvolutionHintSgix = gl.Constants.GL_CONVOLUTION_HINT_SGIX, 
#endif

#if GL_SGIX_SCALEBIAS_HINT
    ScalebiasHintSgix = gl.Constants.GL_SCALEBIAS_HINT_SGIX, 
#endif

#if GL_SGIX_TEXTURE_MULTI_BUFFER
    TextureMultiBufferHintSgix = gl.Constants.GL_TEXTURE_MULTI_BUFFER_HINT_SGIX, 
#endif

#if GL_SGIX_VERTEX_PRECLIP
    VertexPreclipSgix = gl.Constants.GL_VERTEX_PRECLIP_SGIX, 
#endif

#if GL_SGIX_VERTEX_PRECLIP
    VertexPreclipHintSgix = gl.Constants.GL_VERTEX_PRECLIP_HINT_SGIX, 
#endif

#if GL_WIN_PHONG_SHADING
    PhongHintWin = gl.Constants.GL_PHONG_HINT_WIN, 
#endif

}

#endif
