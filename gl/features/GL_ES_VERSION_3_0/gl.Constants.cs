#if (GL_ES_VERSION_3_0 && GLES2_API)
public partial class gles2 { 
    public partial class Constants { 

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_MAP_READ_BIT = 0x0001;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_SYNC_FLUSH_COMMANDS_BIT = 0x00000001;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_MAP_WRITE_BIT = 0x0002;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_MAP_INVALIDATE_RANGE_BIT = 0x0004;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_MAP_INVALIDATE_BUFFER_BIT = 0x0008;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_MAP_FLUSH_EXPLICIT_BIT = 0x0010;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLbitfield GL_MAP_UNSYNCHRONIZED_BIT = 0x0020;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_READ_BUFFER = 0x0C02;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNPACK_ROW_LENGTH = 0x0CF2;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNPACK_SKIP_ROWS = 0x0CF3;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNPACK_SKIP_PIXELS = 0x0CF4;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PACK_ROW_LENGTH = 0x0D02;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PACK_SKIP_ROWS = 0x0D03;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PACK_SKIP_PIXELS = 0x0D04;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_HALF_FLOAT = 0x140B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR = 0x1800;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEPTH = 0x1801;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_STENCIL = 0x1802;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RED = 0x1903;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_GREEN = 0x1904;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_BLUE = 0x1905;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MIN = 0x8007;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX = 0x8008;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGB8 = 0x8051;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGBA8 = 0x8058;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGB10_A2 = 0x8059;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_BINDING_3D = 0x806A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNPACK_SKIP_IMAGES = 0x806D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNPACK_IMAGE_HEIGHT = 0x806E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_3D = 0x806F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_WRAP_R = 0x8072;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_3D_TEXTURE_SIZE = 0x8073;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_ELEMENTS_VERTICES = 0x80E8;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_ELEMENTS_INDICES = 0x80E9;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_MIN_LOD = 0x813A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_MAX_LOD = 0x813B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_BASE_LEVEL = 0x813C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_MAX_LEVEL = 0x813D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEPTH_COMPONENT24 = 0x81A6;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_DEFAULT = 0x8218;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_UNDEFINED = 0x8219;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEPTH_STENCIL_ATTACHMENT = 0x821A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAJOR_VERSION = 0x821B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MINOR_VERSION = 0x821C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_NUM_EXTENSIONS = 0x821D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RG = 0x8227;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RG_INTEGER = 0x8228;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_R8 = 0x8229;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RG8 = 0x822B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_R16F = 0x822D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_R32F = 0x822E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RG16F = 0x822F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RG32F = 0x8230;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_R8I = 0x8231;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_R8UI = 0x8232;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_R16I = 0x8233;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_R16UI = 0x8234;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_R32I = 0x8235;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_R32UI = 0x8236;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RG8I = 0x8237;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RG8UI = 0x8238;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RG16I = 0x8239;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RG16UI = 0x823A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RG32I = 0x823B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RG32UI = 0x823C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_IMMUTABLE_LEVELS = 0x82DF;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEPTH_STENCIL = 0x84F9;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_24_8 = 0x84FA;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TEXTURE_LOD_BIAS = 0x84FD;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_VERTEX_ARRAY_BINDING = 0x85B5;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PROGRAM_BINARY_LENGTH = 0x8741;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_NUM_PROGRAM_BINARY_FORMATS = 0x87FE;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PROGRAM_BINARY_FORMATS = 0x87FF;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGBA32F = 0x8814;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGB32F = 0x8815;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGBA16F = 0x881A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGB16F = 0x881B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_DRAW_BUFFERS = 0x8824;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DRAW_BUFFER0 = 0x8825;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DRAW_BUFFER1 = 0x8826;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DRAW_BUFFER2 = 0x8827;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DRAW_BUFFER3 = 0x8828;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DRAW_BUFFER4 = 0x8829;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DRAW_BUFFER5 = 0x882A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DRAW_BUFFER6 = 0x882B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DRAW_BUFFER7 = 0x882C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DRAW_BUFFER8 = 0x882D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DRAW_BUFFER9 = 0x882E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DRAW_BUFFER10 = 0x882F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DRAW_BUFFER11 = 0x8830;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DRAW_BUFFER12 = 0x8831;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DRAW_BUFFER13 = 0x8832;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DRAW_BUFFER14 = 0x8833;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DRAW_BUFFER15 = 0x8834;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_COMPARE_MODE = 0x884C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_COMPARE_FUNC = 0x884D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPARE_REF_TO_TEXTURE = 0x884E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_CURRENT_QUERY = 0x8865;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_QUERY_RESULT = 0x8866;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_QUERY_RESULT_AVAILABLE = 0x8867;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_BUFFER_MAPPED = 0x88BC;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_BUFFER_MAP_POINTER = 0x88BD;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_STREAM_READ = 0x88E1;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_STREAM_COPY = 0x88E2;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_STATIC_READ = 0x88E5;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_STATIC_COPY = 0x88E6;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DYNAMIC_READ = 0x88E9;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DYNAMIC_COPY = 0x88EA;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PIXEL_PACK_BUFFER = 0x88EB;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PIXEL_UNPACK_BUFFER = 0x88EC;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PIXEL_PACK_BUFFER_BINDING = 0x88ED;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PIXEL_UNPACK_BUFFER_BINDING = 0x88EF;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEPTH24_STENCIL8 = 0x88F0;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_ARRAY_TEXTURE_LAYERS = 0x88FF;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MIN_PROGRAM_TEXEL_OFFSET = 0x8904;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_PROGRAM_TEXEL_OFFSET = 0x8905;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SAMPLER_BINDING = 0x8919;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_BUFFER = 0x8A11;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_BUFFER_BINDING = 0x8A28;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_BUFFER_START = 0x8A29;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_BUFFER_SIZE = 0x8A2A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_VERTEX_UNIFORM_BLOCKS = 0x8A2B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_UNIFORM_BLOCK_SIZE = 0x8A30;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x8A34;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_ACTIVE_UNIFORM_BLOCKS = 0x8A36;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_TYPE = 0x8A37;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_SIZE = 0x8A38;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_NAME_LENGTH = 0x8A39;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_BLOCK_INDEX = 0x8A3A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_OFFSET = 0x8A3B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_ARRAY_STRIDE = 0x8A3C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_MATRIX_STRIDE = 0x8A3D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_IS_ROW_MAJOR = 0x8A3E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_BLOCK_BINDING = 0x8A3F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_BLOCK_DATA_SIZE = 0x8A40;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_BLOCK_NAME_LENGTH = 0x8A41;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_VARYING_COMPONENTS = 0x8B4B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SAMPLER_3D = 0x8B5F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SAMPLER_2D_SHADOW = 0x8B62;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FLOAT_MAT2x3 = 0x8B65;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FLOAT_MAT2x4 = 0x8B66;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FLOAT_MAT3x2 = 0x8B67;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FLOAT_MAT3x4 = 0x8B68;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FLOAT_MAT4x2 = 0x8B69;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FLOAT_MAT4x3 = 0x8B6A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_NORMALIZED = 0x8C17;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_2D_ARRAY = 0x8C1A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_BINDING_2D_ARRAY = 0x8C1D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_ANY_SAMPLES_PASSED = 0x8C2F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_R11F_G11F_B10F = 0x8C3A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGB9_E5 = 0x8C3D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_5_9_9_9_REV = 0x8C3E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SRGB = 0x8C40;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SRGB8 = 0x8C41;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SRGB8_ALPHA8 = 0x8C43;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK_VARYINGS = 0x8C83;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RASTERIZER_DISCARD = 0x8C89;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_INTERLEAVED_ATTRIBS = 0x8C8C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SEPARATE_ATTRIBS = 0x8C8D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DRAW_FRAMEBUFFER_BINDING = 0x8CA6;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_READ_FRAMEBUFFER = 0x8CA8;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DRAW_FRAMEBUFFER = 0x8CA9;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_READ_FRAMEBUFFER_BINDING = 0x8CAA;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RENDERBUFFER_SAMPLES = 0x8CAB;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEPTH_COMPONENT32F = 0x8CAC;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_DEPTH32F_STENCIL8 = 0x8CAD;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_COLOR_ATTACHMENTS = 0x8CDF;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT1 = 0x8CE1;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT2 = 0x8CE2;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT3 = 0x8CE3;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT4 = 0x8CE4;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT5 = 0x8CE5;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT6 = 0x8CE6;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT7 = 0x8CE7;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT8 = 0x8CE8;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT9 = 0x8CE9;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT10 = 0x8CEA;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT11 = 0x8CEB;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT12 = 0x8CEC;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT13 = 0x8CED;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT14 = 0x8CEE;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT15 = 0x8CEF;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT16 = 0x8CF0;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT17 = 0x8CF1;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT18 = 0x8CF2;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT19 = 0x8CF3;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT20 = 0x8CF4;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT21 = 0x8CF5;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT22 = 0x8CF6;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT23 = 0x8CF7;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT24 = 0x8CF8;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT25 = 0x8CF9;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT26 = 0x8CFA;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT27 = 0x8CFB;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT28 = 0x8CFC;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT29 = 0x8CFD;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT30 = 0x8CFE;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_ATTACHMENT31 = 0x8CFF;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_SAMPLES = 0x8D57;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PRIMITIVE_RESTART_FIXED_INDEX = 0x8D69;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_ELEMENT_INDEX = 0x8D6B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGBA32UI = 0x8D70;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGB32UI = 0x8D71;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGBA16UI = 0x8D76;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGB16UI = 0x8D77;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGBA8UI = 0x8D7C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGB8UI = 0x8D7D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGBA32I = 0x8D82;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGB32I = 0x8D83;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGBA16I = 0x8D88;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGB16I = 0x8D89;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGBA8I = 0x8D8E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGB8I = 0x8D8F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RED_INTEGER = 0x8D94;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGB_INTEGER = 0x8D98;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGBA_INTEGER = 0x8D99;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_INT_2_10_10_10_REV = 0x8D9F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SAMPLER_2D_ARRAY = 0x8DC1;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SAMPLER_2D_ARRAY_SHADOW = 0x8DC4;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SAMPLER_CUBE_SHADOW = 0x8DC5;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_VEC2 = 0x8DC6;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_VEC3 = 0x8DC7;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_VEC4 = 0x8DC8;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_INT_SAMPLER_2D = 0x8DCA;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_INT_SAMPLER_3D = 0x8DCB;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_INT_SAMPLER_CUBE = 0x8DCC;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_INT_SAMPLER_2D_ARRAY = 0x8DCF;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_SAMPLER_2D = 0x8DD2;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_SAMPLER_3D = 0x8DD3;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK = 0x8E22;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK_PAUSED = 0x8E23;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK_ACTIVE = 0x8E24;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TRANSFORM_FEEDBACK_BINDING = 0x8E25;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_SWIZZLE_R = 0x8E42;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_SWIZZLE_G = 0x8E43;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_SWIZZLE_B = 0x8E44;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_SWIZZLE_A = 0x8E45;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COPY_READ_BUFFER = 0x8F36;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COPY_READ_BUFFER_BINDING = 0x8F36;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COPY_WRITE_BUFFER = 0x8F37;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COPY_WRITE_BUFFER_BINDING = 0x8F37;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_R8_SNORM = 0x8F94;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RG8_SNORM = 0x8F95;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGB8_SNORM = 0x8F96;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGBA8_SNORM = 0x8F97;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SIGNED_NORMALIZED = 0x8F9C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGB10_A2UI = 0x906F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_SERVER_WAIT_TIMEOUT = 0x9111;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_OBJECT_TYPE = 0x9112;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SYNC_CONDITION = 0x9113;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SYNC_STATUS = 0x9114;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SYNC_FLAGS = 0x9115;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SYNC_FENCE = 0x9116;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SYNC_GPU_COMMANDS_COMPLETE = 0x9117;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNALED = 0x9118;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SIGNALED = 0x9119;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_ALREADY_SIGNALED = 0x911A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TIMEOUT_EXPIRED = 0x911B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_CONDITION_SATISFIED = 0x911C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_WAIT_FAILED = 0x911D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_BUFFER_ACCESS_FLAGS = 0x911F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_BUFFER_MAP_LENGTH = 0x9120;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_BUFFER_MAP_OFFSET = 0x9121;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_IMMUTABLE_FORMAT = 0x912F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_R11_EAC = 0x9270;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_SIGNED_R11_EAC = 0x9271;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_RG11_EAC = 0x9272;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_SIGNED_RG11_EAC = 0x9273;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_RGB8_ETC2 = 0x9274;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_SRGB8_ETC2 = 0x9275;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_RGBA8_ETC2_EAC = 0x9278;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_NUM_SAMPLE_COUNTS = 0x9380;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_INVALID_INDEX = 0xFFFFFFFF;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLuint64 GL_TIMEOUT_IGNORED = 0xFFFFFFFFFFFFFFFF;
#endif
    }
}
#endif