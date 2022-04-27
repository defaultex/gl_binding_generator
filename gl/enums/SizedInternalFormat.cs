#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_1 || GL_ANGLE_DEPTH_TEXTURE || GL_VERSION_1_4 || GL_ARB_FRAMEBUFFER_OBJECT || GL_ARB_TEXTURE_STENCIL8 || GL_ES_VERSION_3_2 || GL_VERSION_3_0 || GL_VERSION_4_4 || GL_ARB_ES2_COMPATIBILITY || GL_VERSION_4_1 || GL_ES_VERSION_3_0 || GL_ARB_TEXTURE_RG || GL_AMD_INTERLEAVED_ELEMENTS || GL_ARB_TEXTURE_BUFFER_OBJECT_RGB32 || GL_VERSION_2_1 || GL_ARB_DEPTH_BUFFER_FLOAT || GL_ARB_VERTEX_ATTRIB_64BIT || GL_EXT_RENDER_SNORM || GL_EXT_TEXTURE_SNORM || GL_VERSION_3_1 || GL_ARB_TEXTURE_RGB10_A2UI || GL_VERSION_3_3 || GL_ARB_ES3_COMPATIBILITY || GL_VERSION_4_3 || GL_ARB_TEXTURE_COMPRESSION_RGTC || GL_VERSION_4_2 || GL_OES_DEPTH32 || GL_OES_REQUIRED_INTERNALFORMAT || GL_OES_PACKED_DEPTH_STENCIL || GL_ANGLE_TEXTURE_COMPRESSION_DXT3 || GL_ANGLE_TEXTURE_COMPRESSION_DXT5 || GL_APPLE_TEXTURE_PACKED_FLOAT || GL_ARB_DEPTH_TEXTURE || GL_ARB_TEXTURE_COMPRESSION_BPTC || GL_ARB_TEXTURE_FLOAT || GL_EXT_COLOR_BUFFER_HALF_FLOAT || GL_EXT_TEXTURE_STORAGE || GL_EXT_FRAMEBUFFER_OBJECT || GL_EXT_PACKED_DEPTH_STENCIL || GL_EXT_PACKED_FLOAT || GL_EXT_TEXTURE_NORM16 || GL_EXT_SRGB || GL_EXT_TEXTURE_SRGB || GL_EXT_TEXTURE || GL_EXT_TEXTURE_COMPRESSION_BPTC || GL_EXT_TEXTURE_COMPRESSION_DXT1 || GL_EXT_TEXTURE_COMPRESSION_S3TC || GL_EXT_TEXTURE_COMPRESSION_RGTC || GL_EXT_TEXTURE_COMPRESSION_S3TC_SRGB || GL_EXT_TEXTURE_INTEGER || GL_EXT_TEXTURE_RG || GL_EXT_TEXTURE_SHARED_EXPONENT || GL_KHR_TEXTURE_COMPRESSION_ASTC_HDR || GL_KHR_TEXTURE_COMPRESSION_ASTC_LDR || GL_OES_TEXTURE_COMPRESSION_ASTC || GL_NV_DEPTH_BUFFER_FLOAT || GL_NV_SRGB_FORMATS || GL_OES_COMPRESSED_ETC1_RGB8_TEXTURE || GL_OES_DEPTH24 || GL_OES_FRAMEBUFFER_OBJECT || GL_OES_RGB8_RGBA8 || GL_OES_STENCIL1 || GL_OES_STENCIL4 || GL_OES_STENCIL8 || GL_OES_TEXTURE_STENCIL8 || GL_SGIX_DEPTH_TEXTURE)

public enum SizedInternalFormat : GLenum { 
#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_1)
    Rgba4 = gl.Constants.GL_RGBA4, 
#endif

#if (GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_1)
    Rgb5A1 = gl.Constants.GL_RGB5_A1, 
#endif

#if (GL_ANGLE_DEPTH_TEXTURE || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_4)
    DepthComponent16 = gl.Constants.GL_DEPTH_COMPONENT16, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ARB_TEXTURE_STENCIL8 || GL_ES_VERSION_2_0 || GL_ES_VERSION_3_2 || GL_SC_VERSION_2_0 || GL_VERSION_3_0 || GL_VERSION_4_4)
    StencilIndex8 = gl.Constants.GL_STENCIL_INDEX8, 
#endif

#if (GL_ARB_ES2_COMPATIBILITY || GL_ES_VERSION_2_0 || GL_SC_VERSION_2_0 || GL_VERSION_4_1)
    Rgb565 = gl.Constants.GL_RGB565, 
#endif

#if (GL_ES_VERSION_3_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_1)
    Rgb8 = gl.Constants.GL_RGB8, 
#endif

#if (GL_ES_VERSION_3_0 || GL_SC_VERSION_2_0 || GL_VERSION_1_1)
    Rgba8 = gl.Constants.GL_RGBA8, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_1)
    Rgb10A2 = gl.Constants.GL_RGB10_A2, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_1_4)
    DepthComponent24 = gl.Constants.GL_DEPTH_COMPONENT24, 
#endif

#if (GL_ARB_TEXTURE_RG || GL_ES_VERSION_3_0 || GL_SC_VERSION_2_0 || GL_VERSION_3_0)
    R8 = gl.Constants.GL_R8, 
#endif

#if (GL_ARB_TEXTURE_RG || GL_ES_VERSION_3_0 || GL_SC_VERSION_2_0 || GL_VERSION_3_0)
    Rg8 = gl.Constants.GL_RG8, 
#endif

#if (GL_ARB_TEXTURE_RG || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    R16f = gl.Constants.GL_R16F, 
#endif

#if (GL_ARB_TEXTURE_RG || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    R32f = gl.Constants.GL_R32F, 
#endif

#if (GL_ARB_TEXTURE_RG || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Rg16f = gl.Constants.GL_RG16F, 
#endif

#if (GL_ARB_TEXTURE_RG || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Rg32f = gl.Constants.GL_RG32F, 
#endif

#if (GL_ARB_TEXTURE_RG || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    R8i = gl.Constants.GL_R8I, 
#endif

#if (GL_ARB_TEXTURE_RG || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    R8ui = gl.Constants.GL_R8UI, 
#endif

#if (GL_ARB_TEXTURE_RG || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    R16i = gl.Constants.GL_R16I, 
#endif

#if (GL_ARB_TEXTURE_RG || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    R16ui = gl.Constants.GL_R16UI, 
#endif

#if (GL_ARB_TEXTURE_RG || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    R32i = gl.Constants.GL_R32I, 
#endif

#if (GL_ARB_TEXTURE_RG || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    R32ui = gl.Constants.GL_R32UI, 
#endif

#if (GL_ARB_TEXTURE_RG || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Rg8i = gl.Constants.GL_RG8I, 
#endif

#if (GL_AMD_INTERLEAVED_ELEMENTS || GL_ARB_TEXTURE_RG || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Rg8ui = gl.Constants.GL_RG8UI, 
#endif

#if (GL_ARB_TEXTURE_RG || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Rg16i = gl.Constants.GL_RG16I, 
#endif

#if (GL_AMD_INTERLEAVED_ELEMENTS || GL_ARB_TEXTURE_RG || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Rg16ui = gl.Constants.GL_RG16UI, 
#endif

#if (GL_ARB_TEXTURE_RG || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Rg32i = gl.Constants.GL_RG32I, 
#endif

#if (GL_ARB_TEXTURE_RG || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Rg32ui = gl.Constants.GL_RG32UI, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Rgba32f = gl.Constants.GL_RGBA32F, 
#endif

