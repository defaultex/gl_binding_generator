#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0 || GL_ES_VERSION_3_1 || GL_VERSION_1_1 || GL_ES_VERSION_3_2 || GL_ARM_TEXTURE_UNNORMALIZED_COORDINATES || GL_EXT_EGL_IMAGE_STORAGE_COMPRESSION || GL_EXT_TEXTURE_STORAGE_COMPRESSION || GL_EXT_TEXTURE3D || GL_NV_TEXTURE_BORDER_CLAMP || GL_SGIS_DETAIL_TEXTURE || GL_SGIS_GENERATE_MIPMAP || GL_SGIS_SHARPEN_TEXTURE || GL_SGIS_TEXTURE_FILTER4 || GL_SGIS_TEXTURE_LOD || GL_SGIS_TEXTURE_SELECT || GL_SGIS_TEXTURE4D || GL_SGIX_CLIPMAP || GL_SGIX_SHADOW || GL_SGIX_SHADOW_AMBIENT || GL_SGIX_TEXTURE_COORDINATE_CLAMP || GL_SGIX_TEXTURE_LOD_BIAS || GL_SGIX_TEXTURE_SCALE_BIAS)

public enum GetTextureParameter : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    TextureMagFilter = gl.Constants.GL_TEXTURE_MAG_FILTER, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    TextureMinFilter = gl.Constants.GL_TEXTURE_MIN_FILTER, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    TextureWrapS = gl.Constants.GL_TEXTURE_WRAP_S, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_0 || GL_VERSION_ES_CM_1_0)
    TextureWrapT = gl.Constants.GL_TEXTURE_WRAP_T, 
#endif

#if (GL_ES_VERSION_3_1 || GL_VERSION_1_0)
    TextureWidth = gl.Constants.GL_TEXTURE_WIDTH, 
#endif

#if (GL_ES_VERSION_3_1 || GL_VERSION_1_0)
    TextureHeight = gl.Constants.GL_TEXTURE_HEIGHT, 
#endif

#if (GL_ES_VERSION_3_1 || GL_VERSION_1_1)
    TextureInternalFormat = gl.Constants.GL_TEXTURE_INTERNAL_FORMAT, 
#endif

#if (GL_ES_VERSION_3_1 || GL_VERSION_1_1)
    TextureRedSize = gl.Constants.GL_TEXTURE_RED_SIZE, 
#endif

#if (GL_ES_VERSION_3_1 || GL_VERSION_1_1)
    TextureGreenSize = gl.Constants.GL_TEXTURE_GREEN_SIZE, 
#endif

#if (GL_ES_VERSION_3_1 || GL_VERSION_1_1)
    TextureBlueSize = gl.Constants.GL_TEXTURE_BLUE_SIZE, 
#endif

#if (GL_ES_VERSION_3_1 || GL_VERSION_1_1)
    TextureAlphaSize = gl.Constants.GL_TEXTURE_ALPHA_SIZE, 
#endif

#if (GL_ES_VERSION_3_2 || GL_VERSION_1_0)
    TextureBorderColor = gl.Constants.GL_TEXTURE_BORDER_COLOR, 
#endif

#if GL_VERSION_1_0
    TextureComponents = gl.Constants.GL_TEXTURE_COMPONENTS, 
#endif

#if GL_VERSION_1_0
    TextureBorder = gl.Constants.GL_TEXTURE_BORDER, 
#endif

#if GL_VERSION_1_1
    TextureLuminanceSize = gl.Constants.GL_TEXTURE_LUMINANCE_SIZE, 
#endif

#if GL_VERSION_1_1
    TextureIntensitySize = gl.Constants.GL_TEXTURE_INTENSITY_SIZE, 
#endif

#if GL_VERSION_1_1
    TexturePriority = gl.Constants.GL_TEXTURE_PRIORITY, 
#endif

#if GL_VERSION_1_1
    TextureResident = gl.Constants.GL_TEXTURE_RESIDENT, 
#endif

#if GL_ARM_TEXTURE_UNNORMALIZED_COORDINATES
    TextureUnnormalizedCoordinatesArm = gl.Constants.GL_TEXTURE_UNNORMALIZED_COORDINATES_ARM, 
#endif

#if (GL_EXT_EGL_IMAGE_STORAGE_COMPRESSION || GL_EXT_TEXTURE_STORAGE_COMPRESSION)
    SurfaceCompressionExt = gl.Constants.GL_SURFACE_COMPRESSION_EXT, 
#endif

#if GL_EXT_TEXTURE3D
    TextureDepthExt = gl.Constants.GL_TEXTURE_DEPTH_EXT, 
#endif

#if GL_EXT_TEXTURE3D
    TextureWrapRExt = gl.Constants.GL_TEXTURE_WRAP_R_EXT, 
#endif

#if GL_NV_TEXTURE_BORDER_CLAMP
    TextureBorderColorNv = gl.Constants.GL_TEXTURE_BORDER_COLOR_NV, 
#endif

#if GL_SGIS_DETAIL_TEXTURE
    DetailLevelSgis = gl.Constants.GL_DETAIL_TEXTURE_LEVEL_SGIS, 
#endif

#if GL_SGIS_DETAIL_TEXTURE
    DetailModeSgis = gl.Constants.GL_DETAIL_TEXTURE_MODE_SGIS, 
#endif

#if GL_SGIS_DETAIL_TEXTURE
    DetailFuncPointsSgis = gl.Constants.GL_DETAIL_TEXTURE_FUNC_POINTS_SGIS, 
#endif

