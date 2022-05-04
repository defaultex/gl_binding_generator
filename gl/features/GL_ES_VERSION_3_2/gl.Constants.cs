#if (GL_ES_VERSION_3_2 && GLES2_API)
public partial class gles2 { 
    public partial class Constants { 

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_NO_ERROR = 0;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_CONTEXT_FLAG_DEBUG_BIT = 0x00000002;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT = 0x00000004;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_GEOMETRY_SHADER_BIT = 0x00000004;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TRIANGLES = 0x0004;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_QUADS = 0x0007;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_TESS_CONTROL_SHADER_BIT = 0x00000008;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_LINES_ADJACENCY = 0x000A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_LINE_STRIP_ADJACENCY = 0x000B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TRIANGLES_ADJACENCY = 0x000C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TRIANGLE_STRIP_ADJACENCY = 0x000D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PATCHES = 0x000E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_TESS_EVALUATION_SHADER_BIT = 0x00000010;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_EQUAL = 0x0202;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_STACK_OVERFLOW = 0x0503;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_STACK_UNDERFLOW = 0x0504;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_CONTEXT_LOST = 0x0507;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_CW = 0x0900;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_CCW = 0x0901;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_BORDER_COLOR = 0x1004;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_STENCIL_INDEX = 0x1901;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_VERTEX_ARRAY = 0x8074;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_CLAMP_TO_BORDER = 0x812D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_CONTEXT_FLAGS = 0x821E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED = 0x8221;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_OUTPUT_SYNCHRONOUS = 0x8242;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH = 0x8243;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_CALLBACK_FUNCTION = 0x8244;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_CALLBACK_USER_PARAM = 0x8245;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_SOURCE_API = 0x8246;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_SOURCE_WINDOW_SYSTEM = 0x8247;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_SOURCE_SHADER_COMPILER = 0x8248;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_SOURCE_THIRD_PARTY = 0x8249;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_SOURCE_APPLICATION = 0x824A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_SOURCE_OTHER = 0x824B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_TYPE_ERROR = 0x824C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR = 0x824E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_TYPE_PORTABILITY = 0x824F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_TYPE_PERFORMANCE = 0x8250;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_TYPE_OTHER = 0x8251;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_LOSE_CONTEXT_ON_RESET = 0x8252;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_GUILTY_CONTEXT_RESET = 0x8253;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_INNOCENT_CONTEXT_RESET = 0x8254;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNKNOWN_CONTEXT_RESET = 0x8255;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RESET_NOTIFICATION_STRATEGY = 0x8256;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_LAYER_PROVOKING_VERTEX = 0x825E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNDEFINED_VERTEX = 0x8260;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_NO_RESET_NOTIFICATION = 0x8261;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_TYPE_MARKER = 0x8268;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_TYPE_PUSH_GROUP = 0x8269;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_TYPE_POP_GROUP = 0x826A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_SEVERITY_NOTIFICATION = 0x826B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_DEBUG_GROUP_STACK_DEPTH = 0x826C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_GROUP_STACK_DEPTH = 0x826D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_BUFFER = 0x82E0;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SHADER = 0x82E1;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PROGRAM = 0x82E2;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_QUERY = 0x82E3;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PROGRAM_PIPELINE = 0x82E4;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SAMPLER = 0x82E6;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_LABEL_LENGTH = 0x82E8;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TESS_CONTROL_INPUT_COMPONENTS = 0x886C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS = 0x886D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_GEOMETRY_SHADER_INVOCATIONS = 0x887F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_GEOMETRY_VERTICES_OUT = 0x8916;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_GEOMETRY_INPUT_TYPE = 0x8917;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_GEOMETRY_OUTPUT_TYPE = 0x8918;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_GEOMETRY_UNIFORM_BLOCKS = 0x8A2C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS = 0x8A32;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS = 0x8C29;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_BUFFER = 0x8C2A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_BUFFER_BINDING = 0x8C2A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TEXTURE_BUFFER_SIZE = 0x8C2B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_BINDING_BUFFER = 0x8C2C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_BUFFER_DATA_STORE_BINDING = 0x8C2D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SAMPLE_SHADING = 0x8C36;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MIN_SAMPLE_SHADING_VALUE = 0x8C37;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PRIMITIVES_GENERATED = 0x8C87;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_STENCIL_INDEX8 = 0x8D48;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_LAYERED = 0x8DA7;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x8DA8;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SAMPLER_BUFFER = 0x8DC2;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_INT_SAMPLER_BUFFER = 0x8DD0;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_SAMPLER_BUFFER = 0x8DD8;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_GEOMETRY_SHADER = 0x8DD9;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_GEOMETRY_UNIFORM_COMPONENTS = 0x8DDF;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_GEOMETRY_OUTPUT_VERTICES = 0x8DE0;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS = 0x8DE1;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E1E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E1F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FIRST_VERTEX_CONVENTION = 0x8E4D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_LAST_VERTEX_CONVENTION = 0x8E4E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_GEOMETRY_SHADER_INVOCATIONS = 0x8E5A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MIN_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_FRAGMENT_INTERPOLATION_OFFSET_BITS = 0x8E5D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PATCH_VERTICES = 0x8E72;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TESS_CONTROL_OUTPUT_VERTICES = 0x8E75;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TESS_GEN_MODE = 0x8E76;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TESS_GEN_SPACING = 0x8E77;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TESS_GEN_VERTEX_ORDER = 0x8E78;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TESS_GEN_POINT_MODE = 0x8E79;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_ISOLINES = 0x8E7A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRACTIONAL_ODD = 0x8E7B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRACTIONAL_EVEN = 0x8E7C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_PATCH_VERTICES = 0x8E7D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TESS_GEN_LEVEL = 0x8E7E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E7F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E80;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS = 0x8E81;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS = 0x8E82;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS = 0x8E83;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TESS_PATCH_COMPONENTS = 0x8E84;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS = 0x8E85;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS = 0x8E86;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TESS_EVALUATION_SHADER = 0x8E87;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TESS_CONTROL_SHADER = 0x8E88;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS = 0x8E89;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS = 0x8E8A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_CUBE_MAP_ARRAY = 0x9009;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SAMPLER_CUBE_MAP_ARRAY = 0x900C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW = 0x900D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_IMAGE_BUFFER = 0x9051;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_IMAGE_CUBE_MAP_ARRAY = 0x9054;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_INT_IMAGE_BUFFER = 0x905C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_INT_IMAGE_CUBE_MAP_ARRAY = 0x905F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_IMAGE_BUFFER = 0x9067;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY = 0x906A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS = 0x90CB;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS = 0x90CC;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_GEOMETRY_IMAGE_UNIFORMS = 0x90CD;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS = 0x90D7;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS = 0x90D8;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS = 0x90D9;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_GEOMETRY_INPUT_COMPONENTS = 0x9123;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_GEOMETRY_OUTPUT_COMPONENTS = 0x9124;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_DEBUG_MESSAGE_LENGTH = 0x9143;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_DEBUG_LOGGED_MESSAGES = 0x9144;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_LOGGED_MESSAGES = 0x9145;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_SEVERITY_HIGH = 0x9146;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_SEVERITY_MEDIUM = 0x9147;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_SEVERITY_LOW = 0x9148;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_BUFFER_OFFSET = 0x919D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_BUFFER_SIZE = 0x919E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT = 0x919F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MULTIPLY = 0x9294;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SCREEN = 0x9295;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_OVERLAY = 0x9296;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DARKEN = 0x9297;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_LIGHTEN = 0x9298;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLORDODGE = 0x9299;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLORBURN = 0x929A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_HARDLIGHT = 0x929B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SOFTLIGHT = 0x929C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DIFFERENCE = 0x929E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_EXCLUSION = 0x92A0;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_HSL_HUE = 0x92AD;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_HSL_SATURATION = 0x92AE;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_HSL_COLOR = 0x92AF;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_HSL_LUMINOSITY = 0x92B0;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PRIMITIVE_BOUNDING_BOX = 0x92BE;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS = 0x92CD;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS = 0x92CE;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS = 0x92CF;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS = 0x92D3;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS = 0x92D4;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_GEOMETRY_ATOMIC_COUNTERS = 0x92D5;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEBUG_OUTPUT = 0x92E0;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_IS_PER_PATCH = 0x92E7;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_REFERENCED_BY_TESS_CONTROL_SHADER = 0x9307;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x9308;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_REFERENCED_BY_GEOMETRY_SHADER = 0x9309;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_DEFAULT_LAYERS = 0x9312;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_FRAMEBUFFER_LAYERS = 0x9317;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MULTISAMPLE_LINE_WIDTH_RANGE = 0x9381;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MULTISAMPLE_LINE_WIDTH_GRANULARITY = 0x9382;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_RGBA_ASTC_4x4 = 0x93B0;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_RGBA_ASTC_5x4 = 0x93B1;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_RGBA_ASTC_5x5 = 0x93B2;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_RGBA_ASTC_6x5 = 0x93B3;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_RGBA_ASTC_6x6 = 0x93B4;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_RGBA_ASTC_8x5 = 0x93B5;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_RGBA_ASTC_8x6 = 0x93B6;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_RGBA_ASTC_8x8 = 0x93B7;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_RGBA_ASTC_10x5 = 0x93B8;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_RGBA_ASTC_10x6 = 0x93B9;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_RGBA_ASTC_10x8 = 0x93BA;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_RGBA_ASTC_10x10 = 0x93BB;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_RGBA_ASTC_12x10 = 0x93BC;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_RGBA_ASTC_12x12 = 0x93BD;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4 = 0x93D0;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4 = 0x93D1;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5 = 0x93D2;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5 = 0x93D3;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6 = 0x93D4;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x5 = 0x93D5;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x6 = 0x93D6;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x8 = 0x93D7;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x5 = 0x93D8;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x6 = 0x93D9;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x8 = 0x93DA;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x10 = 0x93DB;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x10 = 0x93DC;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x12 = 0x93DD;
#endif
    }
}
#endif