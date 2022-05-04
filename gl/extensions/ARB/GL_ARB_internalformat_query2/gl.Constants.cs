#if (GL_ARB_internalformat_query2 && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_1D = 0x0DE0;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_2D = 0x0DE1;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_3D = 0x806F;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_SAMPLES = 0x80A9;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_INTERNALFORMAT_SUPPORTED = 0x826F;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_INTERNALFORMAT_PREFERRED = 0x8270;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_INTERNALFORMAT_RED_SIZE = 0x8271;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_INTERNALFORMAT_GREEN_SIZE = 0x8272;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_INTERNALFORMAT_BLUE_SIZE = 0x8273;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_INTERNALFORMAT_ALPHA_SIZE = 0x8274;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_INTERNALFORMAT_DEPTH_SIZE = 0x8275;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_INTERNALFORMAT_STENCIL_SIZE = 0x8276;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_INTERNALFORMAT_SHARED_SIZE = 0x8277;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_INTERNALFORMAT_RED_TYPE = 0x8278;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_INTERNALFORMAT_GREEN_TYPE = 0x8279;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_INTERNALFORMAT_BLUE_TYPE = 0x827A;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_INTERNALFORMAT_ALPHA_TYPE = 0x827B;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_INTERNALFORMAT_DEPTH_TYPE = 0x827C;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_INTERNALFORMAT_STENCIL_TYPE = 0x827D;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_WIDTH = 0x827E;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_HEIGHT = 0x827F;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_DEPTH = 0x8280;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_LAYERS = 0x8281;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_COMBINED_DIMENSIONS = 0x8282;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_COMPONENTS = 0x8283;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEPTH_COMPONENTS = 0x8284;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_STENCIL_COMPONENTS = 0x8285;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_RENDERABLE = 0x8286;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEPTH_RENDERABLE = 0x8287;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_STENCIL_RENDERABLE = 0x8288;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_RENDERABLE = 0x8289;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_RENDERABLE_LAYERED = 0x828A;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_BLEND = 0x828B;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_READ_PIXELS = 0x828C;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_READ_PIXELS_FORMAT = 0x828D;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_READ_PIXELS_TYPE = 0x828E;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_IMAGE_FORMAT = 0x828F;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_IMAGE_TYPE = 0x8290;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_GET_TEXTURE_IMAGE_FORMAT = 0x8291;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_GET_TEXTURE_IMAGE_TYPE = 0x8292;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_MIPMAP = 0x8293;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_MANUAL_GENERATE_MIPMAP = 0x8294;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_AUTO_GENERATE_MIPMAP = 0x8295;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ENCODING = 0x8296;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_SRGB_READ = 0x8297;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_SRGB_WRITE = 0x8298;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SRGB_DECODE_ARB = 0x8299;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_FILTER = 0x829A;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_VERTEX_TEXTURE = 0x829B;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TESS_CONTROL_TEXTURE = 0x829C;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TESS_EVALUATION_TEXTURE = 0x829D;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_GEOMETRY_TEXTURE = 0x829E;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_FRAGMENT_TEXTURE = 0x829F;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_COMPUTE_TEXTURE = 0x82A0;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_SHADOW = 0x82A1;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_GATHER = 0x82A2;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_GATHER_SHADOW = 0x82A3;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_SHADER_IMAGE_LOAD = 0x82A4;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_SHADER_IMAGE_STORE = 0x82A5;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_SHADER_IMAGE_ATOMIC = 0x82A6;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_IMAGE_TEXEL_SIZE = 0x82A7;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_IMAGE_COMPATIBILITY_CLASS = 0x82A8;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_IMAGE_PIXEL_FORMAT = 0x82A9;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_IMAGE_PIXEL_TYPE = 0x82AA;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST = 0x82AC;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST = 0x82AD;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE = 0x82AE;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE = 0x82AF;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_COMPRESSED_BLOCK_WIDTH = 0x82B1;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT = 0x82B2;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_COMPRESSED_BLOCK_SIZE = 0x82B3;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_CLEAR_BUFFER = 0x82B4;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_VIEW = 0x82B5;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_VIEW_COMPATIBILITY_CLASS = 0x82B6;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_FULL_SUPPORT = 0x82B7;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_CAVEAT_SUPPORT = 0x82B8;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_IMAGE_CLASS_4_X_32 = 0x82B9;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_IMAGE_CLASS_2_X_32 = 0x82BA;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_IMAGE_CLASS_1_X_32 = 0x82BB;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_IMAGE_CLASS_4_X_16 = 0x82BC;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_IMAGE_CLASS_2_X_16 = 0x82BD;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_IMAGE_CLASS_1_X_16 = 0x82BE;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_IMAGE_CLASS_4_X_8 = 0x82BF;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_IMAGE_CLASS_2_X_8 = 0x82C0;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_IMAGE_CLASS_1_X_8 = 0x82C1;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_IMAGE_CLASS_11_11_10 = 0x82C2;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_IMAGE_CLASS_10_10_10_2 = 0x82C3;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_VIEW_CLASS_128_BITS = 0x82C4;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_VIEW_CLASS_96_BITS = 0x82C5;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_VIEW_CLASS_64_BITS = 0x82C6;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_VIEW_CLASS_48_BITS = 0x82C7;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_VIEW_CLASS_32_BITS = 0x82C8;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_VIEW_CLASS_24_BITS = 0x82C9;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_VIEW_CLASS_16_BITS = 0x82CA;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_VIEW_CLASS_8_BITS = 0x82CB;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_VIEW_CLASS_S3TC_DXT1_RGB = 0x82CC;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_VIEW_CLASS_S3TC_DXT1_RGBA = 0x82CD;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_VIEW_CLASS_S3TC_DXT3_RGBA = 0x82CE;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_VIEW_CLASS_S3TC_DXT5_RGBA = 0x82CF;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_VIEW_CLASS_RGTC1_RED = 0x82D0;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_VIEW_CLASS_RGTC2_RG = 0x82D1;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_VIEW_CLASS_BPTC_UNORM = 0x82D2;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_VIEW_CLASS_BPTC_FLOAT = 0x82D3;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_RECTANGLE = 0x84F5;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_CUBE_MAP = 0x8513;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_COMPRESSED = 0x86A1;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_1D_ARRAY = 0x8C18;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_2D_ARRAY = 0x8C1A;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_BUFFER = 0x8C2A;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_RENDERBUFFER = 0x8D41;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_CUBE_MAP_ARRAY = 0x9009;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_2D_MULTISAMPLE = 0x9100;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_NUM_SAMPLE_COUNTS = 0x9380;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEW_CLASS_EAC_R11 = 0x9383;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEW_CLASS_EAC_RG11 = 0x9384;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEW_CLASS_ETC2_RGB = 0x9385;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEW_CLASS_ETC2_RGBA = 0x9386;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEW_CLASS_ETC2_EAC_RGBA = 0x9387;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEW_CLASS_ASTC_4x4_RGBA = 0x9388;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEW_CLASS_ASTC_5x4_RGBA = 0x9389;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEW_CLASS_ASTC_5x5_RGBA = 0x938A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEW_CLASS_ASTC_6x5_RGBA = 0x938B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEW_CLASS_ASTC_6x6_RGBA = 0x938C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEW_CLASS_ASTC_8x5_RGBA = 0x938D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEW_CLASS_ASTC_8x6_RGBA = 0x938E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEW_CLASS_ASTC_8x8_RGBA = 0x938F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEW_CLASS_ASTC_10x5_RGBA = 0x9390;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEW_CLASS_ASTC_10x6_RGBA = 0x9391;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEW_CLASS_ASTC_10x8_RGBA = 0x9392;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEW_CLASS_ASTC_10x10_RGBA = 0x9393;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEW_CLASS_ASTC_12x10_RGBA = 0x9394;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VIEW_CLASS_ASTC_12x12_RGBA = 0x9395;
#endif
    }
}
#endif