#if GL_SGIS_GENERATE_MIPMAP
    GenerateMipmapSgis = gl.Constants.GL_GENERATE_MIPMAP_SGIS, 
#endif

#if GL_SGIS_SHARPEN_TEXTURE
    SharpenFuncPointsSgis = gl.Constants.GL_SHARPEN_TEXTURE_FUNC_POINTS_SGIS, 
#endif

#if GL_SGIS_TEXTURE_FILTER4
    TextureFilter4SizeSgis = gl.Constants.GL_TEXTURE_FILTER4_SIZE_SGIS, 
#endif

#if GL_SGIS_TEXTURE_LOD
    TextureMinLodSgis = gl.Constants.GL_TEXTURE_MIN_LOD_SGIS, 
#endif

#if GL_SGIS_TEXTURE_LOD
    TextureMaxLodSgis = gl.Constants.GL_TEXTURE_MAX_LOD_SGIS, 
#endif

#if GL_SGIS_TEXTURE_LOD
    TextureBaseLevelSgis = gl.Constants.GL_TEXTURE_BASE_LEVEL_SGIS, 
#endif

#if GL_SGIS_TEXTURE_LOD
    TextureMaxLevelSgis = gl.Constants.GL_TEXTURE_MAX_LEVEL_SGIS, 
#endif

#if GL_SGIS_TEXTURE_SELECT
    DualSelectSgis = gl.Constants.GL_DUAL_TEXTURE_SELECT_SGIS, 
#endif

#if GL_SGIS_TEXTURE_SELECT
    QuadSelectSgis = gl.Constants.GL_QUAD_TEXTURE_SELECT_SGIS, 
#endif

#if GL_SGIS_TEXTURE4D
    Texture4dsizeSgis = gl.Constants.GL_TEXTURE_4DSIZE_SGIS, 
#endif

#if GL_SGIS_TEXTURE4D
    TextureWrapQSgis = gl.Constants.GL_TEXTURE_WRAP_Q_SGIS, 
#endif

#if GL_SGIX_CLIPMAP
    TextureClipmapCenterSgix = gl.Constants.GL_TEXTURE_CLIPMAP_CENTER_SGIX, 
#endif

#if GL_SGIX_CLIPMAP
    TextureClipmapFrameSgix = gl.Constants.GL_TEXTURE_CLIPMAP_FRAME_SGIX, 
#endif

#if GL_SGIX_CLIPMAP
    TextureClipmapOffsetSgix = gl.Constants.GL_TEXTURE_CLIPMAP_OFFSET_SGIX, 
#endif

#if GL_SGIX_CLIPMAP
    TextureClipmapVirtualDepthSgix = gl.Constants.GL_TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX, 
#endif

#if GL_SGIX_CLIPMAP
    TextureClipmapLodOffsetSgix = gl.Constants.GL_TEXTURE_CLIPMAP_LOD_OFFSET_SGIX, 
#endif

#if GL_SGIX_CLIPMAP
    TextureClipmapDepthSgix = gl.Constants.GL_TEXTURE_CLIPMAP_DEPTH_SGIX, 
#endif

#if GL_SGIX_SHADOW
    TextureCompareSgix = gl.Constants.GL_TEXTURE_COMPARE_SGIX, 
#endif

#if GL_SGIX_SHADOW
    TextureCompareOperatorSgix = gl.Constants.GL_TEXTURE_COMPARE_OPERATOR_SGIX, 
#endif

#if GL_SGIX_SHADOW
    TextureLequalRSgix = gl.Constants.GL_TEXTURE_LEQUAL_R_SGIX, 
#endif

#if GL_SGIX_SHADOW
    TextureGequalRSgix = gl.Constants.GL_TEXTURE_GEQUAL_R_SGIX, 
#endif

#if GL_SGIX_SHADOW_AMBIENT
    ShadowAmbientSgix = gl.Constants.GL_SHADOW_AMBIENT_SGIX, 
#endif

#if GL_SGIX_TEXTURE_COORDINATE_CLAMP
    TextureMaxClampSSgix = gl.Constants.GL_TEXTURE_MAX_CLAMP_S_SGIX, 
#endif

#if GL_SGIX_TEXTURE_COORDINATE_CLAMP
    TextureMaxClampTSgix = gl.Constants.GL_TEXTURE_MAX_CLAMP_T_SGIX, 
#endif

#if GL_SGIX_TEXTURE_COORDINATE_CLAMP
    TextureMaxClampRSgix = gl.Constants.GL_TEXTURE_MAX_CLAMP_R_SGIX, 
#endif

#if GL_SGIX_TEXTURE_LOD_BIAS
    TextureLodBiasSSgix = gl.Constants.GL_TEXTURE_LOD_BIAS_S_SGIX, 
#endif

#if GL_SGIX_TEXTURE_LOD_BIAS
    TextureLodBiasTSgix = gl.Constants.GL_TEXTURE_LOD_BIAS_T_SGIX, 
#endif

#if GL_SGIX_TEXTURE_LOD_BIAS
    TextureLodBiasRSgix = gl.Constants.GL_TEXTURE_LOD_BIAS_R_SGIX, 
#endif

#if GL_SGIX_TEXTURE_SCALE_BIAS
    PostFilterBiasSgix = gl.Constants.GL_POST_TEXTURE_FILTER_BIAS_SGIX, 
#endif

#if GL_SGIX_TEXTURE_SCALE_BIAS
    PostFilterScaleSgix = gl.Constants.GL_POST_TEXTURE_FILTER_SCALE_SGIX, 
#endif

}

#endif
