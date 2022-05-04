#if (GL_VERSION_4_3 && GL_API)
public partial class gl { 
    public partial class Constants { 

#if !GL_SC_VERSION_2_0
        public const GLbitfield GL_CONTEXT_FLAG_DEBUG_BIT = 0x00000002;
#endif

#if !GL_SC_VERSION_2_0
        public const GLbitfield GL_COMPUTE_SHADER_BIT = 0x00000020;
#endif

#if !GL_SC_VERSION_2_0
        public const GLbitfield GL_SHADER_STORAGE_BARRIER_BIT = 0x00002000;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_DEBUG_OUTPUT_SYNCHRONOUS = 0x8242;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH = 0x8243;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_DEBUG_CALLBACK_FUNCTION = 0x8244;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_DEBUG_CALLBACK_USER_PARAM = 0x8245;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_DEBUG_SOURCE_API = 0x8246;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_DEBUG_SOURCE_WINDOW_SYSTEM = 0x8247;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_DEBUG_SOURCE_SHADER_COMPILER = 0x8248;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_DEBUG_SOURCE_THIRD_PARTY = 0x8249;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_DEBUG_SOURCE_APPLICATION = 0x824A;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_DEBUG_SOURCE_OTHER = 0x824B;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_DEBUG_TYPE_ERROR = 0x824C;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR = 0x824E;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_DEBUG_TYPE_PORTABILITY = 0x824F;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_DEBUG_TYPE_PERFORMANCE = 0x8250;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_DEBUG_TYPE_OTHER = 0x8251;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_COMPUTE_SHARED_MEMORY_SIZE = 0x8262;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_COMPUTE_UNIFORM_COMPONENTS = 0x8263;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS = 0x8264;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_COMPUTE_ATOMIC_COUNTERS = 0x8265;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS = 0x8266;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_COMPUTE_WORK_GROUP_SIZE = 0x8267;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_DEBUG_TYPE_MARKER = 0x8268;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_DEBUG_TYPE_PUSH_GROUP = 0x8269;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_DEBUG_TYPE_POP_GROUP = 0x826A;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_DEBUG_SEVERITY_NOTIFICATION = 0x826B;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_DEBUG_GROUP_STACK_DEPTH = 0x826C;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_DEBUG_GROUP_STACK_DEPTH = 0x826D;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_UNIFORM_LOCATIONS = 0x826E;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_INTERNALFORMAT_SUPPORTED = 0x826F;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_INTERNALFORMAT_PREFERRED = 0x8270;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_INTERNALFORMAT_RED_SIZE = 0x8271;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_INTERNALFORMAT_GREEN_SIZE = 0x8272;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_INTERNALFORMAT_BLUE_SIZE = 0x8273;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_INTERNALFORMAT_ALPHA_SIZE = 0x8274;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_INTERNALFORMAT_DEPTH_SIZE = 0x8275;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_INTERNALFORMAT_STENCIL_SIZE = 0x8276;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_INTERNALFORMAT_SHARED_SIZE = 0x8277;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_INTERNALFORMAT_RED_TYPE = 0x8278;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_INTERNALFORMAT_GREEN_TYPE = 0x8279;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_INTERNALFORMAT_BLUE_TYPE = 0x827A;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_INTERNALFORMAT_ALPHA_TYPE = 0x827B;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_INTERNALFORMAT_DEPTH_TYPE = 0x827C;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_INTERNALFORMAT_STENCIL_TYPE = 0x827D;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_WIDTH = 0x827E;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_HEIGHT = 0x827F;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_DEPTH = 0x8280;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_LAYERS = 0x8281;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_COMBINED_DIMENSIONS = 0x8282;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_COLOR_COMPONENTS = 0x8283;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_DEPTH_COMPONENTS = 0x8284;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_STENCIL_COMPONENTS = 0x8285;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_COLOR_RENDERABLE = 0x8286;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_DEPTH_RENDERABLE = 0x8287;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_STENCIL_RENDERABLE = 0x8288;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_FRAMEBUFFER_RENDERABLE = 0x8289;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_FRAMEBUFFER_RENDERABLE_LAYERED = 0x828A;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_FRAMEBUFFER_BLEND = 0x828B;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_READ_PIXELS = 0x828C;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_READ_PIXELS_FORMAT = 0x828D;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_READ_PIXELS_TYPE = 0x828E;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_IMAGE_FORMAT = 0x828F;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_IMAGE_TYPE = 0x8290;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_GET_TEXTURE_IMAGE_FORMAT = 0x8291;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_GET_TEXTURE_IMAGE_TYPE = 0x8292;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MIPMAP = 0x8293;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MANUAL_GENERATE_MIPMAP = 0x8294;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_AUTO_GENERATE_MIPMAP = 0x8295;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_COLOR_ENCODING = 0x8296;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_SRGB_READ = 0x8297;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_SRGB_WRITE = 0x8298;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_FILTER = 0x829A;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_VERTEX_TEXTURE = 0x829B;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TESS_CONTROL_TEXTURE = 0x829C;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TESS_EVALUATION_TEXTURE = 0x829D;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_GEOMETRY_TEXTURE = 0x829E;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_FRAGMENT_TEXTURE = 0x829F;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_COMPUTE_TEXTURE = 0x82A0;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_SHADOW = 0x82A1;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_GATHER = 0x82A2;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_GATHER_SHADOW = 0x82A3;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_SHADER_IMAGE_LOAD = 0x82A4;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_SHADER_IMAGE_STORE = 0x82A5;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_SHADER_IMAGE_ATOMIC = 0x82A6;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_IMAGE_TEXEL_SIZE = 0x82A7;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_IMAGE_COMPATIBILITY_CLASS = 0x82A8;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_IMAGE_PIXEL_FORMAT = 0x82A9;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_IMAGE_PIXEL_TYPE = 0x82AA;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST = 0x82AC;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST = 0x82AD;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE = 0x82AE;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE = 0x82AF;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_COMPRESSED_BLOCK_WIDTH = 0x82B1;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT = 0x82B2;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_COMPRESSED_BLOCK_SIZE = 0x82B3;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_CLEAR_BUFFER = 0x82B4;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_VIEW = 0x82B5;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_VIEW_COMPATIBILITY_CLASS = 0x82B6;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_FULL_SUPPORT = 0x82B7;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_CAVEAT_SUPPORT = 0x82B8;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_IMAGE_CLASS_4_X_32 = 0x82B9;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_IMAGE_CLASS_2_X_32 = 0x82BA;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_IMAGE_CLASS_1_X_32 = 0x82BB;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_IMAGE_CLASS_4_X_16 = 0x82BC;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_IMAGE_CLASS_2_X_16 = 0x82BD;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_IMAGE_CLASS_1_X_16 = 0x82BE;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_IMAGE_CLASS_4_X_8 = 0x82BF;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_IMAGE_CLASS_2_X_8 = 0x82C0;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_IMAGE_CLASS_1_X_8 = 0x82C1;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_IMAGE_CLASS_11_11_10 = 0x82C2;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_IMAGE_CLASS_10_10_10_2 = 0x82C3;
#endif

#if !GL_SC_VERSION_2_0
        public const GLbitfield GL_VIEW_CLASS_128_BITS = 0x82C4;
#endif

#if !GL_SC_VERSION_2_0
        public const GLbitfield GL_VIEW_CLASS_96_BITS = 0x82C5;
#endif

#if !GL_SC_VERSION_2_0
        public const GLbitfield GL_VIEW_CLASS_64_BITS = 0x82C6;
#endif

#if !GL_SC_VERSION_2_0
        public const GLbitfield GL_VIEW_CLASS_48_BITS = 0x82C7;
#endif

#if !GL_SC_VERSION_2_0
        public const GLbitfield GL_VIEW_CLASS_32_BITS = 0x82C8;
#endif

#if !GL_SC_VERSION_2_0
        public const GLbitfield GL_VIEW_CLASS_24_BITS = 0x82C9;
#endif

#if !GL_SC_VERSION_2_0
        public const GLbitfield GL_VIEW_CLASS_16_BITS = 0x82CA;
#endif

#if !GL_SC_VERSION_2_0
        public const GLbitfield GL_VIEW_CLASS_8_BITS = 0x82CB;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_VIEW_CLASS_S3TC_DXT1_RGB = 0x82CC;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_VIEW_CLASS_S3TC_DXT1_RGBA = 0x82CD;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_VIEW_CLASS_S3TC_DXT3_RGBA = 0x82CE;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_VIEW_CLASS_S3TC_DXT5_RGBA = 0x82CF;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_VIEW_CLASS_RGTC1_RED = 0x82D0;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_VIEW_CLASS_RGTC2_RG = 0x82D1;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_VIEW_CLASS_BPTC_UNORM = 0x82D2;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_VIEW_CLASS_BPTC_FLOAT = 0x82D3;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_VERTEX_ATTRIB_BINDING = 0x82D4;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_VERTEX_BINDING_DIVISOR = 0x82D6;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_VERTEX_BINDING_OFFSET = 0x82D7;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_VERTEX_BINDING_STRIDE = 0x82D8;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D9;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_VERTEX_ATTRIB_BINDINGS = 0x82DA;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_VIEW_MIN_LEVEL = 0x82DB;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_VIEW_NUM_LEVELS = 0x82DC;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_VIEW_MIN_LAYER = 0x82DD;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_VIEW_NUM_LAYERS = 0x82DE;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_IMMUTABLE_LEVELS = 0x82DF;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_BUFFER = 0x82E0;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_SHADER = 0x82E1;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_PROGRAM = 0x82E2;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_QUERY = 0x82E3;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_PROGRAM_PIPELINE = 0x82E4;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_SAMPLER = 0x82E6;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_DISPLAY_LIST = 0x82E7;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_LABEL_LENGTH = 0x82E8;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_NUM_SHADING_LANGUAGE_VERSIONS = 0x82E9;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_VERTEX_ATTRIB_ARRAY_LONG = 0x874E;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_PRIMITIVE_RESTART_FIXED_INDEX = 0x8D69;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_ELEMENT_INDEX = 0x8D6B;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_COMBINED_SHADER_OUTPUT_RESOURCES = 0x8F39;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_VERTEX_BINDING_BUFFER = 0x8F4F;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_SHADER_STORAGE_BUFFER = 0x90D2;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_SHADER_STORAGE_BUFFER_BINDING = 0x90D3;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_SHADER_STORAGE_BUFFER_START = 0x90D4;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_SHADER_STORAGE_BUFFER_SIZE = 0x90D5;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_VERTEX_SHADER_STORAGE_BLOCKS = 0x90D6;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS = 0x90D7;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS = 0x90D8;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS = 0x90D9;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_FRAGMENT_SHADER_STORAGE_BLOCKS = 0x90DA;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_COMPUTE_SHADER_STORAGE_BLOCKS = 0x90DB;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_COMBINED_SHADER_STORAGE_BLOCKS = 0x90DC;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_SHADER_STORAGE_BUFFER_BINDINGS = 0x90DD;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_SHADER_STORAGE_BLOCK_SIZE = 0x90DE;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT = 0x90DF;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_DEPTH_STENCIL_TEXTURE_MODE = 0x90EA;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_COMPUTE_WORK_GROUP_INVOCATIONS = 0x90EB;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER = 0x90EC;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER = 0x90ED;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_DISPATCH_INDIRECT_BUFFER = 0x90EE;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_DISPATCH_INDIRECT_BUFFER_BINDING = 0x90EF;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_DEBUG_MESSAGE_LENGTH = 0x9143;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_DEBUG_LOGGED_MESSAGES = 0x9144;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_DEBUG_LOGGED_MESSAGES = 0x9145;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_DEBUG_SEVERITY_HIGH = 0x9146;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_DEBUG_SEVERITY_MEDIUM = 0x9147;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_DEBUG_SEVERITY_LOW = 0x9148;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_BUFFER_OFFSET = 0x919D;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_BUFFER_SIZE = 0x919E;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT = 0x919F;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_COMPUTE_SHADER = 0x91B9;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_COMPUTE_UNIFORM_BLOCKS = 0x91BB;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_COMPUTE_TEXTURE_IMAGE_UNITS = 0x91BC;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_COMPUTE_IMAGE_UNIFORMS = 0x91BD;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_COMPUTE_WORK_GROUP_COUNT = 0x91BE;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_COMPUTE_WORK_GROUP_SIZE = 0x91BF;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_COMPRESSED_R11_EAC = 0x9270;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_COMPRESSED_SIGNED_R11_EAC = 0x9271;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_COMPRESSED_RG11_EAC = 0x9272;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_COMPRESSED_SIGNED_RG11_EAC = 0x9273;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_COMPRESSED_RGB8_ETC2 = 0x9274;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_COMPRESSED_SRGB8_ETC2 = 0x9275;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_COMPRESSED_RGBA8_ETC2_EAC = 0x9278;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_DEBUG_OUTPUT = 0x92E0;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_UNIFORM = 0x92E1;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_UNIFORM_BLOCK = 0x92E2;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_PROGRAM_INPUT = 0x92E3;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_PROGRAM_OUTPUT = 0x92E4;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_BUFFER_VARIABLE = 0x92E5;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_SHADER_STORAGE_BLOCK = 0x92E6;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_IS_PER_PATCH = 0x92E7;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_VERTEX_SUBROUTINE = 0x92E8;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TESS_CONTROL_SUBROUTINE = 0x92E9;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TESS_EVALUATION_SUBROUTINE = 0x92EA;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_GEOMETRY_SUBROUTINE = 0x92EB;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_FRAGMENT_SUBROUTINE = 0x92EC;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_COMPUTE_SUBROUTINE = 0x92ED;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_VERTEX_SUBROUTINE_UNIFORM = 0x92EE;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TESS_CONTROL_SUBROUTINE_UNIFORM = 0x92EF;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TESS_EVALUATION_SUBROUTINE_UNIFORM = 0x92F0;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_GEOMETRY_SUBROUTINE_UNIFORM = 0x92F1;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_FRAGMENT_SUBROUTINE_UNIFORM = 0x92F2;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_COMPUTE_SUBROUTINE_UNIFORM = 0x92F3;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TRANSFORM_FEEDBACK_VARYING = 0x92F4;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_ACTIVE_RESOURCES = 0x92F5;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_NAME_LENGTH = 0x92F6;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_NUM_ACTIVE_VARIABLES = 0x92F7;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_NUM_COMPATIBLE_SUBROUTINES = 0x92F8;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_NAME_LENGTH = 0x92F9;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TYPE = 0x92FA;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_ARRAY_SIZE = 0x92FB;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_OFFSET = 0x92FC;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_BLOCK_INDEX = 0x92FD;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_ARRAY_STRIDE = 0x92FE;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MATRIX_STRIDE = 0x92FF;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_IS_ROW_MAJOR = 0x9300;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_ATOMIC_COUNTER_BUFFER_INDEX = 0x9301;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_BUFFER_BINDING = 0x9302;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_BUFFER_DATA_SIZE = 0x9303;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_NUM_ACTIVE_VARIABLES = 0x9304;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_ACTIVE_VARIABLES = 0x9305;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_REFERENCED_BY_VERTEX_SHADER = 0x9306;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_REFERENCED_BY_TESS_CONTROL_SHADER = 0x9307;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x9308;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_REFERENCED_BY_GEOMETRY_SHADER = 0x9309;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_REFERENCED_BY_FRAGMENT_SHADER = 0x930A;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_REFERENCED_BY_COMPUTE_SHADER = 0x930B;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TOP_LEVEL_ARRAY_SIZE = 0x930C;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TOP_LEVEL_ARRAY_STRIDE = 0x930D;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_LOCATION = 0x930E;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_LOCATION_INDEX = 0x930F;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_FRAMEBUFFER_DEFAULT_WIDTH = 0x9310;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_FRAMEBUFFER_DEFAULT_LAYERS = 0x9312;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_FRAMEBUFFER_WIDTH = 0x9315;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_FRAMEBUFFER_HEIGHT = 0x9316;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_FRAMEBUFFER_LAYERS = 0x9317;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_FRAMEBUFFER_SAMPLES = 0x9318;
#endif
    }
}
#endif