#if (GL_ARB_TEXTURE_BUFFER_OBJECT_RGB32 || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Rgb32f = gl.Constants.GL_RGB32F, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Rgba16f = gl.Constants.GL_RGBA16F, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Rgb16f = gl.Constants.GL_RGB16F, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Depth24Stencil8 = gl.Constants.GL_DEPTH24_STENCIL8, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    R11fG11fB10f = gl.Constants.GL_R11F_G11F_B10F, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Rgb9E5 = gl.Constants.GL_RGB9_E5, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_2_1)
    Srgb8 = gl.Constants.GL_SRGB8, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_2_1)
    Srgb8Alpha8 = gl.Constants.GL_SRGB8_ALPHA8, 
#endif

#if (GL_ARB_DEPTH_BUFFER_FLOAT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    DepthComponent32f = gl.Constants.GL_DEPTH_COMPONENT32F, 
#endif

#if (GL_ARB_DEPTH_BUFFER_FLOAT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Depth32fStencil8 = gl.Constants.GL_DEPTH32F_STENCIL8, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Rgba32ui = gl.Constants.GL_RGBA32UI, 
#endif

#if (GL_ARB_TEXTURE_BUFFER_OBJECT_RGB32 || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Rgb32ui = gl.Constants.GL_RGB32UI, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Rgba16ui = gl.Constants.GL_RGBA16UI, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Rgb16ui = gl.Constants.GL_RGB16UI, 
#endif

#if (GL_AMD_INTERLEAVED_ELEMENTS || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Rgba8ui = gl.Constants.GL_RGBA8UI, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Rgb8ui = gl.Constants.GL_RGB8UI, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Rgba32i = gl.Constants.GL_RGBA32I, 
#endif

#if (GL_ARB_TEXTURE_BUFFER_OBJECT_RGB32 || GL_ARB_VERTEX_ATTRIB_64BIT || GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Rgb32i = gl.Constants.GL_RGB32I, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Rgba16i = gl.Constants.GL_RGBA16I, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Rgb16i = gl.Constants.GL_RGB16I, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Rgba8i = gl.Constants.GL_RGBA8I, 
#endif

#if (GL_ES_VERSION_3_0 || GL_VERSION_3_0)
    Rgb8i = gl.Constants.GL_RGB8I, 
#endif

#if (GL_ES_VERSION_3_0 || GL_EXT_RENDER_SNORM || GL_EXT_TEXTURE_SNORM || GL_VERSION_3_1)
    R8Snorm = gl.Constants.GL_R8_SNORM, 
#endif

#if (GL_ES_VERSION_3_0 || GL_EXT_RENDER_SNORM || GL_EXT_TEXTURE_SNORM || GL_VERSION_3_1)
    Rg8Snorm = gl.Constants.GL_RG8_SNORM, 
#endif

#if (GL_ES_VERSION_3_0 || GL_EXT_TEXTURE_SNORM || GL_VERSION_3_1)
    Rgb8Snorm = gl.Constants.GL_RGB8_SNORM, 
#endif

#if (GL_ES_VERSION_3_0 || GL_EXT_RENDER_SNORM || GL_EXT_TEXTURE_SNORM || GL_VERSION_3_1)
    Rgba8Snorm = gl.Constants.GL_RGBA8_SNORM, 
#endif

#if (GL_ARB_TEXTURE_RGB10_A2UI || GL_ES_VERSION_3_0 || GL_VERSION_3_3)
    Rgb10A2ui = gl.Constants.GL_RGB10_A2UI, 
#endif

#if (GL_ARB_ES3_COMPATIBILITY || GL_ES_VERSION_3_0 || GL_VERSION_4_3)
    CompressedR11Eac = gl.Constants.GL_COMPRESSED_R11_EAC, 
#endif

#if (GL_ARB_ES3_COMPATIBILITY || GL_ES_VERSION_3_0 || GL_VERSION_4_3)
    CompressedSignedR11Eac = gl.Constants.GL_COMPRESSED_SIGNED_R11_EAC, 
#endif

#if (GL_ARB_ES3_COMPATIBILITY || GL_ES_VERSION_3_0 || GL_VERSION_4_3)
    CompressedRg11Eac = gl.Constants.GL_COMPRESSED_RG11_EAC, 
#endif

#if (GL_ARB_ES3_COMPATIBILITY || GL_ES_VERSION_3_0 || GL_VERSION_4_3)
    CompressedSignedRg11Eac = gl.Constants.GL_COMPRESSED_SIGNED_RG11_EAC, 
#endif

#if (GL_ARB_ES3_COMPATIBILITY || GL_ES_VERSION_3_0 || GL_VERSION_4_3)
    CompressedRgb8Etc2 = gl.Constants.GL_COMPRESSED_RGB8_ETC2, 
#endif

#if (GL_ARB_ES3_COMPATIBILITY || GL_ES_VERSION_3_0 || GL_VERSION_4_3)
    CompressedSrgb8Etc2 = gl.Constants.GL_COMPRESSED_SRGB8_ETC2, 
#endif

#if (GL_ARB_ES3_COMPATIBILITY || GL_ES_VERSION_3_0 || GL_VERSION_4_3)
    CompressedRgb8PunchthroughAlpha1Etc2 = gl.Constants.GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2, 
#endif

#if (GL_ARB_ES3_COMPATIBILITY || GL_ES_VERSION_3_0 || GL_VERSION_4_3)
    CompressedSrgb8PunchthroughAlpha1Etc2 = gl.Constants.GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2, 
#endif

#if (GL_ARB_ES3_COMPATIBILITY || GL_ES_VERSION_3_0 || GL_VERSION_4_3)
    CompressedRgba8Etc2Eac = gl.Constants.GL_COMPRESSED_RGBA8_ETC2_EAC, 
#endif

#if (GL_ARB_ES3_COMPATIBILITY || GL_ES_VERSION_3_0 || GL_VERSION_4_3)
    CompressedSrgb8Alpha8Etc2Eac = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC, 
#endif

#if GL_ES_VERSION_3_2
    CompressedRgbaAstc4x4 = gl.Constants.GL_COMPRESSED_RGBA_ASTC_4x4, 
#endif

#if GL_ES_VERSION_3_2
    CompressedRgbaAstc5x4 = gl.Constants.GL_COMPRESSED_RGBA_ASTC_5x4, 
#endif

#if GL_ES_VERSION_3_2
    CompressedRgbaAstc5x5 = gl.Constants.GL_COMPRESSED_RGBA_ASTC_5x5, 
#endif

#if GL_ES_VERSION_3_2
    CompressedRgbaAstc6x5 = gl.Constants.GL_COMPRESSED_RGBA_ASTC_6x5, 
#endif

#if GL_ES_VERSION_3_2
    CompressedRgbaAstc6x6 = gl.Constants.GL_COMPRESSED_RGBA_ASTC_6x6, 
#endif

#if GL_ES_VERSION_3_2
    CompressedRgbaAstc8x5 = gl.Constants.GL_COMPRESSED_RGBA_ASTC_8x5, 
#endif

#if GL_ES_VERSION_3_2
    CompressedRgbaAstc8x6 = gl.Constants.GL_COMPRESSED_RGBA_ASTC_8x6, 
#endif

#if GL_ES_VERSION_3_2
    CompressedRgbaAstc8x8 = gl.Constants.GL_COMPRESSED_RGBA_ASTC_8x8, 
#endif

#if GL_ES_VERSION_3_2
    CompressedRgbaAstc10x5 = gl.Constants.GL_COMPRESSED_RGBA_ASTC_10x5, 
#endif

#if GL_ES_VERSION_3_2
    CompressedRgbaAstc10x6 = gl.Constants.GL_COMPRESSED_RGBA_ASTC_10x6, 
#endif

#if GL_ES_VERSION_3_2
    CompressedRgbaAstc10x8 = gl.Constants.GL_COMPRESSED_RGBA_ASTC_10x8, 
