#if (GL_ARB_internalformat_query2 && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_1D = 0x0DE0;
        public const GLenum GL_TEXTURE_2D = 0x0DE1;
        public const GLenum GL_TEXTURE_3D = 0x806F;
        public const GLenum GL_SAMPLES = 0x80A9;
        public const GLenum GL_INTERNALFORMAT_SUPPORTED = 0x826F;
        public const GLenum GL_INTERNALFORMAT_PREFERRED = 0x8270;
        public const GLenum GL_INTERNALFORMAT_RED_SIZE = 0x8271;
        public const GLenum GL_INTERNALFORMAT_GREEN_SIZE = 0x8272;
        public const GLenum GL_INTERNALFORMAT_BLUE_SIZE = 0x8273;
        public const GLenum GL_INTERNALFORMAT_ALPHA_SIZE = 0x8274;
        public const GLenum GL_INTERNALFORMAT_DEPTH_SIZE = 0x8275;
        public const GLenum GL_INTERNALFORMAT_STENCIL_SIZE = 0x8276;
        public const GLenum GL_INTERNALFORMAT_SHARED_SIZE = 0x8277;
        public const GLenum GL_INTERNALFORMAT_RED_TYPE = 0x8278;
        public const GLenum GL_INTERNALFORMAT_GREEN_TYPE = 0x8279;
        public const GLenum GL_INTERNALFORMAT_BLUE_TYPE = 0x827A;
        public const GLenum GL_INTERNALFORMAT_ALPHA_TYPE = 0x827B;
        public const GLenum GL_INTERNALFORMAT_DEPTH_TYPE = 0x827C;
        public const GLenum GL_INTERNALFORMAT_STENCIL_TYPE = 0x827D;
        public const GLenum GL_MAX_WIDTH = 0x827E;
        public const GLenum GL_MAX_HEIGHT = 0x827F;
        public const GLenum GL_MAX_DEPTH = 0x8280;
        public const GLenum GL_MAX_LAYERS = 0x8281;
        public const GLenum GL_MAX_COMBINED_DIMENSIONS = 0x8282;
        public const GLenum GL_COLOR_COMPONENTS = 0x8283;
        public const GLenum GL_DEPTH_COMPONENTS = 0x8284;
        public const GLenum GL_STENCIL_COMPONENTS = 0x8285;
        public const GLenum GL_COLOR_RENDERABLE = 0x8286;
        public const GLenum GL_DEPTH_RENDERABLE = 0x8287;
        public const GLenum GL_STENCIL_RENDERABLE = 0x8288;
        public const GLenum GL_FRAMEBUFFER_RENDERABLE = 0x8289;
        public const GLenum GL_FRAMEBUFFER_RENDERABLE_LAYERED = 0x828A;
        public const GLenum GL_FRAMEBUFFER_BLEND = 0x828B;
        public const GLenum GL_READ_PIXELS = 0x828C;
        public const GLenum GL_READ_PIXELS_FORMAT = 0x828D;
        public const GLenum GL_READ_PIXELS_TYPE = 0x828E;
        public const GLenum GL_TEXTURE_IMAGE_FORMAT = 0x828F;
        public const GLenum GL_TEXTURE_IMAGE_TYPE = 0x8290;
        public const GLenum GL_GET_TEXTURE_IMAGE_FORMAT = 0x8291;
        public const GLenum GL_GET_TEXTURE_IMAGE_TYPE = 0x8292;
        public const GLenum GL_MIPMAP = 0x8293;
        public const GLenum GL_MANUAL_GENERATE_MIPMAP = 0x8294;
        public const GLenum GL_AUTO_GENERATE_MIPMAP = 0x8295;
        public const GLenum GL_COLOR_ENCODING = 0x8296;
        public const GLenum GL_SRGB_READ = 0x8297;
        public const GLenum GL_SRGB_WRITE = 0x8298;
        public const GLenum GL_SRGB_DECODE_ARB = 0x8299;
        public const GLenum GL_FILTER = 0x829A;
        public const GLenum GL_VERTEX_TEXTURE = 0x829B;
        public const GLenum GL_TESS_CONTROL_TEXTURE = 0x829C;
        public const GLenum GL_TESS_EVALUATION_TEXTURE = 0x829D;
        public const GLenum GL_GEOMETRY_TEXTURE = 0x829E;
        public const GLenum GL_FRAGMENT_TEXTURE = 0x829F;
        public const GLenum GL_COMPUTE_TEXTURE = 0x82A0;
        public const GLenum GL_TEXTURE_SHADOW = 0x82A1;
        public const GLenum GL_TEXTURE_GATHER = 0x82A2;
        public const GLenum GL_TEXTURE_GATHER_SHADOW = 0x82A3;
        public const GLenum GL_SHADER_IMAGE_LOAD = 0x82A4;
        public const GLenum GL_SHADER_IMAGE_STORE = 0x82A5;
        public const GLenum GL_SHADER_IMAGE_ATOMIC = 0x82A6;
        public const GLenum GL_IMAGE_TEXEL_SIZE = 0x82A7;
        public const GLenum GL_IMAGE_COMPATIBILITY_CLASS = 0x82A8;
        public const GLenum GL_IMAGE_PIXEL_FORMAT = 0x82A9;
        public const GLenum GL_IMAGE_PIXEL_TYPE = 0x82AA;
        public const GLenum GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST = 0x82AC;
        public const GLenum GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST = 0x82AD;
        public const GLenum GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE = 0x82AE;
        public const GLenum GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE = 0x82AF;
        public const GLenum GL_TEXTURE_COMPRESSED_BLOCK_WIDTH = 0x82B1;
        public const GLenum GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT = 0x82B2;
        public const GLenum GL_TEXTURE_COMPRESSED_BLOCK_SIZE = 0x82B3;
        public const GLenum GL_CLEAR_BUFFER = 0x82B4;
        public const GLenum GL_TEXTURE_VIEW = 0x82B5;
        public const GLenum GL_VIEW_COMPATIBILITY_CLASS = 0x82B6;
        public const GLenum GL_FULL_SUPPORT = 0x82B7;
        public const GLenum GL_CAVEAT_SUPPORT = 0x82B8;
        public const GLenum GL_IMAGE_CLASS_4_X_32 = 0x82B9;
        public const GLenum GL_IMAGE_CLASS_2_X_32 = 0x82BA;
        public const GLenum GL_IMAGE_CLASS_1_X_32 = 0x82BB;
        public const GLenum GL_IMAGE_CLASS_4_X_16 = 0x82BC;
        public const GLenum GL_IMAGE_CLASS_2_X_16 = 0x82BD;
        public const GLenum GL_IMAGE_CLASS_1_X_16 = 0x82BE;
        public const GLenum GL_IMAGE_CLASS_4_X_8 = 0x82BF;
        public const GLenum GL_IMAGE_CLASS_2_X_8 = 0x82C0;
        public const GLenum GL_IMAGE_CLASS_1_X_8 = 0x82C1;
        public const GLenum GL_IMAGE_CLASS_11_11_10 = 0x82C2;
        public const GLenum GL_IMAGE_CLASS_10_10_10_2 = 0x82C3;
        public const GLbitfield GL_VIEW_CLASS_128_BITS = 0x82C4;
        public const GLbitfield GL_VIEW_CLASS_96_BITS = 0x82C5;
        public const GLbitfield GL_VIEW_CLASS_64_BITS = 0x82C6;
        public const GLbitfield GL_VIEW_CLASS_48_BITS = 0x82C7;
        public const GLbitfield GL_VIEW_CLASS_32_BITS = 0x82C8;
        public const GLbitfield GL_VIEW_CLASS_24_BITS = 0x82C9;
        public const GLbitfield GL_VIEW_CLASS_16_BITS = 0x82CA;
        public const GLbitfield GL_VIEW_CLASS_8_BITS = 0x82CB;
        public const GLenum GL_VIEW_CLASS_S3TC_DXT1_RGB = 0x82CC;
        public const GLenum GL_VIEW_CLASS_S3TC_DXT1_RGBA = 0x82CD;
        public const GLenum GL_VIEW_CLASS_S3TC_DXT3_RGBA = 0x82CE;
        public const GLenum GL_VIEW_CLASS_S3TC_DXT5_RGBA = 0x82CF;
        public const GLenum GL_VIEW_CLASS_RGTC1_RED = 0x82D0;
        public const GLenum GL_VIEW_CLASS_RGTC2_RG = 0x82D1;
        public const GLenum GL_VIEW_CLASS_BPTC_UNORM = 0x82D2;
        public const GLenum GL_VIEW_CLASS_BPTC_FLOAT = 0x82D3;
        public const GLenum GL_TEXTURE_RECTANGLE = 0x84F5;
        public const GLenum GL_TEXTURE_CUBE_MAP = 0x8513;
        public const GLenum GL_TEXTURE_COMPRESSED = 0x86A1;
        public const GLenum GL_TEXTURE_1D_ARRAY = 0x8C18;
        public const GLenum GL_TEXTURE_2D_ARRAY = 0x8C1A;
        public const GLenum GL_TEXTURE_BUFFER = 0x8C2A;
        public const GLenum GL_RENDERBUFFER = 0x8D41;
        public const GLenum GL_TEXTURE_CUBE_MAP_ARRAY = 0x9009;
        public const GLenum GL_IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7;
        public const GLenum GL_TEXTURE_2D_MULTISAMPLE = 0x9100;
        public const GLenum GL_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102;
        public const GLenum GL_NUM_SAMPLE_COUNTS = 0x9380;
        public const GLenum GL_VIEW_CLASS_EAC_R11 = 0x9383;
        public const GLenum GL_VIEW_CLASS_EAC_RG11 = 0x9384;
        public const GLenum GL_VIEW_CLASS_ETC2_RGB = 0x9385;
        public const GLenum GL_VIEW_CLASS_ETC2_RGBA = 0x9386;
        public const GLenum GL_VIEW_CLASS_ETC2_EAC_RGBA = 0x9387;
        public const GLenum GL_VIEW_CLASS_ASTC_4x4_RGBA = 0x9388;
        public const GLenum GL_VIEW_CLASS_ASTC_5x4_RGBA = 0x9389;
        public const GLenum GL_VIEW_CLASS_ASTC_5x5_RGBA = 0x938A;
        public const GLenum GL_VIEW_CLASS_ASTC_6x5_RGBA = 0x938B;
        public const GLenum GL_VIEW_CLASS_ASTC_6x6_RGBA = 0x938C;
        public const GLenum GL_VIEW_CLASS_ASTC_8x5_RGBA = 0x938D;
        public const GLenum GL_VIEW_CLASS_ASTC_8x6_RGBA = 0x938E;
        public const GLenum GL_VIEW_CLASS_ASTC_8x8_RGBA = 0x938F;
        public const GLenum GL_VIEW_CLASS_ASTC_10x5_RGBA = 0x9390;
        public const GLenum GL_VIEW_CLASS_ASTC_10x6_RGBA = 0x9391;
        public const GLenum GL_VIEW_CLASS_ASTC_10x8_RGBA = 0x9392;
        public const GLenum GL_VIEW_CLASS_ASTC_10x10_RGBA = 0x9393;
        public const GLenum GL_VIEW_CLASS_ASTC_12x10_RGBA = 0x9394;
        public const GLenum GL_VIEW_CLASS_ASTC_12x12_RGBA = 0x9395;
    }
}
#endif