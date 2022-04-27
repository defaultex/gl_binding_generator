#if (GL_VERSION_ES_CM_1_0 && GLES1_API)
public partial class gles1 { 
    public partial class Constants { 

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLbitfield GL_DEPTH_BUFFER_BIT = 0x00000100;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLbitfield GL_STENCIL_BUFFER_BIT = 0x00000400;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLbitfield GL_COLOR_BUFFER_BIT = 0x00004000;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_FALSE = 0;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_ES_VERSION_3_2 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0 && !GL_VERSION_4_5)
        public const GLenum GL_NO_ERROR = 0;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_ZERO = 0;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_TRUE = 1;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_ONE = 1;

#endif
        public const GLenum GL_VERSION_ES_CL_1_0 = 1;
        public const GLenum GL_VERSION_ES_CM_1_1 = 1;
        public const GLenum GL_VERSION_ES_CL_1_1 = 1;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_POINTS = 0x0000;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_LINES = 0x0001;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_LINE_LOOP = 0x0002;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_LINE_STRIP = 0x0003;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_ES_VERSION_3_2 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_TRIANGLES = 0x0004;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_TRIANGLE_STRIP = 0x0005;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_TRIANGLE_FAN = 0x0006;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_ADD = 0x0104;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_NEVER = 0x0200;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_LESS = 0x0201;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_ES_VERSION_3_2 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_EQUAL = 0x0202;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_LEQUAL = 0x0203;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_GREATER = 0x0204;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_NOTEQUAL = 0x0205;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_GEQUAL = 0x0206;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_ALWAYS = 0x0207;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_SRC_COLOR = 0x0300;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_ONE_MINUS_SRC_COLOR = 0x0301;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_SRC_ALPHA = 0x0302;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_ONE_MINUS_SRC_ALPHA = 0x0303;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_DST_ALPHA = 0x0304;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_ONE_MINUS_DST_ALPHA = 0x0305;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_DST_COLOR = 0x0306;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_ONE_MINUS_DST_COLOR = 0x0307;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_SRC_ALPHA_SATURATE = 0x0308;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_FRONT = 0x0404;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0 && !GL_VERSION_4_5)
        public const GLenum GL_BACK = 0x0405;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_FRONT_AND_BACK = 0x0408;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_INVALID_ENUM = 0x0500;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_INVALID_VALUE = 0x0501;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_INVALID_OPERATION = 0x0502;

#endif

#if (!GL_ES_VERSION_3_2 && !GL_VERSION_1_0 && !GL_VERSION_4_3)
        public const GLenum GL_STACK_OVERFLOW = 0x0503;

#endif

#if (!GL_ES_VERSION_3_2 && !GL_VERSION_1_0 && !GL_VERSION_4_3)
        public const GLenum GL_STACK_UNDERFLOW = 0x0504;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_OUT_OF_MEMORY = 0x0505;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_EXP = 0x0800;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_EXP2 = 0x0801;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_ES_VERSION_3_2 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_CW = 0x0900;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_ES_VERSION_3_2 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_CCW = 0x0901;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_CURRENT_COLOR = 0x0B00;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_CURRENT_NORMAL = 0x0B02;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_CURRENT_TEXTURE_COORDS = 0x0B03;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_POINT_SMOOTH = 0x0B10;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_POINT_SIZE = 0x0B11;

#endif

#if !GL_VERSION_1_2
        public const GLenum GL_SMOOTH_POINT_SIZE_RANGE = 0x0B12;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_LINE_SMOOTH = 0x0B20;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_LINE_WIDTH = 0x0B21;

#endif

