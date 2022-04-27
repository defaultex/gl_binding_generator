#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_ES_VERSION_3_0 || GL_VERSION_1_2 || GL_VERSION_1_4 || GL_ARB_TEXTURE_SWIZZLE || GL_VERSION_3_3 || GL_ES_VERSION_3_1 || GL_VERSION_1_1 || GL_ARB_STENCIL_TEXTURING || GL_VERSION_4_3 || GL_ES_VERSION_3_2 || GL_ARB_TEXTURE_FILTER_ANISOTROPIC || GL_VERSION_4_6 || GL_ARM_TEXTURE_UNNORMALIZED_COORDINATES || GL_EXT_MEMORY_OBJECT || GL_EXT_TEXTURE_OBJECT || GL_EXT_TEXTURE3D || GL_NV_TEXTURE_BORDER_CLAMP || GL_OES_TEXTURE_3D || GL_QCOM_TEXTURE_FOVEATED2 || GL_SGIS_DETAIL_TEXTURE || GL_SGIS_GENERATE_MIPMAP || GL_SGIS_SHARPEN_TEXTURE || GL_SGIS_TEXTURE_FILTER4 || GL_SGIS_TEXTURE_LOD || GL_SGIS_TEXTURE_SELECT || GL_SGIS_TEXTURE4D || GL_SGIX_CLIPMAP || GL_SGIX_SHADOW || GL_SGIX_SHADOW_AMBIENT || GL_SGIX_TEXTURE_COORDINATE_CLAMP || GL_SGIX_TEXTURE_LOD_BIAS || GL_SGIX_TEXTURE_SCALE_BIAS)

public enum TextureParameterName : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    MagFilter = gl.Constants.GL_TEXTURE_MAG_FILTER, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    MinFilter = gl.Constants.GL_TEXTURE_MIN_FILTER, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    WrapS = gl.Constants.GL_TEXTURE_WRAP_S, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    WrapT = gl.Constants.GL_TEXTURE_WRAP_T, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_2)
    WrapR = gl.Constants.GL_TEXTURE_WRAP_R, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_2)
    MinLod = gl.Constants.GL_TEXTURE_MIN_LOD, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_2)
    MaxLod = gl.Constants.GL_TEXTURE_MAX_LOD, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_2)
    BaseLevel = gl.Constants.GL_TEXTURE_BASE_LEVEL, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_2)
    MaxLevel = gl.Constants.GL_TEXTURE_MAX_LEVEL, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_4)
    CompareMode = gl.Constants.GL_TEXTURE_COMPARE_MODE, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_4)
    CompareFunc = gl.Constants.GL_TEXTURE_COMPARE_FUNC, 
#endif

#if (GL_ARB_TEXTURE_SWIZZLE || GL_ES_VERSION_3_0 || GL_VERSION_3_3)
    SwizzleR = gl.Constants.GL_TEXTURE_SWIZZLE_R, 
#endif

#if (GL_ARB_TEXTURE_SWIZZLE || GL_ES_VERSION_3_0 || GL_VERSION_3_3)
    SwizzleG = gl.Constants.GL_TEXTURE_SWIZZLE_G, 
#endif

#if (GL_ARB_TEXTURE_SWIZZLE || GL_ES_VERSION_3_0 || GL_VERSION_3_3)
    SwizzleB = gl.Constants.GL_TEXTURE_SWIZZLE_B, 
#endif

#if (GL_ARB_TEXTURE_SWIZZLE || GL_ES_VERSION_3_0 || GL_VERSION_3_3)
    SwizzleA = gl.Constants.GL_TEXTURE_SWIZZLE_A, 
#endif

#if (GL_ES_VERSION_3_1 || GL_VERSION_1_0)
    Width = gl.Constants.GL_TEXTURE_WIDTH, 
#endif

#if (GL_ES_VERSION_3_1 || GL_VERSION_1_0)
    Height = gl.Constants.GL_TEXTURE_HEIGHT, 
#endif

#if (GL_ES_VERSION_3_1 || GL_VERSION_1_1)
    InternalFormat = gl.Constants.GL_TEXTURE_INTERNAL_FORMAT, 
#endif

#if (GL_ES_VERSION_3_1 || GL_VERSION_1_1)
    RedSize = gl.Constants.GL_TEXTURE_RED_SIZE, 
#endif

#if (GL_ES_VERSION_3_1 || GL_VERSION_1_1)
    GreenSize = gl.Constants.GL_TEXTURE_GREEN_SIZE, 
#endif

#if (GL_ES_VERSION_3_1 || GL_VERSION_1_1)
    BlueSize = gl.Constants.GL_TEXTURE_BLUE_SIZE, 
#endif

#if (GL_ES_VERSION_3_1 || GL_VERSION_1_1)
    AlphaSize = gl.Constants.GL_TEXTURE_ALPHA_SIZE, 
