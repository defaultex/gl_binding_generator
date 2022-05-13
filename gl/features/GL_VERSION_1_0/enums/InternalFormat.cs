public enum InternalFormat : GLenum {
    StencilIndex = gl.Constants.GL_STENCIL_INDEX,
    DepthComponent = gl.Constants.GL_DEPTH_COMPONENT,
    Red = gl.Constants.GL_RED,
    Rgb = gl.Constants.GL_RGB,
    Rgba = gl.Constants.GL_RGBA,
    R3G3B2 = gl.Constants.GL_R3_G3_B2,
    Rgb4 = gl.Constants.GL_RGB4,
    Rgb5 = gl.Constants.GL_RGB5,
    Rgb8 = gl.Constants.GL_RGB8,
    Rgb10 = gl.Constants.GL_RGB10,
    Rgb12 = gl.Constants.GL_RGB12,
    Rgb16 = gl.Constants.GL_RGB16,
    Rgba2 = gl.Constants.GL_RGBA2,
    Rgba4 = gl.Constants.GL_RGBA4,
    Rgb5A1 = gl.Constants.GL_RGB5_A1,
    Rgba8 = gl.Constants.GL_RGBA8,
    Rgb10A2 = gl.Constants.GL_RGB10_A2,
    Rgba12 = gl.Constants.GL_RGBA12,
    Rgba16 = gl.Constants.GL_RGBA16,
    CompressedRgb = gl.Constants.GL_COMPRESSED_RGB,
    CompressedRgba = gl.Constants.GL_COMPRESSED_RGBA,
    DepthComponent16 = gl.Constants.GL_DEPTH_COMPONENT16,
    DepthComponent24 = gl.Constants.GL_DEPTH_COMPONENT24,
    DepthComponent32 = gl.Constants.GL_DEPTH_COMPONENT32,
    Srgb = gl.Constants.GL_SRGB,
    Srgb8 = gl.Constants.GL_SRGB8,
    SrgbAlpha = gl.Constants.GL_SRGB_ALPHA,
    Srgb8Alpha8 = gl.Constants.GL_SRGB8_ALPHA8,
    CompressedSrgb = gl.Constants.GL_COMPRESSED_SRGB,
    CompressedSrgbAlpha = gl.Constants.GL_COMPRESSED_SRGB_ALPHA,
    CompressedRed = gl.Constants.GL_COMPRESSED_RED,
    CompressedRg = gl.Constants.GL_COMPRESSED_RG,
    Rgba32f = gl.Constants.GL_RGBA32F,
    Rgb32f = gl.Constants.GL_RGB32F,
    Rgba16f = gl.Constants.GL_RGBA16F,
    Rgb16f = gl.Constants.GL_RGB16F,
    R11fG11fB10f = gl.Constants.GL_R11F_G11F_B10F,
    Rgb9E5 = gl.Constants.GL_RGB9_E5,
    Rgba32ui = gl.Constants.GL_RGBA32UI,
    Rgb32ui = gl.Constants.GL_RGB32UI,
    Rgba16ui = gl.Constants.GL_RGBA16UI,
    Rgb16ui = gl.Constants.GL_RGB16UI,
    Rgba8ui = gl.Constants.GL_RGBA8UI,
    Rgb8ui = gl.Constants.GL_RGB8UI,
    Rgba32i = gl.Constants.GL_RGBA32I,
    Rgb32i = gl.Constants.GL_RGB32I,
    Rgba16i = gl.Constants.GL_RGBA16I,
    Rgb16i = gl.Constants.GL_RGB16I,
    Rgba8i = gl.Constants.GL_RGBA8I,
    Rgb8i = gl.Constants.GL_RGB8I,
    DepthComponent32f = gl.Constants.GL_DEPTH_COMPONENT32F,
    Depth32fStencil8 = gl.Constants.GL_DEPTH32F_STENCIL8,
    DepthStencil = gl.Constants.GL_DEPTH_STENCIL,
    Depth24Stencil8 = gl.Constants.GL_DEPTH24_STENCIL8,
    StencilIndex1 = gl.Constants.GL_STENCIL_INDEX1,
    StencilIndex4 = gl.Constants.GL_STENCIL_INDEX4,
    StencilIndex8 = gl.Constants.GL_STENCIL_INDEX8,
    StencilIndex16 = gl.Constants.GL_STENCIL_INDEX16,
    CompressedRedRgtc1 = gl.Constants.GL_COMPRESSED_RED_RGTC1,
    CompressedSignedRedRgtc1 = gl.Constants.GL_COMPRESSED_SIGNED_RED_RGTC1,
    CompressedRgRgtc2 = gl.Constants.GL_COMPRESSED_RG_RGTC2,
    CompressedSignedRgRgtc2 = gl.Constants.GL_COMPRESSED_SIGNED_RG_RGTC2,
    Rg = gl.Constants.GL_RG,
    R8 = gl.Constants.GL_R8,
    R16 = gl.Constants.GL_R16,
    Rg8 = gl.Constants.GL_RG8,
    Rg16 = gl.Constants.GL_RG16,
    R16f = gl.Constants.GL_R16F,
    R32f = gl.Constants.GL_R32F,
    Rg16f = gl.Constants.GL_RG16F,
    Rg32f = gl.Constants.GL_RG32F,
    R8i = gl.Constants.GL_R8I,
    R8ui = gl.Constants.GL_R8UI,
    R16i = gl.Constants.GL_R16I,
    R16ui = gl.Constants.GL_R16UI,
    R32i = gl.Constants.GL_R32I,
    R32ui = gl.Constants.GL_R32UI,
    Rg8i = gl.Constants.GL_RG8I,
    Rg8ui = gl.Constants.GL_RG8UI,
    Rg16i = gl.Constants.GL_RG16I,
    Rg16ui = gl.Constants.GL_RG16UI,
    Rg32i = gl.Constants.GL_RG32I,
    Rg32ui = gl.Constants.GL_RG32UI,
    R8Snorm = gl.Constants.GL_R8_SNORM,
    Rg8Snorm = gl.Constants.GL_RG8_SNORM,
    Rgb8Snorm = gl.Constants.GL_RGB8_SNORM,
    Rgba8Snorm = gl.Constants.GL_RGBA8_SNORM,
    R16Snorm = gl.Constants.GL_R16_SNORM,
    Rg16Snorm = gl.Constants.GL_RG16_SNORM,
    Rgb16Snorm = gl.Constants.GL_RGB16_SNORM,
    Rgba16Snorm = gl.Constants.GL_RGBA16_SNORM,
    Rgb10A2ui = gl.Constants.GL_RGB10_A2UI,
    Rgb565 = gl.Constants.GL_RGB565,
    CompressedRgbaBptcUnorm = gl.Constants.GL_COMPRESSED_RGBA_BPTC_UNORM,
    CompressedSrgbAlphaBptcUnorm = gl.Constants.GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM,
    CompressedRgbBptcSignedFloat = gl.Constants.GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT,
    CompressedRgbBptcUnsignedFloat = gl.Constants.GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT,
    CompressedRgb8Etc2 = gl.Constants.GL_COMPRESSED_RGB8_ETC2,
    CompressedSrgb8Etc2 = gl.Constants.GL_COMPRESSED_SRGB8_ETC2,
    CompressedRgb8PunchthroughAlpha1Etc2 = gl.Constants.GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2,
    CompressedSrgb8PunchthroughAlpha1Etc2 = gl.Constants.GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2,
    CompressedRgba8Etc2Eac = gl.Constants.GL_COMPRESSED_RGBA8_ETC2_EAC,
    CompressedSrgb8Alpha8Etc2Eac = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC,
    CompressedR11Eac = gl.Constants.GL_COMPRESSED_R11_EAC,
    CompressedSignedR11Eac = gl.Constants.GL_COMPRESSED_SIGNED_R11_EAC,
    CompressedRg11Eac = gl.Constants.GL_COMPRESSED_RG11_EAC,
    CompressedSignedRg11Eac = gl.Constants.GL_COMPRESSED_SIGNED_RG11_EAC,
#if GL_ARB_texture_compression_bptc
    CompressedRgbaBptcUnormArb = gl.Constants.GL_COMPRESSED_RGBA_BPTC_UNORM_ARB,
#endif

#if GL_ARB_texture_compression_bptc
    CompressedSrgbAlphaBptcUnormArb = gl.Constants.GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM_ARB,
#endif

#if GL_ARB_texture_compression_bptc
    CompressedRgbBptcSignedFloatArb = gl.Constants.GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT_ARB,
#endif

#if GL_ARB_texture_compression_bptc
    CompressedRgbBptcUnsignedFloatArb = gl.Constants.GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_ARB,
#endif

#if GL_EXT_texture_compression_s3tc
    CompressedRgbS3tcDxt1Ext = gl.Constants.GL_COMPRESSED_RGB_S3TC_DXT1_EXT,
#endif

#if GL_EXT_texture_compression_s3tc
    CompressedRgbaS3tcDxt1Ext = gl.Constants.GL_COMPRESSED_RGBA_S3TC_DXT1_EXT,
#endif

#if GL_EXT_texture_compression_s3tc
    CompressedRgbaS3tcDxt3Ext = gl.Constants.GL_COMPRESSED_RGBA_S3TC_DXT3_EXT,
#endif

#if GL_EXT_texture_compression_s3tc
    CompressedRgbaS3tcDxt5Ext = gl.Constants.GL_COMPRESSED_RGBA_S3TC_DXT5_EXT,
#endif

#if GL_EXT_texture_sRGB_R8
    Sr8Ext = gl.Constants.GL_SR8_EXT,
#endif

#if GL_EXT_texture_sRGB_RG8
    Srg8Ext = gl.Constants.GL_SRG8_EXT,
#endif

#if GL_EXT_texture_storage
    Alpha8Ext = gl.Constants.GL_ALPHA8_EXT,
#endif

#if GL_EXT_texture_storage
    Luminance8Ext = gl.Constants.GL_LUMINANCE8_EXT,
#endif

#if GL_EXT_texture_storage
    Luminance8Alpha8Ext = gl.Constants.GL_LUMINANCE8_ALPHA8_EXT,
#endif

#if GL_EXT_texture_storage
    Rgba32fExt = gl.Constants.GL_RGBA32F_EXT,
#endif

#if GL_EXT_texture_storage
    Rgb32fExt = gl.Constants.GL_RGB32F_EXT,
#endif

#if GL_EXT_texture_storage
    Rgba16fExt = gl.Constants.GL_RGBA16F_EXT,
#endif

#if GL_EXT_texture_storage
    Rgb16fExt = gl.Constants.GL_RGB16F_EXT,
#endif

#if GL_EXT_texture_storage
    Rgb10A2Ext = gl.Constants.GL_RGB10_A2_EXT,
#endif

#if GL_EXT_texture_storage
    Rgb10Ext = gl.Constants.GL_RGB10_EXT,
#endif

#if GL_EXT_texture_storage
    R8Ext = gl.Constants.GL_R8_EXT,
#endif

#if GL_EXT_texture_storage
    Rg8Ext = gl.Constants.GL_RG8_EXT,
#endif

#if GL_EXT_texture_storage
    R32fExt = gl.Constants.GL_R32F_EXT,
#endif

#if GL_EXT_texture_storage
    Rg32fExt = gl.Constants.GL_RG32F_EXT,
#endif

#if GL_EXT_texture_storage
    R16fExt = gl.Constants.GL_R16F_EXT,
#endif

#if GL_EXT_texture_storage
    Rg16fExt = gl.Constants.GL_RG16F_EXT,
#endif

#if GL_KHR_texture_compression_astc_hdr
    CompressedRgbaAstc4x4Khr = gl.Constants.GL_COMPRESSED_RGBA_ASTC_4x4_KHR,
#endif

#if GL_KHR_texture_compression_astc_hdr
    CompressedRgbaAstc5x4Khr = gl.Constants.GL_COMPRESSED_RGBA_ASTC_5x4_KHR,
#endif

#if GL_KHR_texture_compression_astc_hdr
    CompressedRgbaAstc5x5Khr = gl.Constants.GL_COMPRESSED_RGBA_ASTC_5x5_KHR,
#endif

#if GL_KHR_texture_compression_astc_hdr
    CompressedRgbaAstc6x5Khr = gl.Constants.GL_COMPRESSED_RGBA_ASTC_6x5_KHR,
#endif

#if GL_KHR_texture_compression_astc_hdr
    CompressedRgbaAstc6x6Khr = gl.Constants.GL_COMPRESSED_RGBA_ASTC_6x6_KHR,
#endif

#if GL_KHR_texture_compression_astc_hdr
    CompressedRgbaAstc8x5Khr = gl.Constants.GL_COMPRESSED_RGBA_ASTC_8x5_KHR,
#endif

#if GL_KHR_texture_compression_astc_hdr
    CompressedRgbaAstc8x6Khr = gl.Constants.GL_COMPRESSED_RGBA_ASTC_8x6_KHR,
#endif

#if GL_KHR_texture_compression_astc_hdr
    CompressedRgbaAstc8x8Khr = gl.Constants.GL_COMPRESSED_RGBA_ASTC_8x8_KHR,
#endif

#if GL_KHR_texture_compression_astc_hdr
    CompressedRgbaAstc10x5Khr = gl.Constants.GL_COMPRESSED_RGBA_ASTC_10x5_KHR,
#endif

#if GL_KHR_texture_compression_astc_hdr
    CompressedRgbaAstc10x6Khr = gl.Constants.GL_COMPRESSED_RGBA_ASTC_10x6_KHR,
#endif

#if GL_KHR_texture_compression_astc_hdr
    CompressedRgbaAstc10x8Khr = gl.Constants.GL_COMPRESSED_RGBA_ASTC_10x8_KHR,
#endif

#if GL_KHR_texture_compression_astc_hdr
    CompressedRgbaAstc10x10Khr = gl.Constants.GL_COMPRESSED_RGBA_ASTC_10x10_KHR,
#endif

#if GL_KHR_texture_compression_astc_hdr
    CompressedRgbaAstc12x10Khr = gl.Constants.GL_COMPRESSED_RGBA_ASTC_12x10_KHR,
#endif

#if GL_KHR_texture_compression_astc_hdr
    CompressedRgbaAstc12x12Khr = gl.Constants.GL_COMPRESSED_RGBA_ASTC_12x12_KHR,
#endif

#if GL_KHR_texture_compression_astc_hdr
    CompressedSrgb8Alpha8Astc4x4Khr = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR,
#endif

#if GL_KHR_texture_compression_astc_hdr
    CompressedSrgb8Alpha8Astc5x4Khr = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4_KHR,
#endif

#if GL_KHR_texture_compression_astc_hdr
    CompressedSrgb8Alpha8Astc5x5Khr = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5_KHR,
#endif

#if GL_KHR_texture_compression_astc_hdr
    CompressedSrgb8Alpha8Astc6x5Khr = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5_KHR,
#endif

#if GL_KHR_texture_compression_astc_hdr
    CompressedSrgb8Alpha8Astc6x6Khr = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6_KHR,
#endif

#if GL_KHR_texture_compression_astc_hdr
    CompressedSrgb8Alpha8Astc8x5Khr = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x5_KHR,
#endif

#if GL_KHR_texture_compression_astc_hdr
    CompressedSrgb8Alpha8Astc8x6Khr = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x6_KHR,
#endif

#if GL_KHR_texture_compression_astc_hdr
    CompressedSrgb8Alpha8Astc8x8Khr = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x8_KHR,
#endif

#if GL_KHR_texture_compression_astc_hdr
    CompressedSrgb8Alpha8Astc10x5Khr = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x5_KHR,
#endif

#if GL_KHR_texture_compression_astc_hdr
    CompressedSrgb8Alpha8Astc10x6Khr = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x6_KHR,
#endif

#if GL_KHR_texture_compression_astc_hdr
    CompressedSrgb8Alpha8Astc10x8Khr = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x8_KHR,
#endif

#if GL_KHR_texture_compression_astc_hdr
    CompressedSrgb8Alpha8Astc10x10Khr = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x10_KHR,
#endif

#if GL_KHR_texture_compression_astc_hdr
    CompressedSrgb8Alpha8Astc12x10Khr = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x10_KHR,
#endif

#if GL_KHR_texture_compression_astc_hdr
    CompressedSrgb8Alpha8Astc12x12Khr = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x12_KHR,
#endif

#if GL_NV_depth_buffer_float
    DepthComponent32fNv = gl.Constants.GL_DEPTH_COMPONENT32F_NV,
#endif

#if GL_NV_depth_buffer_float
    Depth32fStencil8Nv = gl.Constants.GL_DEPTH32F_STENCIL8_NV,
#endif
}