#if !GL_VERSION_1_2
        public const GLenum GL_SMOOTH_LINE_WIDTH_RANGE = 0x0B22;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_CULL_FACE = 0x0B44;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_CULL_FACE_MODE = 0x0B45;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_FRONT_FACE = 0x0B46;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_LIGHTING = 0x0B50;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_LIGHT_MODEL_TWO_SIDE = 0x0B52;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_LIGHT_MODEL_AMBIENT = 0x0B53;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_SHADE_MODEL = 0x0B54;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_COLOR_MATERIAL = 0x0B57;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_FOG = 0x0B60;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_FOG_DENSITY = 0x0B62;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_FOG_START = 0x0B63;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_FOG_END = 0x0B64;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_FOG_MODE = 0x0B65;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_FOG_COLOR = 0x0B66;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_DEPTH_RANGE = 0x0B70;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_DEPTH_TEST = 0x0B71;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_DEPTH_WRITEMASK = 0x0B72;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_DEPTH_CLEAR_VALUE = 0x0B73;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_DEPTH_FUNC = 0x0B74;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_STENCIL_TEST = 0x0B90;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_STENCIL_CLEAR_VALUE = 0x0B91;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_STENCIL_FUNC = 0x0B92;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_STENCIL_VALUE_MASK = 0x0B93;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_STENCIL_FAIL = 0x0B94;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_STENCIL_PASS_DEPTH_FAIL = 0x0B95;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_STENCIL_PASS_DEPTH_PASS = 0x0B96;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_STENCIL_REF = 0x0B97;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_STENCIL_WRITEMASK = 0x0B98;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_MATRIX_MODE = 0x0BA0;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_NORMALIZE = 0x0BA1;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_VIEWPORT = 0x0BA2;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_MODELVIEW_STACK_DEPTH = 0x0BA3;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_PROJECTION_STACK_DEPTH = 0x0BA4;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_TEXTURE_STACK_DEPTH = 0x0BA5;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_MODELVIEW_MATRIX = 0x0BA6;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_PROJECTION_MATRIX = 0x0BA7;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_TEXTURE_MATRIX = 0x0BA8;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_ALPHA_TEST = 0x0BC0;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_ALPHA_TEST_FUNC = 0x0BC1;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_ALPHA_TEST_REF = 0x0BC2;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_DITHER = 0x0BD0;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_BLEND_DST = 0x0BE0;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_BLEND_SRC = 0x0BE1;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_BLEND = 0x0BE2;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_LOGIC_OP_MODE = 0x0BF0;

#endif

#if !GL_VERSION_1_1
        public const GLenum GL_COLOR_LOGIC_OP = 0x0BF2;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_SCISSOR_BOX = 0x0C10;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_SCISSOR_TEST = 0x0C11;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_COLOR_CLEAR_VALUE = 0x0C22;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_COLOR_WRITEMASK = 0x0C23;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_PERSPECTIVE_CORRECTION_HINT = 0x0C50;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_POINT_SMOOTH_HINT = 0x0C51;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_LINE_SMOOTH_HINT = 0x0C52;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_FOG_HINT = 0x0C54;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_UNPACK_ALIGNMENT = 0x0CF5;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_PACK_ALIGNMENT = 0x0D05;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_ALPHA_SCALE = 0x0D1C;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_MAX_LIGHTS = 0x0D31;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_MAX_CLIP_PLANES = 0x0D32;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_MAX_TEXTURE_SIZE = 0x0D33;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_MAX_MODELVIEW_STACK_DEPTH = 0x0D36;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_MAX_PROJECTION_STACK_DEPTH = 0x0D38;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_MAX_TEXTURE_STACK_DEPTH = 0x0D39;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_MAX_VIEWPORT_DIMS = 0x0D3A;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLbitfield GL_SUBPIXEL_BITS = 0x0D50;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLbitfield GL_RED_BITS = 0x0D52;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLbitfield GL_GREEN_BITS = 0x0D53;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLbitfield GL_BLUE_BITS = 0x0D54;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLbitfield GL_ALPHA_BITS = 0x0D55;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLbitfield GL_DEPTH_BITS = 0x0D56;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLbitfield GL_STENCIL_BITS = 0x0D57;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_TEXTURE_2D = 0x0DE1;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_DONT_CARE = 0x1100;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_FASTEST = 0x1101;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_NICEST = 0x1102;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_AMBIENT = 0x1200;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_DIFFUSE = 0x1201;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_SPECULAR = 0x1202;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_POSITION = 0x1203;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_SPOT_DIRECTION = 0x1204;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_SPOT_EXPONENT = 0x1205;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_SPOT_CUTOFF = 0x1206;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_CONSTANT_ATTENUATION = 0x1207;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_LINEAR_ATTENUATION = 0x1208;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_QUADRATIC_ATTENUATION = 0x1209;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_BYTE = 0x1400;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_UNSIGNED_BYTE = 0x1401;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_SHORT = 0x1402;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_UNSIGNED_SHORT = 0x1403;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_FLOAT = 0x1406;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_VERSION_4_1)
        public const GLenum GL_FIXED = 0x140C;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_CLEAR = 0x1500;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_AND = 0x1501;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_AND_REVERSE = 0x1502;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_COPY = 0x1503;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_AND_INVERTED = 0x1504;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_NOOP = 0x1505;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_XOR = 0x1506;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_OR = 0x1507;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_NOR = 0x1508;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_EQUIV = 0x1509;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_INVERT = 0x150A;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_OR_REVERSE = 0x150B;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_COPY_INVERTED = 0x150C;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_OR_INVERTED = 0x150D;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_NAND = 0x150E;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_SET = 0x150F;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_EMISSION = 0x1600;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_SHININESS = 0x1601;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_AMBIENT_AND_DIFFUSE = 0x1602;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_MODELVIEW = 0x1700;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_PROJECTION = 0x1701;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_TEXTURE = 0x1702;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_ALPHA = 0x1906;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_RGB = 0x1907;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_RGBA = 0x1908;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_LUMINANCE = 0x1909;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_LUMINANCE_ALPHA = 0x190A;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_FLAT = 0x1D00;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_SMOOTH = 0x1D01;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_KEEP = 0x1E00;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_REPLACE = 0x1E01;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_INCR = 0x1E02;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_DECR = 0x1E03;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_VENDOR = 0x1F00;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_RENDERER = 0x1F01;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_VERSION = 0x1F02;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_EXTENSIONS = 0x1F03;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_MODULATE = 0x2100;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_DECAL = 0x2101;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_TEXTURE_ENV_MODE = 0x2200;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_TEXTURE_ENV_COLOR = 0x2201;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_TEXTURE_ENV = 0x2300;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_NEAREST = 0x2600;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_LINEAR = 0x2601;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_NEAREST_MIPMAP_NEAREST = 0x2700;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_LINEAR_MIPMAP_NEAREST = 0x2701;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_NEAREST_MIPMAP_LINEAR = 0x2702;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_LINEAR_MIPMAP_LINEAR = 0x2703;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_TEXTURE_MAG_FILTER = 0x2800;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_TEXTURE_MIN_FILTER = 0x2801;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_TEXTURE_WRAP_S = 0x2802;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_TEXTURE_WRAP_T = 0x2803;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_0)
        public const GLenum GL_REPEAT = 0x2901;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_1)
        public const GLenum GL_POLYGON_OFFSET_UNITS = 0x2A00;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_CLIP_PLANE0 = 0x3000;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_CLIP_PLANE1 = 0x3001;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_CLIP_PLANE2 = 0x3002;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_CLIP_PLANE3 = 0x3003;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_CLIP_PLANE4 = 0x3004;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_CLIP_PLANE5 = 0x3005;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_LIGHT0 = 0x4000;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_LIGHT1 = 0x4001;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_LIGHT2 = 0x4002;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_LIGHT3 = 0x4003;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_LIGHT4 = 0x4004;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_LIGHT5 = 0x4005;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_LIGHT6 = 0x4006;