#endif

#if (GL_ARB_STENCIL_TEXTURING || GL_ES_VERSION_3_1 || GL_VERSION_4_3)
    DepthStencilTextureMode = gl.Constants.GL_DEPTH_STENCIL_TEXTURE_MODE, 
#endif

#if (GL_ES_VERSION_3_2 || GL_VERSION_1_0)
    BorderColor = gl.Constants.GL_TEXTURE_BORDER_COLOR, 
#endif

#if GL_VERSION_1_0
    Components = gl.Constants.GL_TEXTURE_COMPONENTS, 
#endif

#if GL_VERSION_1_0
    Border = gl.Constants.GL_TEXTURE_BORDER, 
#endif

#if GL_VERSION_1_1
    LuminanceSize = gl.Constants.GL_TEXTURE_LUMINANCE_SIZE, 
#endif

#if GL_VERSION_1_1
    IntensitySize = gl.Constants.GL_TEXTURE_INTENSITY_SIZE, 
#endif

#if GL_VERSION_1_1
    Priority = gl.Constants.GL_TEXTURE_PRIORITY, 
#endif

#if GL_VERSION_1_1
    Resident = gl.Constants.GL_TEXTURE_RESIDENT, 
#endif

#if (GL_VERSION_1_4 || GL_VERSION_ES_CM_1_0)
    GenerateMipmap = gl.Constants.GL_GENERATE_MIPMAP, 
#endif

#if GL_VERSION_1_4
    LodBias = gl.Constants.GL_TEXTURE_LOD_BIAS, 
#endif

#if (GL_ARB_TEXTURE_SWIZZLE || GL_VERSION_3_3)
    SwizzleRgba = gl.Constants.GL_TEXTURE_SWIZZLE_RGBA, 
#endif

#if (GL_ARB_TEXTURE_FILTER_ANISOTROPIC || GL_VERSION_4_6)
    MaxAnisotropy = gl.Constants.GL_TEXTURE_MAX_ANISOTROPY, 
#endif

#if GL_ARM_TEXTURE_UNNORMALIZED_COORDINATES
    UnnormalizedCoordinatesArm = gl.Constants.GL_TEXTURE_UNNORMALIZED_COORDINATES_ARM, 
#endif

#if GL_EXT_MEMORY_OBJECT
    TilingExt = gl.Constants.GL_TEXTURE_TILING_EXT, 
#endif

#if GL_EXT_TEXTURE_OBJECT
    PriorityExt = gl.Constants.GL_TEXTURE_PRIORITY_EXT, 
#endif

#if GL_EXT_TEXTURE3D
    DepthExt = gl.Constants.GL_TEXTURE_DEPTH_EXT, 
#endif

#if GL_EXT_TEXTURE3D
    WrapRExt = gl.Constants.GL_TEXTURE_WRAP_R_EXT, 
#endif

#if GL_NV_TEXTURE_BORDER_CLAMP
    BorderColorNv = gl.Constants.GL_TEXTURE_BORDER_COLOR_NV, 
#endif

#if GL_OES_TEXTURE_3D
    WrapROes = gl.Constants.GL_TEXTURE_WRAP_R_OES, 
#endif

#if GL_QCOM_TEXTURE_FOVEATED2
    FoveatedCutoffDensityQcom = gl.Constants.GL_TEXTURE_FOVEATED_CUTOFF_DENSITY_QCOM, 
#endif

#if GL_SGIS_DETAIL_TEXTURE
    DetailTextureLevelSgis = gl.Constants.GL_DETAIL_TEXTURE_LEVEL_SGIS, 
#endif

#if GL_SGIS_DETAIL_TEXTURE
    DetailTextureModeSgis = gl.Constants.GL_DETAIL_TEXTURE_MODE_SGIS, 
#endif

#if GL_SGIS_DETAIL_TEXTURE
    DetailTextureFuncPointsSgis = gl.Constants.GL_DETAIL_TEXTURE_FUNC_POINTS_SGIS, 
#endif

#if GL_SGIS_GENERATE_MIPMAP
    GenerateMipmapSgis = gl.Constants.GL_GENERATE_MIPMAP_SGIS, 
#endif

#if GL_SGIS_SHARPEN_TEXTURE
    SharpenTextureFuncPointsSgis = gl.Constants.GL_SHARPEN_TEXTURE_FUNC_POINTS_SGIS, 
#endif

#if GL_SGIS_TEXTURE_FILTER4
    Filter4SizeSgis = gl.Constants.GL_TEXTURE_FILTER4_SIZE_SGIS, 
#endif

#if GL_SGIS_TEXTURE_LOD
    MinLodSgis = gl.Constants.GL_TEXTURE_MIN_LOD_SGIS, 