#endif

#if GL_ES_VERSION_3_2
    CompressedRgbaAstc10x10 = gl.Constants.GL_COMPRESSED_RGBA_ASTC_10x10, 
#endif

#if GL_ES_VERSION_3_2
    CompressedRgbaAstc12x10 = gl.Constants.GL_COMPRESSED_RGBA_ASTC_12x10, 
#endif

#if GL_ES_VERSION_3_2
    CompressedRgbaAstc12x12 = gl.Constants.GL_COMPRESSED_RGBA_ASTC_12x12, 
#endif

#if GL_ES_VERSION_3_2
    CompressedSrgb8Alpha8Astc4x4 = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4, 
#endif

#if GL_ES_VERSION_3_2
    CompressedSrgb8Alpha8Astc5x4 = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4, 
#endif

#if GL_ES_VERSION_3_2
    CompressedSrgb8Alpha8Astc5x5 = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5, 
#endif

#if GL_ES_VERSION_3_2
    CompressedSrgb8Alpha8Astc6x5 = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5, 
#endif

#if GL_ES_VERSION_3_2
    CompressedSrgb8Alpha8Astc6x6 = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6, 
#endif

#if GL_ES_VERSION_3_2
    CompressedSrgb8Alpha8Astc8x5 = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x5, 
#endif

#if GL_ES_VERSION_3_2
    CompressedSrgb8Alpha8Astc8x6 = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x6, 
#endif

#if GL_ES_VERSION_3_2
    CompressedSrgb8Alpha8Astc8x8 = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x8, 
#endif

#if GL_ES_VERSION_3_2
    CompressedSrgb8Alpha8Astc10x5 = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x5, 
#endif

#if GL_ES_VERSION_3_2
    CompressedSrgb8Alpha8Astc10x6 = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x6, 
#endif

#if GL_ES_VERSION_3_2
    CompressedSrgb8Alpha8Astc10x8 = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x8, 
#endif

#if GL_ES_VERSION_3_2
    CompressedSrgb8Alpha8Astc10x10 = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x10, 
#endif

#if GL_ES_VERSION_3_2
    CompressedSrgb8Alpha8Astc12x10 = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x10, 
#endif

#if GL_ES_VERSION_3_2
    CompressedSrgb8Alpha8Astc12x12 = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x12, 
#endif

#if GL_VERSION_1_1
    R3G3B2 = gl.Constants.GL_R3_G3_B2, 
#endif

#if GL_VERSION_1_1
    Alpha4 = gl.Constants.GL_ALPHA4, 
#endif

#if GL_VERSION_1_1
    Alpha8 = gl.Constants.GL_ALPHA8, 
#endif

#if GL_VERSION_1_1
    Alpha12 = gl.Constants.GL_ALPHA12, 
#endif

#if GL_VERSION_1_1
    Alpha16 = gl.Constants.GL_ALPHA16, 
#endif

#if GL_VERSION_1_1
    Luminance4 = gl.Constants.GL_LUMINANCE4, 
#endif

#if GL_VERSION_1_1
    Luminance8 = gl.Constants.GL_LUMINANCE8, 
#endif

#if GL_VERSION_1_1
    Luminance12 = gl.Constants.GL_LUMINANCE12, 
#endif

#if GL_VERSION_1_1
    Luminance16 = gl.Constants.GL_LUMINANCE16, 
#endif

#if GL_VERSION_1_1
    Luminance4Alpha4 = gl.Constants.GL_LUMINANCE4_ALPHA4, 
#endif

#if GL_VERSION_1_1
    Luminance6Alpha2 = gl.Constants.GL_LUMINANCE6_ALPHA2, 
#endif

#if GL_VERSION_1_1
    Luminance8Alpha8 = gl.Constants.GL_LUMINANCE8_ALPHA8, 
#endif

#if GL_VERSION_1_1
    Luminance12Alpha4 = gl.Constants.GL_LUMINANCE12_ALPHA4, 
#endif

#if GL_VERSION_1_1
    Luminance12Alpha12 = gl.Constants.GL_LUMINANCE12_ALPHA12, 
#endif

#if GL_VERSION_1_1
    Luminance16Alpha16 = gl.Constants.GL_LUMINANCE16_ALPHA16, 
#endif

#if GL_VERSION_1_1
    Intensity4 = gl.Constants.GL_INTENSITY4, 
#endif

#if GL_VERSION_1_1
    Intensity8 = gl.Constants.GL_INTENSITY8, 
#endif

#if GL_VERSION_1_1
    Intensity12 = gl.Constants.GL_INTENSITY12, 
#endif

#if GL_VERSION_1_1
    Intensity16 = gl.Constants.GL_INTENSITY16, 
#endif

#if GL_VERSION_1_1
    Rgb4 = gl.Constants.GL_RGB4, 
#endif

#if GL_VERSION_1_1
    Rgb5 = gl.Constants.GL_RGB5, 
#endif

#if GL_VERSION_1_1
    Rgb10 = gl.Constants.GL_RGB10, 
#endif

#if GL_VERSION_1_1
    Rgb12 = gl.Constants.GL_RGB12, 
#endif

#if GL_VERSION_1_1
    Rgb16 = gl.Constants.GL_RGB16, 
#endif

#if GL_VERSION_1_1
    Rgba2 = gl.Constants.GL_RGBA2, 
#endif

#if GL_VERSION_1_1
    Rgba12 = gl.Constants.GL_RGBA12, 
#endif

#if GL_VERSION_1_1
    Rgba16 = gl.Constants.GL_RGBA16, 
#endif

#if GL_VERSION_1_4
    DepthComponent32 = gl.Constants.GL_DEPTH_COMPONENT32, 
#endif

#if (GL_ARB_TEXTURE_RG || GL_VERSION_3_0)
    R16 = gl.Constants.GL_R16, 
#endif

#if (GL_ARB_TEXTURE_RG || GL_VERSION_3_0)
    Rg16 = gl.Constants.GL_RG16, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_VERSION_3_0)
    StencilIndex1 = gl.Constants.GL_STENCIL_INDEX1, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_VERSION_3_0)
    StencilIndex4 = gl.Constants.GL_STENCIL_INDEX4, 
#endif

#if (GL_ARB_FRAMEBUFFER_OBJECT || GL_VERSION_3_0)
    StencilIndex16 = gl.Constants.GL_STENCIL_INDEX16, 
#endif

#if (GL_ARB_TEXTURE_COMPRESSION_RGTC || GL_VERSION_3_0)
    CompressedRedRgtc1 = gl.Constants.GL_COMPRESSED_RED_RGTC1, 
#endif

#if (GL_ARB_TEXTURE_COMPRESSION_RGTC || GL_VERSION_3_0)
    CompressedSignedRedRgtc1 = gl.Constants.GL_COMPRESSED_SIGNED_RED_RGTC1, 
#endif

#if (GL_ARB_TEXTURE_COMPRESSION_RGTC || GL_VERSION_3_0)
    CompressedRgRgtc2 = gl.Constants.GL_COMPRESSED_RG_RGTC2, 
#endif

#if (GL_ARB_TEXTURE_COMPRESSION_RGTC || GL_VERSION_3_0)
    CompressedSignedRgRgtc2 = gl.Constants.GL_COMPRESSED_SIGNED_RG_RGTC2, 
#endif

#if (GL_EXT_TEXTURE_SNORM || GL_VERSION_3_1)
    R16Snorm = gl.Constants.GL_R16_SNORM, 
#endif

#if (GL_EXT_TEXTURE_SNORM || GL_VERSION_3_1)
    Rg16Snorm = gl.Constants.GL_RG16_SNORM, 
#endif