#endif

#if !GL_VERSION_1_0
        public const GLenum GL_LIGHT7 = 0x4007;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_2)
        public const GLenum GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_2)
        public const GLenum GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_1)
        public const GLenum GL_POLYGON_OFFSET_FILL = 0x8037;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_1)
        public const GLenum GL_POLYGON_OFFSET_FACTOR = 0x8038;

#endif

#if !GL_VERSION_1_2
        public const GLenum GL_RESCALE_NORMAL = 0x803A;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_1 && !GL_VERSION_4_5)
        public const GLenum GL_TEXTURE_BINDING_2D = 0x8069;

#endif

#if (!GL_ES_VERSION_3_2 && !GL_VERSION_1_1 && !GL_VERSION_4_3)
        public const GLenum GL_VERTEX_ARRAY = 0x8074;

#endif

#if !GL_VERSION_1_1
        public const GLenum GL_NORMAL_ARRAY = 0x8075;

#endif

#if !GL_VERSION_1_1
        public const GLenum GL_COLOR_ARRAY = 0x8076;

#endif

#if !GL_VERSION_1_1
        public const GLenum GL_TEXTURE_COORD_ARRAY = 0x8078;

#endif

#if !GL_VERSION_1_1
        public const GLenum GL_VERTEX_ARRAY_SIZE = 0x807A;

#endif

#if !GL_VERSION_1_1
        public const GLenum GL_VERTEX_ARRAY_TYPE = 0x807B;

#endif

#if !GL_VERSION_1_1
        public const GLenum GL_VERTEX_ARRAY_STRIDE = 0x807C;

#endif

#if !GL_VERSION_1_1
        public const GLenum GL_NORMAL_ARRAY_TYPE = 0x807E;

#endif

#if !GL_VERSION_1_1
        public const GLenum GL_NORMAL_ARRAY_STRIDE = 0x807F;