#endif

#if GL_SGIS_TEXTURE_LOD
    MaxLodSgis = gl.Constants.GL_TEXTURE_MAX_LOD_SGIS, 
#endif

#if GL_SGIS_TEXTURE_LOD
    BaseLevelSgis = gl.Constants.GL_TEXTURE_BASE_LEVEL_SGIS, 
#endif

#if GL_SGIS_TEXTURE_LOD
    MaxLevelSgis = gl.Constants.GL_TEXTURE_MAX_LEVEL_SGIS, 
#endif

#if GL_SGIS_TEXTURE_SELECT
    DualTextureSelectSgis = gl.Constants.GL_DUAL_TEXTURE_SELECT_SGIS, 
#endif

#if GL_SGIS_TEXTURE_SELECT
    QuadTextureSelectSgis = gl.Constants.GL_QUAD_TEXTURE_SELECT_SGIS, 
#endif

#if GL_SGIS_TEXTURE4D
    Texture4dsizeSgis = gl.Constants.GL_TEXTURE_4DSIZE_SGIS, 
#endif

#if GL_SGIS_TEXTURE4D
    WrapQSgis = gl.Constants.GL_TEXTURE_WRAP_Q_SGIS, 
#endif

#if GL_SGIX_CLIPMAP
    ClipmapCenterSgix = gl.Constants.GL_TEXTURE_CLIPMAP_CENTER_SGIX, 
#endif

#if GL_SGIX_CLIPMAP
    ClipmapFrameSgix = gl.Constants.GL_TEXTURE_CLIPMAP_FRAME_SGIX, 
#endif

#if GL_SGIX_CLIPMAP
    ClipmapOffsetSgix = gl.Constants.GL_TEXTURE_CLIPMAP_OFFSET_SGIX, 
#endif

#if GL_SGIX_CLIPMAP
    ClipmapVirtualDepthSgix = gl.Constants.GL_TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX, 
#endif

#if GL_SGIX_CLIPMAP
    ClipmapLodOffsetSgix = gl.Constants.GL_TEXTURE_CLIPMAP_LOD_OFFSET_SGIX, 
#endif

#if GL_SGIX_CLIPMAP
    ClipmapDepthSgix = gl.Constants.GL_TEXTURE_CLIPMAP_DEPTH_SGIX, 
#endif

#if GL_SGIX_SHADOW
    CompareSgix = gl.Constants.GL_TEXTURE_COMPARE_SGIX, 
#endif

#if GL_SGIX_SHADOW
    CompareOperatorSgix = gl.Constants.GL_TEXTURE_COMPARE_OPERATOR_SGIX, 
#endif

#if GL_SGIX_SHADOW
    LequalRSgix = gl.Constants.GL_TEXTURE_LEQUAL_R_SGIX, 
#endif

#if GL_SGIX_SHADOW
    GequalRSgix = gl.Constants.GL_TEXTURE_GEQUAL_R_SGIX, 
#endif

#if GL_SGIX_SHADOW_AMBIENT
    ShadowAmbientSgix = gl.Constants.GL_SHADOW_AMBIENT_SGIX, 
#endif

#if GL_SGIX_TEXTURE_COORDINATE_CLAMP
    MaxClampSSgix = gl.Constants.GL_TEXTURE_MAX_CLAMP_S_SGIX, 
#endif

#if GL_SGIX_TEXTURE_COORDINATE_CLAMP
    MaxClampTSgix = gl.Constants.GL_TEXTURE_MAX_CLAMP_T_SGIX, 
#endif

#if GL_SGIX_TEXTURE_COORDINATE_CLAMP
    MaxClampRSgix = gl.Constants.GL_TEXTURE_MAX_CLAMP_R_SGIX, 
#endif

#if GL_SGIX_TEXTURE_LOD_BIAS
    LodBiasSSgix = gl.Constants.GL_TEXTURE_LOD_BIAS_S_SGIX, 
#endif

#if GL_SGIX_TEXTURE_LOD_BIAS
    LodBiasTSgix = gl.Constants.GL_TEXTURE_LOD_BIAS_T_SGIX, 
#endif

#if GL_SGIX_TEXTURE_LOD_BIAS
    LodBiasRSgix = gl.Constants.GL_TEXTURE_LOD_BIAS_R_SGIX, 
#endif

#if GL_SGIX_TEXTURE_SCALE_BIAS
    PostTextureFilterBiasSgix = gl.Constants.GL_POST_TEXTURE_FILTER_BIAS_SGIX, 
#endif

#if GL_SGIX_TEXTURE_SCALE_BIAS
    PostTextureFilterScaleSgix = gl.Constants.GL_POST_TEXTURE_FILTER_SCALE_SGIX, 
#endif

}

#endif