#if (GL_EXT_TEXTURE_SNORM || GL_VERSION_3_1)
    Rgb16Snorm = gl.Constants.GL_RGB16_SNORM, 
#endif

#if (GL_EXT_TEXTURE_SNORM || GL_VERSION_3_1)
    Rgba16Snorm = gl.Constants.GL_RGBA16_SNORM, 
#endif

#if GL_VERSION_4_2
    CompressedRgbaBptcUnorm = gl.Constants.GL_COMPRESSED_RGBA_BPTC_UNORM, 
#endif

#if GL_VERSION_4_2
    CompressedSrgbAlphaBptcUnorm = gl.Constants.GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM, 
#endif

#if GL_VERSION_4_2
    CompressedRgbBptcSignedFloat = gl.Constants.GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT, 
#endif

#if GL_VERSION_4_2
    CompressedRgbBptcUnsignedFloat = gl.Constants.GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT, 
#endif

#if (GL_ANGLE_DEPTH_TEXTURE || GL_OES_DEPTH32 || GL_OES_REQUIRED_INTERNALFORMAT)
    DepthComponent32Oes = gl.Constants.GL_DEPTH_COMPONENT32_OES, 
#endif

#if (GL_ANGLE_DEPTH_TEXTURE || GL_OES_PACKED_DEPTH_STENCIL || GL_OES_REQUIRED_INTERNALFORMAT)
    Depth24Stencil8Oes = gl.Constants.GL_DEPTH24_STENCIL8_OES, 
#endif

#if GL_ANGLE_TEXTURE_COMPRESSION_DXT3
    CompressedRgbaS3tcDxt3Angle = gl.Constants.GL_COMPRESSED_RGBA_S3TC_DXT3_ANGLE, 
#endif

#if GL_ANGLE_TEXTURE_COMPRESSION_DXT5
    CompressedRgbaS3tcDxt5Angle = gl.Constants.GL_COMPRESSED_RGBA_S3TC_DXT5_ANGLE, 
#endif

#if GL_APPLE_TEXTURE_PACKED_FLOAT
    R11fG11fB10fApple = gl.Constants.GL_R11F_G11F_B10F_APPLE, 
#endif

#if GL_APPLE_TEXTURE_PACKED_FLOAT
    Rgb9E5Apple = gl.Constants.GL_RGB9_E5_APPLE, 
#endif

#if GL_ARB_DEPTH_TEXTURE
    DepthComponent16Arb = gl.Constants.GL_DEPTH_COMPONENT16_ARB, 
#endif

#if GL_ARB_DEPTH_TEXTURE
    DepthComponent24Arb = gl.Constants.GL_DEPTH_COMPONENT24_ARB, 
#endif

#if GL_ARB_DEPTH_TEXTURE
    DepthComponent32Arb = gl.Constants.GL_DEPTH_COMPONENT32_ARB, 
#endif

#if GL_ARB_TEXTURE_COMPRESSION_BPTC
    CompressedRgbaBptcUnormArb = gl.Constants.GL_COMPRESSED_RGBA_BPTC_UNORM_ARB, 
#endif

#if GL_ARB_TEXTURE_COMPRESSION_BPTC
    CompressedSrgbAlphaBptcUnormArb = gl.Constants.GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM_ARB, 
#endif

#if GL_ARB_TEXTURE_COMPRESSION_BPTC
    CompressedRgbBptcSignedFloatArb = gl.Constants.GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT_ARB, 
#endif

#if GL_ARB_TEXTURE_COMPRESSION_BPTC
    CompressedRgbBptcUnsignedFloatArb = gl.Constants.GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_ARB, 
#endif

#if GL_ARB_TEXTURE_FLOAT
    Rgba32fArb = gl.Constants.GL_RGBA32F_ARB, 
#endif

#if GL_ARB_TEXTURE_FLOAT
    Rgb32fArb = gl.Constants.GL_RGB32F_ARB, 
#endif

#if GL_ARB_TEXTURE_FLOAT
    Rgba16fArb = gl.Constants.GL_RGBA16F_ARB, 
#endif

#if GL_ARB_TEXTURE_FLOAT
    Rgb16fArb = gl.Constants.GL_RGB16F_ARB, 
#endif

#if (GL_EXT_COLOR_BUFFER_HALF_FLOAT || GL_EXT_TEXTURE_STORAGE)
    R16fExt = gl.Constants.GL_R16F_EXT, 
#endif

#if (GL_EXT_COLOR_BUFFER_HALF_FLOAT || GL_EXT_TEXTURE_STORAGE)
    Rg16fExt = gl.Constants.GL_RG16F_EXT, 
#endif

#if (GL_EXT_COLOR_BUFFER_HALF_FLOAT || GL_EXT_TEXTURE_STORAGE)
    Rgba16fExt = gl.Constants.GL_RGBA16F_EXT, 
#endif

#if (GL_EXT_COLOR_BUFFER_HALF_FLOAT || GL_EXT_TEXTURE_STORAGE)
    Rgb16fExt = gl.Constants.GL_RGB16F_EXT, 
#endif

#if GL_EXT_FRAMEBUFFER_OBJECT
    StencilIndex1Ext = gl.Constants.GL_STENCIL_INDEX1_EXT, 
#endif

#if GL_EXT_FRAMEBUFFER_OBJECT
    StencilIndex4Ext = gl.Constants.GL_STENCIL_INDEX4_EXT, 
#endif

#if GL_EXT_FRAMEBUFFER_OBJECT
    StencilIndex8Ext = gl.Constants.GL_STENCIL_INDEX8_EXT, 
#endif

#if GL_EXT_FRAMEBUFFER_OBJECT
    StencilIndex16Ext = gl.Constants.GL_STENCIL_INDEX16_EXT, 
#endif

#if GL_EXT_PACKED_DEPTH_STENCIL
    Depth24Stencil8Ext = gl.Constants.GL_DEPTH24_STENCIL8_EXT, 
#endif

#if GL_EXT_PACKED_FLOAT
    R11fG11fB10fExt = gl.Constants.GL_R11F_G11F_B10F_EXT, 
#endif

#if (GL_EXT_RENDER_SNORM || GL_EXT_TEXTURE_NORM16)
    R16SnormExt = gl.Constants.GL_R16_SNORM_EXT, 
#endif

#if (GL_EXT_RENDER_SNORM || GL_EXT_TEXTURE_NORM16)
    Rg16SnormExt = gl.Constants.GL_RG16_SNORM_EXT, 
#endif

#if (GL_EXT_RENDER_SNORM || GL_EXT_TEXTURE_NORM16)
    Rgba16SnormExt = gl.Constants.GL_RGBA16_SNORM_EXT, 
#endif

#if (GL_EXT_SRGB || GL_EXT_TEXTURE_SRGB)
    Srgb8Alpha8Ext = gl.Constants.GL_SRGB8_ALPHA8_EXT, 
#endif

#if GL_EXT_TEXTURE
    Alpha4Ext = gl.Constants.GL_ALPHA4_EXT, 
#endif

#if (GL_EXT_TEXTURE || GL_EXT_TEXTURE_STORAGE)
    Alpha8Ext = gl.Constants.GL_ALPHA8_EXT, 
#endif

#if GL_EXT_TEXTURE
    Alpha12Ext = gl.Constants.GL_ALPHA12_EXT, 
#endif

#if GL_EXT_TEXTURE
    Alpha16Ext = gl.Constants.GL_ALPHA16_EXT, 
#endif

#if GL_EXT_TEXTURE
    Luminance4Ext = gl.Constants.GL_LUMINANCE4_EXT, 
#endif

#if (GL_EXT_TEXTURE || GL_EXT_TEXTURE_STORAGE)
    Luminance8Ext = gl.Constants.GL_LUMINANCE8_EXT, 