#endif

#if !GL_VERSION_1_1
        public const GLenum GL_COLOR_ARRAY_SIZE = 0x8081;

#endif

#if !GL_VERSION_1_1
        public const GLenum GL_COLOR_ARRAY_TYPE = 0x8082;

#endif

#if !GL_VERSION_1_1
        public const GLenum GL_COLOR_ARRAY_STRIDE = 0x8083;

#endif

#if !GL_VERSION_1_1
        public const GLenum GL_TEXTURE_COORD_ARRAY_SIZE = 0x8088;

#endif

#if !GL_VERSION_1_1
        public const GLenum GL_TEXTURE_COORD_ARRAY_TYPE = 0x8089;

#endif

#if !GL_VERSION_1_1
        public const GLenum GL_TEXTURE_COORD_ARRAY_STRIDE = 0x808A;

#endif

#if !GL_VERSION_1_1
        public const GLenum GL_VERTEX_ARRAY_POINTER = 0x808E;

#endif

#if !GL_VERSION_1_1
        public const GLenum GL_NORMAL_ARRAY_POINTER = 0x808F;

#endif

#if !GL_VERSION_1_1
        public const GLenum GL_COLOR_ARRAY_POINTER = 0x8090;

#endif

#if !GL_VERSION_1_1
        public const GLenum GL_TEXTURE_COORD_ARRAY_POINTER = 0x8092;

#endif

#if !GL_VERSION_1_3
        public const GLenum GL_MULTISAMPLE = 0x809D;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E;

#endif

#if !GL_VERSION_1_3
        public const GLenum GL_SAMPLE_ALPHA_TO_ONE = 0x809F;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_SAMPLE_COVERAGE = 0x80A0;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_SAMPLE_BUFFERS = 0x80A8;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_SAMPLES = 0x80A9;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_SAMPLE_COVERAGE_VALUE = 0x80AA;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_SAMPLE_COVERAGE_INVERT = 0x80AB;

#endif

#if !GL_VERSION_1_4
        public const GLenum GL_POINT_SIZE_MIN = 0x8126;

#endif

#if !GL_VERSION_1_4
        public const GLenum GL_POINT_SIZE_MAX = 0x8127;

#endif

#if !GL_VERSION_1_4
        public const GLenum GL_POINT_FADE_THRESHOLD_SIZE = 0x8128;

#endif

#if !GL_VERSION_1_4
        public const GLenum GL_POINT_DISTANCE_ATTENUATION = 0x8129;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_2)
        public const GLenum GL_CLAMP_TO_EDGE = 0x812F;

#endif

#if !GL_VERSION_1_4
        public const GLenum GL_GENERATE_MIPMAP = 0x8191;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_4)
        public const GLenum GL_GENERATE_MIPMAP_HINT = 0x8192;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_2)
        public const GLenum GL_UNSIGNED_SHORT_5_6_5 = 0x8363;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_2)
        public const GLenum GL_ALIASED_POINT_SIZE_RANGE = 0x846D;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_2)
        public const GLenum GL_ALIASED_LINE_WIDTH_RANGE = 0x846E;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_TEXTURE0 = 0x84C0;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_TEXTURE1 = 0x84C1;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_TEXTURE2 = 0x84C2;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_TEXTURE3 = 0x84C3;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_TEXTURE4 = 0x84C4;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_TEXTURE5 = 0x84C5;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_TEXTURE6 = 0x84C6;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_TEXTURE7 = 0x84C7;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_TEXTURE8 = 0x84C8;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_TEXTURE9 = 0x84C9;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_TEXTURE10 = 0x84CA;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_TEXTURE11 = 0x84CB;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_TEXTURE12 = 0x84CC;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_TEXTURE13 = 0x84CD;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_TEXTURE14 = 0x84CE;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_TEXTURE15 = 0x84CF;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_TEXTURE16 = 0x84D0;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_TEXTURE17 = 0x84D1;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_TEXTURE18 = 0x84D2;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_TEXTURE19 = 0x84D3;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_TEXTURE20 = 0x84D4;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_TEXTURE21 = 0x84D5;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_TEXTURE22 = 0x84D6;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_TEXTURE23 = 0x84D7;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_TEXTURE24 = 0x84D8;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_TEXTURE25 = 0x84D9;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_TEXTURE26 = 0x84DA;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_TEXTURE27 = 0x84DB;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_TEXTURE28 = 0x84DC;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_TEXTURE29 = 0x84DD;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_TEXTURE30 = 0x84DE;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_TEXTURE31 = 0x84DF;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_ACTIVE_TEXTURE = 0x84E0;

