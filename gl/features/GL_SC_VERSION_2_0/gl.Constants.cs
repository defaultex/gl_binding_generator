#if (GL_SC_VERSION_2_0 && GLSC2_API)
public partial class glsc2 { 
    public partial class Constants { 
        public const GLenum GL_FALSE = 0;        public const GLenum GL_NO_ERROR = 0;        public const GLenum GL_NONE = 0;        public const GLenum GL_POINTS = 0x0000;        public const GLenum GL_ZERO = 0;        public const GLenum GL_LINES = 0x0001;        public const GLenum GL_ONE = 1;        public const GLenum GL_TRUE = 1;        public const GLenum GL_LINE_LOOP = 0x0002;        public const GLenum GL_LINE_STRIP = 0x0003;        public const GLenum GL_TRIANGLES = 0x0004;        public const GLenum GL_TRIANGLE_STRIP = 0x0005;        public const GLenum GL_TRIANGLE_FAN = 0x0006;        public const GLbitfield GL_DEPTH_BUFFER_BIT = 0x00000100;        public const GLenum GL_NEVER = 0x0200;        public const GLenum GL_LESS = 0x0201;        public const GLenum GL_EQUAL = 0x0202;        public const GLenum GL_LEQUAL = 0x0203;        public const GLenum GL_GREATER = 0x0204;        public const GLenum GL_NOTEQUAL = 0x0205;        public const GLenum GL_GEQUAL = 0x0206;        public const GLenum GL_ALWAYS = 0x0207;        public const GLenum GL_SRC_COLOR = 0x0300;        public const GLenum GL_ONE_MINUS_SRC_COLOR = 0x0301;        public const GLenum GL_SRC_ALPHA = 0x0302;        public const GLenum GL_ONE_MINUS_SRC_ALPHA = 0x0303;        public const GLenum GL_DST_ALPHA = 0x0304;        public const GLenum GL_ONE_MINUS_DST_ALPHA = 0x0305;        public const GLenum GL_DST_COLOR = 0x0306;        public const GLenum GL_ONE_MINUS_DST_COLOR = 0x0307;        public const GLenum GL_SRC_ALPHA_SATURATE = 0x0308;        public const GLbitfield GL_STENCIL_BUFFER_BIT = 0x00000400;        public const GLenum GL_FRONT = 0x0404;        public const GLenum GL_BACK = 0x0405;        public const GLenum GL_FRONT_AND_BACK = 0x0408;        public const GLenum GL_INVALID_ENUM = 0x0500;        public const GLenum GL_INVALID_VALUE = 0x0501;        public const GLenum GL_INVALID_OPERATION = 0x0502;        public const GLenum GL_OUT_OF_MEMORY = 0x0505;        public const GLenum GL_INVALID_FRAMEBUFFER_OPERATION = 0x0506;        public const GLenum GL_CONTEXT_LOST = 0x0507;        public const GLenum GL_CW = 0x0900;        public const GLenum GL_CCW = 0x0901;        public const GLenum GL_LINE_WIDTH = 0x0B21;        public const GLenum GL_CULL_FACE = 0x0B44;        public const GLenum GL_CULL_FACE_MODE = 0x0B45;        public const GLenum GL_FRONT_FACE = 0x0B46;        public const GLenum GL_DEPTH_RANGE = 0x0B70;        public const GLenum GL_DEPTH_TEST = 0x0B71;        public const GLenum GL_DEPTH_WRITEMASK = 0x0B72;        public const GLenum GL_DEPTH_CLEAR_VALUE = 0x0B73;        public const GLenum GL_DEPTH_FUNC = 0x0B74;        public const GLenum GL_STENCIL_TEST = 0x0B90;        public const GLenum GL_STENCIL_CLEAR_VALUE = 0x0B91;        public const GLenum GL_STENCIL_FUNC = 0x0B92;        public const GLenum GL_STENCIL_VALUE_MASK = 0x0B93;        public const GLenum GL_STENCIL_FAIL = 0x0B94;        public const GLenum GL_STENCIL_PASS_DEPTH_FAIL = 0x0B95;        public const GLenum GL_STENCIL_PASS_DEPTH_PASS = 0x0B96;        public const GLenum GL_STENCIL_REF = 0x0B97;        public const GLenum GL_STENCIL_WRITEMASK = 0x0B98;        public const GLenum GL_VIEWPORT = 0x0BA2;        public const GLenum GL_DITHER = 0x0BD0;        public const GLenum GL_BLEND = 0x0BE2;        public const GLenum GL_SCISSOR_BOX = 0x0C10;        public const GLenum GL_SCISSOR_TEST = 0x0C11;        public const GLenum GL_COLOR_CLEAR_VALUE = 0x0C22;        public const GLenum GL_COLOR_WRITEMASK = 0x0C23;        public const GLenum GL_UNPACK_ALIGNMENT = 0x0CF5;        public const GLenum GL_PACK_ALIGNMENT = 0x0D05;        public const GLenum GL_MAX_TEXTURE_SIZE = 0x0D33;        public const GLenum GL_MAX_VIEWPORT_DIMS = 0x0D3A;        public const GLbitfield GL_SUBPIXEL_BITS = 0x0D50;        public const GLbitfield GL_RED_BITS = 0x0D52;        public const GLbitfield GL_GREEN_BITS = 0x0D53;        public const GLbitfield GL_BLUE_BITS = 0x0D54;        public const GLbitfield GL_ALPHA_BITS = 0x0D55;        public const GLbitfield GL_DEPTH_BITS = 0x0D56;        public const GLbitfield GL_STENCIL_BITS = 0x0D57;        public const GLenum GL_TEXTURE_2D = 0x0DE1;        public const GLenum GL_DONT_CARE = 0x1100;        public const GLenum GL_FASTEST = 0x1101;        public const GLenum GL_NICEST = 0x1102;        public const GLenum GL_BYTE = 0x1400;        public const GLenum GL_UNSIGNED_BYTE = 0x1401;        public const GLenum GL_SHORT = 0x1402;        public const GLenum GL_UNSIGNED_SHORT = 0x1403;        public const GLenum GL_INT = 0x1404;        public const GLenum GL_UNSIGNED_INT = 0x1405;        public const GLenum GL_FLOAT = 0x1406;        public const GLenum GL_INVERT = 0x150A;        public const GLenum GL_TEXTURE = 0x1702;        public const GLenum GL_RED = 0x1903;        public const GLenum GL_RGB = 0x1907;        public const GLenum GL_RGBA = 0x1908;        public const GLenum GL_KEEP = 0x1E00;        public const GLenum GL_REPLACE = 0x1E01;        public const GLenum GL_INCR = 0x1E02;        public const GLenum GL_DECR = 0x1E03;        public const GLenum GL_VENDOR = 0x1F00;        public const GLenum GL_RENDERER = 0x1F01;        public const GLenum GL_VERSION = 0x1F02;        public const GLenum GL_EXTENSIONS = 0x1F03;        public const GLenum GL_NEAREST = 0x2600;        public const GLenum GL_LINEAR = 0x2601;        public const GLenum GL_NEAREST_MIPMAP_NEAREST = 0x2700;        public const GLenum GL_LINEAR_MIPMAP_NEAREST = 0x2701;        public const GLenum GL_NEAREST_MIPMAP_LINEAR = 0x2702;        public const GLenum GL_LINEAR_MIPMAP_LINEAR = 0x2703;        public const GLenum GL_TEXTURE_MAG_FILTER = 0x2800;        public const GLenum GL_TEXTURE_MIN_FILTER = 0x2801;        public const GLenum GL_TEXTURE_WRAP_S = 0x2802;        public const GLenum GL_TEXTURE_WRAP_T = 0x2803;        public const GLenum GL_REPEAT = 0x2901;        public const GLenum GL_POLYGON_OFFSET_UNITS = 0x2A00;        public const GLbitfield GL_COLOR_BUFFER_BIT = 0x00004000;        public const GLenum GL_CONSTANT_COLOR = 0x8001;        public const GLenum GL_ONE_MINUS_CONSTANT_COLOR = 0x8002;        public const GLenum GL_CONSTANT_ALPHA = 0x8003;        public const GLenum GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004;        public const GLenum GL_BLEND_COLOR = 0x8005;        public const GLenum GL_FUNC_ADD = 0x8006;        public const GLenum GL_BLEND_EQUATION = 0x8009;        public const GLenum GL_BLEND_EQUATION_RGB = 0x8009;        public const GLenum GL_FUNC_SUBTRACT = 0x800A;        public const GLenum GL_FUNC_REVERSE_SUBTRACT = 0x800B;        public const GLenum GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033;        public const GLenum GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034;        public const GLenum GL_POLYGON_OFFSET_FILL = 0x8037;        public const GLenum GL_POLYGON_OFFSET_FACTOR = 0x8038;        public const GLenum GL_RGB8 = 0x8051;        public const GLenum GL_RGBA4 = 0x8056;        public const GLenum GL_RGB5_A1 = 0x8057;        public const GLenum GL_RGBA8 = 0x8058;        public const GLenum GL_TEXTURE_BINDING_2D = 0x8069;        public const GLenum GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E;        public const GLenum GL_SAMPLE_COVERAGE = 0x80A0;        public const GLenum GL_SAMPLE_BUFFERS = 0x80A8;        public const GLenum GL_SAMPLES = 0x80A9;        public const GLenum GL_SAMPLE_COVERAGE_VALUE = 0x80AA;        public const GLenum GL_SAMPLE_COVERAGE_INVERT = 0x80AB;        public const GLenum GL_BLEND_DST_RGB = 0x80C8;        public const GLenum GL_BLEND_SRC_RGB = 0x80C9;        public const GLenum GL_BLEND_DST_ALPHA = 0x80CA;        public const GLenum GL_BLEND_SRC_ALPHA = 0x80CB;        public const GLenum GL_CLAMP_TO_EDGE = 0x812F;        public const GLenum GL_GENERATE_MIPMAP_HINT = 0x8192;        public const GLenum GL_DEPTH_COMPONENT16 = 0x81A5;        public const GLenum GL_FRAMEBUFFER_UNDEFINED = 0x8219;        public const GLenum GL_RG = 0x8227;        public const GLenum GL_R8 = 0x8229;        public const GLenum GL_RG8 = 0x822B;        public const GLenum GL_LOSE_CONTEXT_ON_RESET = 0x8252;        public const GLenum GL_GUILTY_CONTEXT_RESET = 0x8253;        public const GLenum GL_INNOCENT_CONTEXT_RESET = 0x8254;        public const GLenum GL_UNKNOWN_CONTEXT_RESET = 0x8255;        public const GLenum GL_RESET_NOTIFICATION_STRATEGY = 0x8256;        public const GLenum GL_UNSIGNED_SHORT_5_6_5 = 0x8363;        public const GLenum GL_MIRRORED_REPEAT = 0x8370;        public const GLenum GL_ALIASED_POINT_SIZE_RANGE = 0x846D;        public const GLenum GL_ALIASED_LINE_WIDTH_RANGE = 0x846E;        public const GLenum GL_TEXTURE0 = 0x84C0;        public const GLenum GL_TEXTURE1 = 0x84C1;        public const GLenum GL_TEXTURE2 = 0x84C2;        public const GLenum GL_TEXTURE3 = 0x84C3;        public const GLenum GL_TEXTURE4 = 0x84C4;        public const GLenum GL_TEXTURE5 = 0x84C5;        public const GLenum GL_TEXTURE6 = 0x84C6;        public const GLenum GL_TEXTURE7 = 0x84C7;        public const GLenum GL_TEXTURE8 = 0x84C8;        public const GLenum GL_TEXTURE9 = 0x84C9;        public const GLenum GL_TEXTURE10 = 0x84CA;        public const GLenum GL_TEXTURE11 = 0x84CB;        public const GLenum GL_TEXTURE12 = 0x84CC;        public const GLenum GL_TEXTURE13 = 0x84CD;        public const GLenum GL_TEXTURE14 = 0x84CE;        public const GLenum GL_TEXTURE15 = 0x84CF;        public const GLenum GL_TEXTURE16 = 0x84D0;        public const GLenum GL_TEXTURE17 = 0x84D1;        public const GLenum GL_TEXTURE18 = 0x84D2;        public const GLenum GL_TEXTURE19 = 0x84D3;        public const GLenum GL_TEXTURE20 = 0x84D4;        public const GLenum GL_TEXTURE21 = 0x84D5;        public const GLenum GL_TEXTURE22 = 0x84D6;        public const GLenum GL_TEXTURE23 = 0x84D7;        public const GLenum GL_TEXTURE24 = 0x84D8;        public const GLenum GL_TEXTURE25 = 0x84D9;        public const GLenum GL_TEXTURE26 = 0x84DA;        public const GLenum GL_TEXTURE27 = 0x84DB;        public const GLenum GL_TEXTURE28 = 0x84DC;        public const GLenum GL_TEXTURE29 = 0x84DD;        public const GLenum GL_TEXTURE30 = 0x84DE;        public const GLenum GL_TEXTURE31 = 0x84DF;        public const GLenum GL_ACTIVE_TEXTURE = 0x84E0;        public const GLenum GL_MAX_RENDERBUFFER_SIZE = 0x84E8;        public const GLenum GL_INCR_WRAP = 0x8507;        public const GLenum GL_DECR_WRAP = 0x8508;        public const GLenum GL_VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622;        public const GLenum GL_VERTEX_ATTRIB_ARRAY_SIZE = 0x8623;        public const GLenum GL_VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624;        public const GLenum GL_VERTEX_ATTRIB_ARRAY_TYPE = 0x8625;        public const GLenum GL_CURRENT_VERTEX_ATTRIB = 0x8626;        public const GLenum GL_VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;        public const GLenum GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;        public const GLenum GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3;        public const GLenum GL_BUFFER_SIZE = 0x8764;        public const GLenum GL_BUFFER_USAGE = 0x8765;        public const GLenum GL_NUM_PROGRAM_BINARY_FORMATS = 0x87FE;        public const GLenum GL_PROGRAM_BINARY_FORMATS = 0x87FF;        public const GLenum GL_STENCIL_BACK_FUNC = 0x8800;        public const GLenum GL_STENCIL_BACK_FAIL = 0x8801;        public const GLenum GL_STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802;        public const GLenum GL_STENCIL_BACK_PASS_DEPTH_PASS = 0x8803;        public const GLenum GL_BLEND_EQUATION_ALPHA = 0x883D;        public const GLenum GL_MAX_VERTEX_ATTRIBS = 0x8869;        public const GLenum GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A;        public const GLenum GL_MAX_TEXTURE_IMAGE_UNITS = 0x8872;        public const GLenum GL_ARRAY_BUFFER = 0x8892;        public const GLenum GL_ELEMENT_ARRAY_BUFFER = 0x8893;        public const GLenum GL_ARRAY_BUFFER_BINDING = 0x8894;        public const GLenum GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;        public const GLenum GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;        public const GLenum GL_STREAM_DRAW = 0x88E0;        public const GLenum GL_STATIC_DRAW = 0x88E4;        public const GLenum GL_DYNAMIC_DRAW = 0x88E8;        public const GLenum GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C;        public const GLenum GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;        public const GLenum GL_SAMPLER_2D = 0x8B5E;        public const GLenum GL_LINK_STATUS = 0x8B82;        public const GLenum GL_SHADING_LANGUAGE_VERSION = 0x8B8C;        public const GLenum GL_CURRENT_PROGRAM = 0x8B8D;        public const GLenum GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A;        public const GLenum GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;        public const GLenum GL_STENCIL_BACK_REF = 0x8CA3;        public const GLenum GL_STENCIL_BACK_VALUE_MASK = 0x8CA4;        public const GLenum GL_STENCIL_BACK_WRITEMASK = 0x8CA5;        public const GLenum GL_FRAMEBUFFER_BINDING = 0x8CA6;        public const GLenum GL_RENDERBUFFER_BINDING = 0x8CA7;        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;        public const GLenum GL_FRAMEBUFFER_COMPLETE = 0x8CD5;        public const GLenum GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;        public const GLenum GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;        public const GLenum GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS = 0x8CD9;        public const GLenum GL_FRAMEBUFFER_UNSUPPORTED = 0x8CDD;        public const GLenum GL_COLOR_ATTACHMENT0 = 0x8CE0;        public const GLenum GL_DEPTH_ATTACHMENT = 0x8D00;        public const GLenum GL_STENCIL_ATTACHMENT = 0x8D20;        public const GLenum GL_FRAMEBUFFER = 0x8D40;        public const GLenum GL_RENDERBUFFER = 0x8D41;        public const GLenum GL_RENDERBUFFER_WIDTH = 0x8D42;        public const GLenum GL_RENDERBUFFER_HEIGHT = 0x8D43;        public const GLenum GL_RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;        public const GLenum GL_STENCIL_INDEX8 = 0x8D48;        public const GLenum GL_RENDERBUFFER_RED_SIZE = 0x8D50;        public const GLenum GL_RENDERBUFFER_GREEN_SIZE = 0x8D51;        public const GLenum GL_RENDERBUFFER_BLUE_SIZE = 0x8D52;        public const GLenum GL_RENDERBUFFER_ALPHA_SIZE = 0x8D53;        public const GLenum GL_RENDERBUFFER_DEPTH_SIZE = 0x8D54;        public const GLenum GL_RENDERBUFFER_STENCIL_SIZE = 0x8D55;        public const GLenum GL_RGB565 = 0x8D62;        public const GLenum GL_LOW_FLOAT = 0x8DF0;        public const GLenum GL_MEDIUM_FLOAT = 0x8DF1;        public const GLenum GL_HIGH_FLOAT = 0x8DF2;        public const GLenum GL_LOW_INT = 0x8DF3;        public const GLenum GL_MEDIUM_INT = 0x8DF4;        public const GLenum GL_HIGH_INT = 0x8DF5;        public const GLenum GL_MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;        public const GLenum GL_MAX_VARYING_VECTORS = 0x8DFC;        public const GLenum GL_MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;        public const GLenum GL_CONTEXT_ROBUST_ACCESS = 0x90F3;        public const GLenum GL_TEXTURE_IMMUTABLE_FORMAT = 0x912F;    }
}
#endif