#endif

#if GL_EXT_TEXTURE
    Luminance12Ext = gl.Constants.GL_LUMINANCE12_EXT, 
#endif

#if GL_EXT_TEXTURE
    Luminance16Ext = gl.Constants.GL_LUMINANCE16_EXT, 
#endif

#if GL_EXT_TEXTURE
    Luminance4Alpha4Ext = gl.Constants.GL_LUMINANCE4_ALPHA4_EXT, 
#endif

#if GL_EXT_TEXTURE
    Luminance6Alpha2Ext = gl.Constants.GL_LUMINANCE6_ALPHA2_EXT, 
#endif

#if (GL_EXT_TEXTURE || GL_EXT_TEXTURE_STORAGE)
    Luminance8Alpha8Ext = gl.Constants.GL_LUMINANCE8_ALPHA8_EXT, 
#endif

#if GL_EXT_TEXTURE
    Luminance12Alpha4Ext = gl.Constants.GL_LUMINANCE12_ALPHA4_EXT, 
#endif

#if GL_EXT_TEXTURE
    Luminance12Alpha12Ext = gl.Constants.GL_LUMINANCE12_ALPHA12_EXT, 
#endif

#if GL_EXT_TEXTURE
    Luminance16Alpha16Ext = gl.Constants.GL_LUMINANCE16_ALPHA16_EXT, 
#endif

#if GL_EXT_TEXTURE
    Intensity4Ext = gl.Constants.GL_INTENSITY4_EXT, 
#endif

#if GL_EXT_TEXTURE
    Intensity8Ext = gl.Constants.GL_INTENSITY8_EXT, 
#endif

#if GL_EXT_TEXTURE
    Intensity12Ext = gl.Constants.GL_INTENSITY12_EXT, 
#endif

#if GL_EXT_TEXTURE
    Intensity16Ext = gl.Constants.GL_INTENSITY16_EXT, 
#endif

#if GL_EXT_TEXTURE
    Rgb2Ext = gl.Constants.GL_RGB2_EXT, 
#endif

#if GL_EXT_TEXTURE
    Rgb4Ext = gl.Constants.GL_RGB4_EXT, 
#endif

#if GL_EXT_TEXTURE
    Rgb5Ext = gl.Constants.GL_RGB5_EXT, 
#endif

#if GL_EXT_TEXTURE
    Rgb8Ext = gl.Constants.GL_RGB8_EXT, 
#endif

#if (GL_EXT_TEXTURE || GL_EXT_TEXTURE_STORAGE || GL_OES_REQUIRED_INTERNALFORMAT)
    Rgb10Ext = gl.Constants.GL_RGB10_EXT, 
#endif

#if GL_EXT_TEXTURE
    Rgb12Ext = gl.Constants.GL_RGB12_EXT, 
#endif

#if (GL_EXT_TEXTURE || GL_EXT_TEXTURE_NORM16)
    Rgb16Ext = gl.Constants.GL_RGB16_EXT, 
#endif

#if GL_EXT_TEXTURE
    Rgba2Ext = gl.Constants.GL_RGBA2_EXT, 
#endif

#if GL_EXT_TEXTURE
    Rgba4Ext = gl.Constants.GL_RGBA4_EXT, 
#endif

#if GL_EXT_TEXTURE
    Rgb5A1Ext = gl.Constants.GL_RGB5_A1_EXT, 
#endif

#if GL_EXT_TEXTURE
    Rgba8Ext = gl.Constants.GL_RGBA8_EXT, 
#endif

#if (GL_EXT_TEXTURE || GL_EXT_TEXTURE_STORAGE || GL_OES_REQUIRED_INTERNALFORMAT)
    Rgb10A2Ext = gl.Constants.GL_RGB10_A2_EXT, 
#endif

#if GL_EXT_TEXTURE
    Rgba12Ext = gl.Constants.GL_RGBA12_EXT, 
#endif

#if (GL_EXT_TEXTURE || GL_EXT_TEXTURE_NORM16)
    Rgba16Ext = gl.Constants.GL_RGBA16_EXT, 
#endif

#if GL_EXT_TEXTURE_COMPRESSION_BPTC
    CompressedRgbaBptcUnormExt = gl.Constants.GL_COMPRESSED_RGBA_BPTC_UNORM_EXT, 
#endif

#if GL_EXT_TEXTURE_COMPRESSION_BPTC
    CompressedSrgbAlphaBptcUnormExt = gl.Constants.GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM_EXT, 
#endif

#if GL_EXT_TEXTURE_COMPRESSION_BPTC
    CompressedRgbBptcSignedFloatExt = gl.Constants.GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT_EXT, 
#endif

#if GL_EXT_TEXTURE_COMPRESSION_BPTC
    CompressedRgbBptcUnsignedFloatExt = gl.Constants.GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_EXT, 
#endif

#if (GL_EXT_TEXTURE_COMPRESSION_DXT1 || GL_EXT_TEXTURE_COMPRESSION_S3TC)
    CompressedRgbS3tcDxt1Ext = gl.Constants.GL_COMPRESSED_RGB_S3TC_DXT1_EXT, 
#endif

#if (GL_EXT_TEXTURE_COMPRESSION_DXT1 || GL_EXT_TEXTURE_COMPRESSION_S3TC)
    CompressedRgbaS3tcDxt1Ext = gl.Constants.GL_COMPRESSED_RGBA_S3TC_DXT1_EXT, 
#endif

#if GL_EXT_TEXTURE_COMPRESSION_RGTC
    CompressedRedRgtc1Ext = gl.Constants.GL_COMPRESSED_RED_RGTC1_EXT, 
#endif

#if GL_EXT_TEXTURE_COMPRESSION_RGTC
    CompressedSignedRedRgtc1Ext = gl.Constants.GL_COMPRESSED_SIGNED_RED_RGTC1_EXT, 
#endif

#if GL_EXT_TEXTURE_COMPRESSION_RGTC
    CompressedRedGreenRgtc2Ext = gl.Constants.GL_COMPRESSED_RED_GREEN_RGTC2_EXT, 
#endif

#if GL_EXT_TEXTURE_COMPRESSION_RGTC
    CompressedSignedRedGreenRgtc2Ext = gl.Constants.GL_COMPRESSED_SIGNED_RED_GREEN_RGTC2_EXT, 
#endif

#if GL_EXT_TEXTURE_COMPRESSION_S3TC
    CompressedRgbaS3tcDxt3Ext = gl.Constants.GL_COMPRESSED_RGBA_S3TC_DXT3_EXT, 
#endif

#if GL_EXT_TEXTURE_COMPRESSION_S3TC
    CompressedRgbaS3tcDxt5Ext = gl.Constants.GL_COMPRESSED_RGBA_S3TC_DXT5_EXT, 
#endif

#if (GL_EXT_TEXTURE_COMPRESSION_S3TC_SRGB || GL_EXT_TEXTURE_SRGB)
    CompressedSrgbS3tcDxt1Ext = gl.Constants.GL_COMPRESSED_SRGB_S3TC_DXT1_EXT, 
#endif

#if (GL_EXT_TEXTURE_COMPRESSION_S3TC_SRGB || GL_EXT_TEXTURE_SRGB)
    CompressedSrgbAlphaS3tcDxt1Ext = gl.Constants.GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT, 
#endif

#if (GL_EXT_TEXTURE_COMPRESSION_S3TC_SRGB || GL_EXT_TEXTURE_SRGB)
    CompressedSrgbAlphaS3tcDxt3Ext = gl.Constants.GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT, 
#endif