#endif

#if !GL_VERSION_1_3
        public const GLenum GL_CLIENT_ACTIVE_TEXTURE = 0x84E1;

#endif

#if !GL_VERSION_1_3
        public const GLenum GL_MAX_TEXTURE_UNITS = 0x84E2;

#endif

#if !GL_VERSION_1_3
        public const GLenum GL_SUBTRACT = 0x84E7;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_3)
        public const GLenum GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3;

#endif

#if !GL_VERSION_1_3
        public const GLenum GL_DOT3_RGB = 0x86AE;

#endif

#if !GL_VERSION_1_3
        public const GLenum GL_DOT3_RGBA = 0x86AF;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_5)
        public const GLenum GL_BUFFER_SIZE = 0x8764;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_5)
        public const GLenum GL_BUFFER_USAGE = 0x8765;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_5)
        public const GLenum GL_ARRAY_BUFFER = 0x8892;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_5)
        public const GLenum GL_ELEMENT_ARRAY_BUFFER = 0x8893;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_5)
        public const GLenum GL_ARRAY_BUFFER_BINDING = 0x8894;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_5)
        public const GLenum GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;

#endif

#if !GL_VERSION_1_5
        public const GLenum GL_VERTEX_ARRAY_BUFFER_BINDING = 0x8896;

#endif

#if !GL_VERSION_1_5
        public const GLenum GL_NORMAL_ARRAY_BUFFER_BINDING = 0x8897;

#endif

#if !GL_VERSION_1_5
        public const GLenum GL_COLOR_ARRAY_BUFFER_BINDING = 0x8898;

#endif

#if !GL_VERSION_1_5
        public const GLenum GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING = 0x889A;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_5)
        public const GLenum GL_STATIC_DRAW = 0x88E4;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0 && !GL_VERSION_1_5)
        public const GLenum GL_DYNAMIC_DRAW = 0x88E8;

#endif

#if !GL_VERSION_1_3
        public const GLenum GL_COMBINE = 0x8570;

#endif

#if !GL_VERSION_1_3
        public const GLenum GL_COMBINE_RGB = 0x8571;

#endif

#if !GL_VERSION_1_3
        public const GLenum GL_COMBINE_ALPHA = 0x8572;

#endif

#if !GL_VERSION_1_3
        public const GLenum GL_RGB_SCALE = 0x8573;

#endif

#if !GL_VERSION_1_3
        public const GLenum GL_ADD_SIGNED = 0x8574;

#endif

#if !GL_VERSION_1_3
        public const GLenum GL_INTERPOLATE = 0x8575;

#endif

#if !GL_VERSION_1_3
        public const GLenum GL_CONSTANT = 0x8576;

#endif

#if !GL_VERSION_1_3
        public const GLenum GL_PRIMARY_COLOR = 0x8577;

#endif

#if !GL_VERSION_1_3
        public const GLenum GL_PREVIOUS = 0x8578;

#endif

#if !GL_VERSION_1_5
        public const GLenum GL_SRC0_RGB = 0x8580;

#endif

#if !GL_VERSION_1_5
        public const GLenum GL_SRC1_RGB = 0x8581;

#endif

#if !GL_VERSION_1_5
        public const GLenum GL_SRC2_RGB = 0x8582;

#endif

#if !GL_VERSION_1_5
        public const GLenum GL_SRC0_ALPHA = 0x8588;

#endif

#if !GL_VERSION_1_5
        public const GLenum GL_SRC1_ALPHA = 0x8589;

#endif

#if !GL_VERSION_1_5
        public const GLenum GL_SRC2_ALPHA = 0x858A;

#endif

#if !GL_VERSION_1_3
        public const GLenum GL_OPERAND0_RGB = 0x8590;

#endif

#if !GL_VERSION_1_3
        public const GLenum GL_OPERAND1_RGB = 0x8591;

#endif

#if !GL_VERSION_1_3
        public const GLenum GL_OPERAND2_RGB = 0x8592;

#endif

#if !GL_VERSION_1_3
        public const GLenum GL_OPERAND0_ALPHA = 0x8598;

#endif

#if !GL_VERSION_1_3
        public const GLenum GL_OPERAND1_ALPHA = 0x8599;

#endif

#if !GL_VERSION_1_3
        public const GLenum GL_OPERAND2_ALPHA = 0x859A;

#endif
    }
}
#endif