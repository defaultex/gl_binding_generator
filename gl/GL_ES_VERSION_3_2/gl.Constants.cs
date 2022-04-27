#if (GL_ES_VERSION_3_2 && GLES2_API)
public partial class gles2 { 
    public partial class Constants { 
        public const GLbitfield GL_CONTEXT_FLAG_DEBUG_BIT = 0x00000002;
        public const GLbitfield GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT = 0x00000004;
        public const GLbitfield GL_GEOMETRY_SHADER_BIT = 0x00000004;
        public const GLbitfield GL_TESS_CONTROL_SHADER_BIT = 0x00000008;
        public const GLbitfield GL_TESS_EVALUATION_SHADER_BIT = 0x00000010;

#if !GL_ES_VERSION_2_0
        public const GLenum GL_NO_ERROR = 0;

#endif

#if !GL_ES_VERSION_2_0
        public const GLenum GL_TRIANGLES = 0x0004;

#endif
        public const GLenum GL_QUADS = 0x0007;
        public const GLenum GL_LINES_ADJACENCY = 0x000A;
        public const GLenum GL_LINE_STRIP_ADJACENCY = 0x000B;
        public const GLenum GL_TRIANGLES_ADJACENCY = 0x000C;
        public const GLenum GL_TRIANGLE_STRIP_ADJACENCY = 0x000D;
        public const GLenum GL_PATCHES = 0x000E;

#if !GL_ES_VERSION_2_0
        public const GLenum GL_EQUAL = 0x0202;

#endif
        public const GLenum GL_STACK_OVERFLOW = 0x0503;
        public const GLenum GL_STACK_UNDERFLOW = 0x0504;
        public const GLenum GL_CONTEXT_LOST = 0x0507;

#if !GL_ES_VERSION_2_0
        public const GLenum GL_CW = 0x0900;

#endif

#if !GL_ES_VERSION_2_0
        public const GLenum GL_CCW = 0x0901;

#endif
        public const GLenum GL_TEXTURE_BORDER_COLOR = 0x1004;

#if !GL_ES_VERSION_3_1
        public const GLenum GL_STENCIL_INDEX = 0x1901;

#endif
        public const GLenum GL_VERTEX_ARRAY = 0x8074;
        public const GLenum GL_CLAMP_TO_BORDER = 0x812D;
        public const GLenum GL_CONTEXT_FLAGS = 0x821E;
        public const GLenum GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED = 0x8221;
        public const GLenum GL_DEBUG_OUTPUT_SYNCHRONOUS = 0x8242;
        public const GLenum GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH = 0x8243;
        public const GLenum GL_DEBUG_CALLBACK_FUNCTION = 0x8244;
        public const GLenum GL_DEBUG_CALLBACK_USER_PARAM = 0x8245;
        public const GLenum GL_DEBUG_SOURCE_API = 0x8246;
        public const GLenum GL_DEBUG_SOURCE_WINDOW_SYSTEM = 0x8247;
        public const GLenum GL_DEBUG_SOURCE_SHADER_COMPILER = 0x8248;
        public const GLenum GL_DEBUG_SOURCE_THIRD_PARTY = 0x8249;
        public const GLenum GL_DEBUG_SOURCE_APPLICATION = 0x824A;
        public const GLenum GL_DEBUG_SOURCE_OTHER = 0x824B;
        public const GLenum GL_DEBUG_TYPE_ERROR = 0x824C;
        public const GLenum GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D;
        public const GLenum GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR = 0x824E;
        public const GLenum GL_DEBUG_TYPE_PORTABILITY = 0x824F;
        public const GLenum GL_DEBUG_TYPE_PERFORMANCE = 0x8250;
        public const GLenum GL_DEBUG_TYPE_OTHER = 0x8251;
        public const GLenum GL_LOSE_CONTEXT_ON_RESET = 0x8252;
        public const GLenum GL_GUILTY_CONTEXT_RESET = 0x8253;
        public const GLenum GL_INNOCENT_CONTEXT_RESET = 0x8254;
        public const GLenum GL_UNKNOWN_CONTEXT_RESET = 0x8255;
        public const GLenum GL_RESET_NOTIFICATION_STRATEGY = 0x8256;
        public const GLenum GL_LAYER_PROVOKING_VERTEX = 0x825E;
        public const GLenum GL_UNDEFINED_VERTEX = 0x8260;
        public const GLenum GL_NO_RESET_NOTIFICATION = 0x8261;
        public const GLenum GL_DEBUG_TYPE_MARKER = 0x8268;
        public const GLenum GL_DEBUG_TYPE_PUSH_GROUP = 0x8269;
        public const GLenum GL_DEBUG_TYPE_POP_GROUP = 0x826A;
        public const GLenum GL_DEBUG_SEVERITY_NOTIFICATION = 0x826B;
        public const GLenum GL_MAX_DEBUG_GROUP_STACK_DEPTH = 0x826C;
        public const GLenum GL_DEBUG_GROUP_STACK_DEPTH = 0x826D;
        public const GLenum GL_BUFFER = 0x82E0;
        public const GLenum GL_SHADER = 0x82E1;
        public const GLenum GL_PROGRAM = 0x82E2;
        public const GLenum GL_QUERY = 0x82E3;
        public const GLenum GL_PROGRAM_PIPELINE = 0x82E4;
        public const GLenum GL_SAMPLER = 0x82E6;
        public const GLenum GL_MAX_LABEL_LENGTH = 0x82E8;
        public const GLenum GL_MAX_TESS_CONTROL_INPUT_COMPONENTS = 0x886C;
        public const GLenum GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS = 0x886D;
        public const GLenum GL_GEOMETRY_SHADER_INVOCATIONS = 0x887F;
        public const GLenum GL_GEOMETRY_VERTICES_OUT = 0x8916;
        public const GLenum GL_GEOMETRY_INPUT_TYPE = 0x8917;
        public const GLenum GL_GEOMETRY_OUTPUT_TYPE = 0x8918;
        public const GLenum GL_MAX_GEOMETRY_UNIFORM_BLOCKS = 0x8A2C;
        public const GLenum GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS = 0x8A32;
        public const GLenum GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS = 0x8C29;
        public const GLenum GL_TEXTURE_BUFFER = 0x8C2A;
        public const GLenum GL_TEXTURE_BUFFER_BINDING = 0x8C2A;
        public const GLenum GL_MAX_TEXTURE_BUFFER_SIZE = 0x8C2B;
        public const GLenum GL_TEXTURE_BINDING_BUFFER = 0x8C2C;
        public const GLenum GL_TEXTURE_BUFFER_DATA_STORE_BINDING = 0x8C2D;
        public const GLenum GL_SAMPLE_SHADING = 0x8C36;
        public const GLenum GL_MIN_SAMPLE_SHADING_VALUE = 0x8C37;
        public const GLenum GL_PRIMITIVES_GENERATED = 0x8C87;

#if !GL_ES_VERSION_2_0
        public const GLenum GL_STENCIL_INDEX8 = 0x8D48;

#endif
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_LAYERED = 0x8DA7;
        public const GLenum GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x8DA8;
        public const GLenum GL_SAMPLER_BUFFER = 0x8DC2;
        public const GLenum GL_INT_SAMPLER_BUFFER = 0x8DD0;
        public const GLenum GL_UNSIGNED_INT_SAMPLER_BUFFER = 0x8DD8;
        public const GLenum GL_GEOMETRY_SHADER = 0x8DD9;
        public const GLenum GL_MAX_GEOMETRY_UNIFORM_COMPONENTS = 0x8DDF;
        public const GLenum GL_MAX_GEOMETRY_OUTPUT_VERTICES = 0x8DE0;
        public const GLenum GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS = 0x8DE1;
        public const GLenum GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E1E;
        public const GLenum GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E1F;
        public const GLenum GL_FIRST_VERTEX_CONVENTION = 0x8E4D;
        public const GLenum GL_LAST_VERTEX_CONVENTION = 0x8E4E;
        public const GLenum GL_MAX_GEOMETRY_SHADER_INVOCATIONS = 0x8E5A;
        public const GLenum GL_MIN_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5B;
        public const GLenum GL_MAX_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5C;
        public const GLbitfield GL_FRAGMENT_INTERPOLATION_OFFSET_BITS = 0x8E5D;
        public const GLenum GL_PATCH_VERTICES = 0x8E72;
        public const GLenum GL_TESS_CONTROL_OUTPUT_VERTICES = 0x8E75;
        public const GLenum GL_TESS_GEN_MODE = 0x8E76;
        public const GLenum GL_TESS_GEN_SPACING = 0x8E77;
        public const GLenum GL_TESS_GEN_VERTEX_ORDER = 0x8E78;
        public const GLenum GL_TESS_GEN_POINT_MODE = 0x8E79;
        public const GLenum GL_ISOLINES = 0x8E7A;
        public const GLenum GL_FRACTIONAL_ODD = 0x8E7B;
        public const GLenum GL_FRACTIONAL_EVEN = 0x8E7C;
        public const GLenum GL_MAX_PATCH_VERTICES = 0x8E7D;
        public const GLenum GL_MAX_TESS_GEN_LEVEL = 0x8E7E;
        public const GLenum GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E7F;
        public const GLenum GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E80;
        public const GLenum GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS = 0x8E81;
        public const GLenum GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS = 0x8E82;
        public const GLenum GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS = 0x8E83;
        public const GLenum GL_MAX_TESS_PATCH_COMPONENTS = 0x8E84;
        public const GLenum GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS = 0x8E85;
        public const GLenum GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS = 0x8E86;
        public const GLenum GL_TESS_EVALUATION_SHADER = 0x8E87;
        public const GLenum GL_TESS_CONTROL_SHADER = 0x8E88;
        public const GLenum GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS = 0x8E89;
        public const GLenum GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS = 0x8E8A;
        public const GLenum GL_TEXTURE_CUBE_MAP_ARRAY = 0x9009;
        public const GLenum GL_TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A;
        public const GLenum GL_SAMPLER_CUBE_MAP_ARRAY = 0x900C;
        public const GLenum GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW = 0x900D;
        public const GLenum GL_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900E;
        public const GLenum GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900F;
        public const GLenum GL_IMAGE_BUFFER = 0x9051;
        public const GLenum GL_IMAGE_CUBE_MAP_ARRAY = 0x9054;
        public const GLenum GL_INT_IMAGE_BUFFER = 0x905C;
        public const GLenum GL_INT_IMAGE_CUBE_MAP_ARRAY = 0x905F;
        public const GLenum GL_UNSIGNED_INT_IMAGE_BUFFER = 0x9067;
        public const GLenum GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY = 0x906A;
        public const GLenum GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS = 0x90CB;
        public const GLenum GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS = 0x90CC;
        public const GLenum GL_MAX_GEOMETRY_IMAGE_UNIFORMS = 0x90CD;
        public const GLenum GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS = 0x90D7;
        public const GLenum GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS = 0x90D8;
        public const GLenum GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS = 0x90D9;
        public const GLenum GL_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102;
        public const GLenum GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105;
        public const GLenum GL_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910B;
        public const GLenum GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C;
        public const GLenum GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D;
        public const GLenum GL_MAX_GEOMETRY_INPUT_COMPONENTS = 0x9123;
        public const GLenum GL_MAX_GEOMETRY_OUTPUT_COMPONENTS = 0x9124;
        public const GLenum GL_MAX_DEBUG_MESSAGE_LENGTH = 0x9143;
        public const GLenum GL_MAX_DEBUG_LOGGED_MESSAGES = 0x9144;
        public const GLenum GL_DEBUG_LOGGED_MESSAGES = 0x9145;
        public const GLenum GL_DEBUG_SEVERITY_HIGH = 0x9146;
        public const GLenum GL_DEBUG_SEVERITY_MEDIUM = 0x9147;
        public const GLenum GL_DEBUG_SEVERITY_LOW = 0x9148;
        public const GLenum GL_TEXTURE_BUFFER_OFFSET = 0x919D;
        public const GLenum GL_TEXTURE_BUFFER_SIZE = 0x919E;
        public const GLenum GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT = 0x919F;
        public const GLenum GL_MULTIPLY = 0x9294;
        public const GLenum GL_SCREEN = 0x9295;
        public const GLenum GL_OVERLAY = 0x9296;
        public const GLenum GL_DARKEN = 0x9297;
        public const GLenum GL_LIGHTEN = 0x9298;
        public const GLenum GL_COLORDODGE = 0x9299;
        public const GLenum GL_COLORBURN = 0x929A;
        public const GLenum GL_HARDLIGHT = 0x929B;
        public const GLenum GL_SOFTLIGHT = 0x929C;
        public const GLenum GL_DIFFERENCE = 0x929E;
        public const GLenum GL_EXCLUSION = 0x92A0;
        public const GLenum GL_HSL_HUE = 0x92AD;
        public const GLenum GL_HSL_SATURATION = 0x92AE;
        public const GLenum GL_HSL_COLOR = 0x92AF;
        public const GLenum GL_HSL_LUMINOSITY = 0x92B0;
        public const GLenum GL_PRIMITIVE_BOUNDING_BOX = 0x92BE;
        public const GLenum GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS = 0x92CD;
        public const GLenum GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS = 0x92CE;
        public const GLenum GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS = 0x92CF;
        public const GLenum GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS = 0x92D3;
        public const GLenum GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS = 0x92D4;
        public const GLenum GL_MAX_GEOMETRY_ATOMIC_COUNTERS = 0x92D5;
        public const GLenum GL_DEBUG_OUTPUT = 0x92E0;
        public const GLenum GL_IS_PER_PATCH = 0x92E7;
        public const GLenum GL_REFERENCED_BY_TESS_CONTROL_SHADER = 0x9307;
        public const GLenum GL_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x9308;
        public const GLenum GL_REFERENCED_BY_GEOMETRY_SHADER = 0x9309;
        public const GLenum GL_FRAMEBUFFER_DEFAULT_LAYERS = 0x9312;
        public const GLenum GL_MAX_FRAMEBUFFER_LAYERS = 0x9317;
        public const GLenum GL_MULTISAMPLE_LINE_WIDTH_RANGE = 0x9381;
        public const GLenum GL_MULTISAMPLE_LINE_WIDTH_GRANULARITY = 0x9382;
        public const GLenum GL_COMPRESSED_RGBA_ASTC_4x4 = 0x93B0;
        public const GLenum GL_COMPRESSED_RGBA_ASTC_5x4 = 0x93B1;
        public const GLenum GL_COMPRESSED_RGBA_ASTC_5x5 = 0x93B2;
        public const GLenum GL_COMPRESSED_RGBA_ASTC_6x5 = 0x93B3;
        public const GLenum GL_COMPRESSED_RGBA_ASTC_6x6 = 0x93B4;
        public const GLenum GL_COMPRESSED_RGBA_ASTC_8x5 = 0x93B5;
        public const GLenum GL_COMPRESSED_RGBA_ASTC_8x6 = 0x93B6;
        public const GLenum GL_COMPRESSED_RGBA_ASTC_8x8 = 0x93B7;
        public const GLenum GL_COMPRESSED_RGBA_ASTC_10x5 = 0x93B8;
        public const GLenum GL_COMPRESSED_RGBA_ASTC_10x6 = 0x93B9;
        public const GLenum GL_COMPRESSED_RGBA_ASTC_10x8 = 0x93BA;
        public const GLenum GL_COMPRESSED_RGBA_ASTC_10x10 = 0x93BB;
        public const GLenum GL_COMPRESSED_RGBA_ASTC_12x10 = 0x93BC;
        public const GLenum GL_COMPRESSED_RGBA_ASTC_12x12 = 0x93BD;
        public const GLenum GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4 = 0x93D0;
        public const GLenum GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4 = 0x93D1;
        public const GLenum GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5 = 0x93D2;
        public const GLenum GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5 = 0x93D3;
        public const GLenum GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6 = 0x93D4;
        public const GLenum GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x5 = 0x93D5;
        public const GLenum GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x6 = 0x93D6;
        public const GLenum GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x8 = 0x93D7;
        public const GLenum GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x5 = 0x93D8;
        public const GLenum GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x6 = 0x93D9;
        public const GLenum GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x8 = 0x93DA;
        public const GLenum GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x10 = 0x93DB;
        public const GLenum GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x10 = 0x93DC;
        public const GLenum GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x12 = 0x93DD;
    }
}
#endif