#if (GL_EXT_TEXTURE_COMPRESSION_S3TC_SRGB || GL_EXT_TEXTURE_SRGB)
    CompressedSrgbAlphaS3tcDxt5Ext = gl.Constants.GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    Rgba32uiExt = gl.Constants.GL_RGBA32UI_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    Rgb32uiExt = gl.Constants.GL_RGB32UI_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    Alpha32uiExt = gl.Constants.GL_ALPHA32UI_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    Intensity32uiExt = gl.Constants.GL_INTENSITY32UI_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    Luminance32uiExt = gl.Constants.GL_LUMINANCE32UI_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    LuminanceAlpha32uiExt = gl.Constants.GL_LUMINANCE_ALPHA32UI_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    Rgba16uiExt = gl.Constants.GL_RGBA16UI_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    Rgb16uiExt = gl.Constants.GL_RGB16UI_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    Alpha16uiExt = gl.Constants.GL_ALPHA16UI_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    Intensity16uiExt = gl.Constants.GL_INTENSITY16UI_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    Luminance16uiExt = gl.Constants.GL_LUMINANCE16UI_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    LuminanceAlpha16uiExt = gl.Constants.GL_LUMINANCE_ALPHA16UI_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    Rgba8uiExt = gl.Constants.GL_RGBA8UI_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    Rgb8uiExt = gl.Constants.GL_RGB8UI_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    Alpha8uiExt = gl.Constants.GL_ALPHA8UI_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    Intensity8uiExt = gl.Constants.GL_INTENSITY8UI_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    Luminance8uiExt = gl.Constants.GL_LUMINANCE8UI_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    LuminanceAlpha8uiExt = gl.Constants.GL_LUMINANCE_ALPHA8UI_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    Rgba32iExt = gl.Constants.GL_RGBA32I_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    Rgb32iExt = gl.Constants.GL_RGB32I_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    Alpha32iExt = gl.Constants.GL_ALPHA32I_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    Intensity32iExt = gl.Constants.GL_INTENSITY32I_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    Luminance32iExt = gl.Constants.GL_LUMINANCE32I_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    LuminanceAlpha32iExt = gl.Constants.GL_LUMINANCE_ALPHA32I_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    Rgba16iExt = gl.Constants.GL_RGBA16I_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    Rgb16iExt = gl.Constants.GL_RGB16I_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    Alpha16iExt = gl.Constants.GL_ALPHA16I_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    Intensity16iExt = gl.Constants.GL_INTENSITY16I_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    Luminance16iExt = gl.Constants.GL_LUMINANCE16I_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    LuminanceAlpha16iExt = gl.Constants.GL_LUMINANCE_ALPHA16I_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    Rgba8iExt = gl.Constants.GL_RGBA8I_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    Rgb8iExt = gl.Constants.GL_RGB8I_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    Alpha8iExt = gl.Constants.GL_ALPHA8I_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    Intensity8iExt = gl.Constants.GL_INTENSITY8I_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    Luminance8iExt = gl.Constants.GL_LUMINANCE8I_EXT, 
#endif

#if GL_EXT_TEXTURE_INTEGER
    LuminanceAlpha8iExt = gl.Constants.GL_LUMINANCE_ALPHA8I_EXT, 
#endif

#if GL_EXT_TEXTURE_NORM16
    R16Ext = gl.Constants.GL_R16_EXT, 
#endif

#if GL_EXT_TEXTURE_NORM16
    Rg16Ext = gl.Constants.GL_RG16_EXT, 
#endif

#if GL_EXT_TEXTURE_NORM16
    Rgb16SnormExt = gl.Constants.GL_RGB16_SNORM_EXT, 
#endif

#if (GL_EXT_TEXTURE_RG || GL_EXT_TEXTURE_STORAGE)
    R8Ext = gl.Constants.GL_R8_EXT, 
#endif

#if (GL_EXT_TEXTURE_RG || GL_EXT_TEXTURE_STORAGE)
    Rg8Ext = gl.Constants.GL_RG8_EXT, 
#endif

#if GL_EXT_TEXTURE_SHARED_EXPONENT
    Rgb9E5Ext = gl.Constants.GL_RGB9_E5_EXT, 
#endif

#if GL_EXT_TEXTURE_SRGB
    Srgb8Ext = gl.Constants.GL_SRGB8_EXT, 
#endif

#if GL_EXT_TEXTURE_STORAGE
    R32fExt = gl.Constants.GL_R32F_EXT, 
#endif

#if GL_EXT_TEXTURE_STORAGE
    Rg32fExt = gl.Constants.GL_RG32F_EXT, 
#endif

#if GL_EXT_TEXTURE_STORAGE
    Rgba32fExt = gl.Constants.GL_RGBA32F_EXT, 
#endif

#if GL_EXT_TEXTURE_STORAGE
    Rgb32fExt = gl.Constants.GL_RGB32F_EXT, 
#endif

#if (GL_KHR_TEXTURE_COMPRESSION_ASTC_HDR || GL_KHR_TEXTURE_COMPRESSION_ASTC_LDR || GL_OES_TEXTURE_COMPRESSION_ASTC)
    CompressedRgbaAstc4x4Khr = gl.Constants.GL_COMPRESSED_RGBA_ASTC_4x4_KHR, 
#endif

#if (GL_KHR_TEXTURE_COMPRESSION_ASTC_HDR || GL_KHR_TEXTURE_COMPRESSION_ASTC_LDR || GL_OES_TEXTURE_COMPRESSION_ASTC)
    CompressedRgbaAstc5x4Khr = gl.Constants.GL_COMPRESSED_RGBA_ASTC_5x4_KHR, 
#endif

#if (GL_KHR_TEXTURE_COMPRESSION_ASTC_HDR || GL_KHR_TEXTURE_COMPRESSION_ASTC_LDR || GL_OES_TEXTURE_COMPRESSION_ASTC)
    CompressedRgbaAstc5x5Khr = gl.Constants.GL_COMPRESSED_RGBA_ASTC_5x5_KHR, 
#endif

#if (GL_KHR_TEXTURE_COMPRESSION_ASTC_HDR || GL_KHR_TEXTURE_COMPRESSION_ASTC_LDR || GL_OES_TEXTURE_COMPRESSION_ASTC)
    CompressedRgbaAstc6x5Khr = gl.Constants.GL_COMPRESSED_RGBA_ASTC_6x5_KHR, 
#endif

#if (GL_KHR_TEXTURE_COMPRESSION_ASTC_HDR || GL_KHR_TEXTURE_COMPRESSION_ASTC_LDR || GL_OES_TEXTURE_COMPRESSION_ASTC)
    CompressedRgbaAstc6x6Khr = gl.Constants.GL_COMPRESSED_RGBA_ASTC_6x6_KHR, 
#endif

#if (GL_KHR_TEXTURE_COMPRESSION_ASTC_HDR || GL_KHR_TEXTURE_COMPRESSION_ASTC_LDR || GL_OES_TEXTURE_COMPRESSION_ASTC)
    CompressedRgbaAstc8x5Khr = gl.Constants.GL_COMPRESSED_RGBA_ASTC_8x5_KHR, 
#endif

#if (GL_KHR_TEXTURE_COMPRESSION_ASTC_HDR || GL_KHR_TEXTURE_COMPRESSION_ASTC_LDR || GL_OES_TEXTURE_COMPRESSION_ASTC)
    CompressedRgbaAstc8x6Khr = gl.Constants.GL_COMPRESSED_RGBA_ASTC_8x6_KHR, 
#endif

#if (GL_KHR_TEXTURE_COMPRESSION_ASTC_HDR || GL_KHR_TEXTURE_COMPRESSION_ASTC_LDR || GL_OES_TEXTURE_COMPRESSION_ASTC)
    CompressedRgbaAstc8x8Khr = gl.Constants.GL_COMPRESSED_RGBA_ASTC_8x8_KHR, 
#endif

#if (GL_KHR_TEXTURE_COMPRESSION_ASTC_HDR || GL_KHR_TEXTURE_COMPRESSION_ASTC_LDR || GL_OES_TEXTURE_COMPRESSION_ASTC)
    CompressedRgbaAstc10x5Khr = gl.Constants.GL_COMPRESSED_RGBA_ASTC_10x5_KHR, 
#endif

#if (GL_KHR_TEXTURE_COMPRESSION_ASTC_HDR || GL_KHR_TEXTURE_COMPRESSION_ASTC_LDR || GL_OES_TEXTURE_COMPRESSION_ASTC)
    CompressedRgbaAstc10x6Khr = gl.Constants.GL_COMPRESSED_RGBA_ASTC_10x6_KHR, 
#endif

#if (GL_KHR_TEXTURE_COMPRESSION_ASTC_HDR || GL_KHR_TEXTURE_COMPRESSION_ASTC_LDR || GL_OES_TEXTURE_COMPRESSION_ASTC)
    CompressedRgbaAstc10x8Khr = gl.Constants.GL_COMPRESSED_RGBA_ASTC_10x8_KHR, 
#endif

#if (GL_KHR_TEXTURE_COMPRESSION_ASTC_HDR || GL_KHR_TEXTURE_COMPRESSION_ASTC_LDR || GL_OES_TEXTURE_COMPRESSION_ASTC)
    CompressedRgbaAstc10x10Khr = gl.Constants.GL_COMPRESSED_RGBA_ASTC_10x10_KHR, 
#endif

#if (GL_KHR_TEXTURE_COMPRESSION_ASTC_HDR || GL_KHR_TEXTURE_COMPRESSION_ASTC_LDR || GL_OES_TEXTURE_COMPRESSION_ASTC)
    CompressedRgbaAstc12x10Khr = gl.Constants.GL_COMPRESSED_RGBA_ASTC_12x10_KHR, 
#endif

#if (GL_KHR_TEXTURE_COMPRESSION_ASTC_HDR || GL_KHR_TEXTURE_COMPRESSION_ASTC_LDR || GL_OES_TEXTURE_COMPRESSION_ASTC)
    CompressedRgbaAstc12x12Khr = gl.Constants.GL_COMPRESSED_RGBA_ASTC_12x12_KHR, 
#endif

#if (GL_KHR_TEXTURE_COMPRESSION_ASTC_HDR || GL_KHR_TEXTURE_COMPRESSION_ASTC_LDR || GL_OES_TEXTURE_COMPRESSION_ASTC)
    CompressedSrgb8Alpha8Astc4x4Khr = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR, 
#endif

#if (GL_KHR_TEXTURE_COMPRESSION_ASTC_HDR || GL_KHR_TEXTURE_COMPRESSION_ASTC_LDR || GL_OES_TEXTURE_COMPRESSION_ASTC)
    CompressedSrgb8Alpha8Astc5x4Khr = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4_KHR, 
#endif

#if (GL_KHR_TEXTURE_COMPRESSION_ASTC_HDR || GL_KHR_TEXTURE_COMPRESSION_ASTC_LDR || GL_OES_TEXTURE_COMPRESSION_ASTC)
    CompressedSrgb8Alpha8Astc5x5Khr = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5_KHR, 
#endif

#if (GL_KHR_TEXTURE_COMPRESSION_ASTC_HDR || GL_KHR_TEXTURE_COMPRESSION_ASTC_LDR || GL_OES_TEXTURE_COMPRESSION_ASTC)
    CompressedSrgb8Alpha8Astc6x5Khr = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5_KHR, 
#endif

#if (GL_KHR_TEXTURE_COMPRESSION_ASTC_HDR || GL_KHR_TEXTURE_COMPRESSION_ASTC_LDR || GL_OES_TEXTURE_COMPRESSION_ASTC)
    CompressedSrgb8Alpha8Astc6x6Khr = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6_KHR, 
#endif

#if (GL_KHR_TEXTURE_COMPRESSION_ASTC_HDR || GL_KHR_TEXTURE_COMPRESSION_ASTC_LDR || GL_OES_TEXTURE_COMPRESSION_ASTC)
    CompressedSrgb8Alpha8Astc8x5Khr = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x5_KHR, 
#endif

#if (GL_KHR_TEXTURE_COMPRESSION_ASTC_HDR || GL_KHR_TEXTURE_COMPRESSION_ASTC_LDR || GL_OES_TEXTURE_COMPRESSION_ASTC)
    CompressedSrgb8Alpha8Astc8x6Khr = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x6_KHR, 
#endif

#if (GL_KHR_TEXTURE_COMPRESSION_ASTC_HDR || GL_KHR_TEXTURE_COMPRESSION_ASTC_LDR || GL_OES_TEXTURE_COMPRESSION_ASTC)
    CompressedSrgb8Alpha8Astc8x8Khr = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x8_KHR, 
#endif

#if (GL_KHR_TEXTURE_COMPRESSION_ASTC_HDR || GL_KHR_TEXTURE_COMPRESSION_ASTC_LDR || GL_OES_TEXTURE_COMPRESSION_ASTC)
    CompressedSrgb8Alpha8Astc10x5Khr = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x5_KHR, 
#endif

#if (GL_KHR_TEXTURE_COMPRESSION_ASTC_HDR || GL_KHR_TEXTURE_COMPRESSION_ASTC_LDR || GL_OES_TEXTURE_COMPRESSION_ASTC)
    CompressedSrgb8Alpha8Astc10x6Khr = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x6_KHR, 
#endif

#if (GL_KHR_TEXTURE_COMPRESSION_ASTC_HDR || GL_KHR_TEXTURE_COMPRESSION_ASTC_LDR || GL_OES_TEXTURE_COMPRESSION_ASTC)
    CompressedSrgb8Alpha8Astc10x8Khr = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x8_KHR, 
#endif

#if (GL_KHR_TEXTURE_COMPRESSION_ASTC_HDR || GL_KHR_TEXTURE_COMPRESSION_ASTC_LDR || GL_OES_TEXTURE_COMPRESSION_ASTC)
    CompressedSrgb8Alpha8Astc10x10Khr = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x10_KHR, 
#endif

#if (GL_KHR_TEXTURE_COMPRESSION_ASTC_HDR || GL_KHR_TEXTURE_COMPRESSION_ASTC_LDR || GL_OES_TEXTURE_COMPRESSION_ASTC)
    CompressedSrgb8Alpha8Astc12x10Khr = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x10_KHR, 
#endif

#if (GL_KHR_TEXTURE_COMPRESSION_ASTC_HDR || GL_KHR_TEXTURE_COMPRESSION_ASTC_LDR || GL_OES_TEXTURE_COMPRESSION_ASTC)
    CompressedSrgb8Alpha8Astc12x12Khr = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x12_KHR, 
#endif

#if GL_NV_DEPTH_BUFFER_FLOAT
    DepthComponent32fNv = gl.Constants.GL_DEPTH_COMPONENT32F_NV, 
#endif

#if GL_NV_DEPTH_BUFFER_FLOAT
    Depth32fStencil8Nv = gl.Constants.GL_DEPTH32F_STENCIL8_NV, 
#endif

#if GL_NV_SRGB_FORMATS
    Srgb8Nv = gl.Constants.GL_SRGB8_NV, 
#endif

#if GL_NV_SRGB_FORMATS
    CompressedSrgbS3tcDxt1Nv = gl.Constants.GL_COMPRESSED_SRGB_S3TC_DXT1_NV, 
#endif

#if GL_NV_SRGB_FORMATS
    CompressedSrgbAlphaS3tcDxt1Nv = gl.Constants.GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_NV, 
#endif

#if GL_NV_SRGB_FORMATS
    CompressedSrgbAlphaS3tcDxt3Nv = gl.Constants.GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_NV, 
#endif

#if GL_NV_SRGB_FORMATS
    CompressedSrgbAlphaS3tcDxt5Nv = gl.Constants.GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_NV, 
#endif

#if GL_OES_COMPRESSED_ETC1_RGB8_TEXTURE
    Etc1Rgb8Oes = gl.Constants.GL_ETC1_RGB8_OES, 
#endif

#if (GL_OES_DEPTH24 || GL_OES_REQUIRED_INTERNALFORMAT)
    DepthComponent24Oes = gl.Constants.GL_DEPTH_COMPONENT24_OES, 
#endif

#if (GL_OES_FRAMEBUFFER_OBJECT || GL_OES_REQUIRED_INTERNALFORMAT)
    Rgba4Oes = gl.Constants.GL_RGBA4_OES, 
#endif

#if (GL_OES_FRAMEBUFFER_OBJECT || GL_OES_REQUIRED_INTERNALFORMAT)
    Rgb5A1Oes = gl.Constants.GL_RGB5_A1_OES, 
#endif

#if (GL_OES_FRAMEBUFFER_OBJECT || GL_OES_REQUIRED_INTERNALFORMAT)
    DepthComponent16Oes = gl.Constants.GL_DEPTH_COMPONENT16_OES, 
#endif

#if (GL_OES_FRAMEBUFFER_OBJECT || GL_OES_REQUIRED_INTERNALFORMAT)
    Rgb565Oes = gl.Constants.GL_RGB565_OES, 
#endif

#if GL_OES_REQUIRED_INTERNALFORMAT
    Alpha8Oes = gl.Constants.GL_ALPHA8_OES, 
#endif

#if GL_OES_REQUIRED_INTERNALFORMAT
    Luminance8Oes = gl.Constants.GL_LUMINANCE8_OES, 
#endif

#if GL_OES_REQUIRED_INTERNALFORMAT
    Luminance4Alpha4Oes = gl.Constants.GL_LUMINANCE4_ALPHA4_OES, 
#endif

#if GL_OES_REQUIRED_INTERNALFORMAT
    Luminance8Alpha8Oes = gl.Constants.GL_LUMINANCE8_ALPHA8_OES, 
#endif

#if (GL_OES_REQUIRED_INTERNALFORMAT || GL_OES_RGB8_RGBA8)
    Rgb8Oes = gl.Constants.GL_RGB8_OES, 
#endif

#if (GL_OES_REQUIRED_INTERNALFORMAT || GL_OES_RGB8_RGBA8)
    Rgba8Oes = gl.Constants.GL_RGBA8_OES, 
#endif

#if GL_OES_STENCIL1
    StencilIndex1Oes = gl.Constants.GL_STENCIL_INDEX1_OES, 
#endif

#if GL_OES_STENCIL4
    StencilIndex4Oes = gl.Constants.GL_STENCIL_INDEX4_OES, 
#endif

#if (GL_OES_STENCIL8 || GL_OES_TEXTURE_STENCIL8)
    StencilIndex8Oes = gl.Constants.GL_STENCIL_INDEX8_OES, 
#endif

#if GL_OES_TEXTURE_COMPRESSION_ASTC
    CompressedRgbaAstc3x3x3Oes = gl.Constants.GL_COMPRESSED_RGBA_ASTC_3x3x3_OES, 
#endif

#if GL_OES_TEXTURE_COMPRESSION_ASTC
    CompressedRgbaAstc4x3x3Oes = gl.Constants.GL_COMPRESSED_RGBA_ASTC_4x3x3_OES, 
#endif

#if GL_OES_TEXTURE_COMPRESSION_ASTC
    CompressedRgbaAstc4x4x3Oes = gl.Constants.GL_COMPRESSED_RGBA_ASTC_4x4x3_OES, 
#endif

#if GL_OES_TEXTURE_COMPRESSION_ASTC
    CompressedRgbaAstc4x4x4Oes = gl.Constants.GL_COMPRESSED_RGBA_ASTC_4x4x4_OES, 
#endif

#if GL_OES_TEXTURE_COMPRESSION_ASTC
    CompressedRgbaAstc5x4x4Oes = gl.Constants.GL_COMPRESSED_RGBA_ASTC_5x4x4_OES, 
#endif

#if GL_OES_TEXTURE_COMPRESSION_ASTC
    CompressedRgbaAstc5x5x4Oes = gl.Constants.GL_COMPRESSED_RGBA_ASTC_5x5x4_OES, 
#endif

#if GL_OES_TEXTURE_COMPRESSION_ASTC
    CompressedRgbaAstc5x5x5Oes = gl.Constants.GL_COMPRESSED_RGBA_ASTC_5x5x5_OES, 
#endif

#if GL_OES_TEXTURE_COMPRESSION_ASTC
    CompressedRgbaAstc6x5x5Oes = gl.Constants.GL_COMPRESSED_RGBA_ASTC_6x5x5_OES, 
#endif

#if GL_OES_TEXTURE_COMPRESSION_ASTC
    CompressedRgbaAstc6x6x5Oes = gl.Constants.GL_COMPRESSED_RGBA_ASTC_6x6x5_OES, 
#endif

#if GL_OES_TEXTURE_COMPRESSION_ASTC
    CompressedRgbaAstc6x6x6Oes = gl.Constants.GL_COMPRESSED_RGBA_ASTC_6x6x6_OES, 
#endif

#if GL_OES_TEXTURE_COMPRESSION_ASTC
    CompressedSrgb8Alpha8Astc3x3x3Oes = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_3x3x3_OES, 
#endif

#if GL_OES_TEXTURE_COMPRESSION_ASTC
    CompressedSrgb8Alpha8Astc4x3x3Oes = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x3x3_OES, 
#endif

#if GL_OES_TEXTURE_COMPRESSION_ASTC
    CompressedSrgb8Alpha8Astc4x4x3Oes = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x3_OES, 
#endif

#if GL_OES_TEXTURE_COMPRESSION_ASTC
    CompressedSrgb8Alpha8Astc4x4x4Oes = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x4_OES, 
#endif

#if GL_OES_TEXTURE_COMPRESSION_ASTC
    CompressedSrgb8Alpha8Astc5x4x4Oes = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4x4_OES, 
#endif

#if GL_OES_TEXTURE_COMPRESSION_ASTC
    CompressedSrgb8Alpha8Astc5x5x4Oes = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x4_OES, 
#endif

#if GL_OES_TEXTURE_COMPRESSION_ASTC
    CompressedSrgb8Alpha8Astc5x5x5Oes = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x5_OES, 
#endif

#if GL_OES_TEXTURE_COMPRESSION_ASTC
    CompressedSrgb8Alpha8Astc6x5x5Oes = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5x5_OES, 
#endif

#if GL_OES_TEXTURE_COMPRESSION_ASTC
    CompressedSrgb8Alpha8Astc6x6x5Oes = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x5_OES, 
#endif

#if GL_OES_TEXTURE_COMPRESSION_ASTC
    CompressedSrgb8Alpha8Astc6x6x6Oes = gl.Constants.GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x6_OES, 
#endif

#if GL_SGIX_DEPTH_TEXTURE
    DepthComponent16Sgix = gl.Constants.GL_DEPTH_COMPONENT16_SGIX, 
#endif

#if GL_SGIX_DEPTH_TEXTURE
    DepthComponent24Sgix = gl.Constants.GL_DEPTH_COMPONENT24_SGIX, 
#endif

#if GL_SGIX_DEPTH_TEXTURE
    DepthComponent32Sgix = gl.Constants.GL_DEPTH_COMPONENT32_SGIX, 
#endif

}

#endif
