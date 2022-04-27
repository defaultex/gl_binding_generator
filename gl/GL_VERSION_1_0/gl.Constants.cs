#if (GL_VERSION_1_0 && GL_API)
public partial class gl { 
    public partial class Constants { 
        public const GLbitfield GL_CURRENT_BIT = 0x00000001;
        public const GLbitfield GL_POINT_BIT = 0x00000002;
        public const GLbitfield GL_LINE_BIT = 0x00000004;
        public const GLbitfield GL_POLYGON_BIT = 0x00000008;
        public const GLbitfield GL_POLYGON_STIPPLE_BIT = 0x00000010;
        public const GLbitfield GL_PIXEL_MODE_BIT = 0x00000020;
        public const GLbitfield GL_LIGHTING_BIT = 0x00000040;
        public const GLbitfield GL_FOG_BIT = 0x00000080;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_DEPTH_BUFFER_BIT = 0x00000100;

#endif
        public const GLbitfield GL_ACCUM_BUFFER_BIT = 0x00000200;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_STENCIL_BUFFER_BIT = 0x00000400;

#endif
        public const GLbitfield GL_VIEWPORT_BIT = 0x00000800;
        public const GLbitfield GL_TRANSFORM_BIT = 0x00001000;
        public const GLbitfield GL_ENABLE_BIT = 0x00002000;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_COLOR_BUFFER_BIT = 0x00004000;

#endif
        public const GLbitfield GL_HINT_BIT = 0x00008000;
        public const GLbitfield GL_EVAL_BIT = 0x00010000;
        public const GLbitfield GL_LIST_BIT = 0x00020000;
        public const GLbitfield GL_TEXTURE_BIT = 0x00040000;
        public const GLbitfield GL_SCISSOR_BIT = 0x00080000;
        public const GLbitfield GL_ALL_ATTRIB_BITS = 0xFFFFFFFF;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_FALSE = 0;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_ES_VERSION_3_2 && !GL_SC_VERSION_2_0)
        public const GLenum GL_NO_ERROR = 0;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_ZERO = 0;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_NONE = 0;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_TRUE = 1;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_ONE = 1;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_POINTS = 0x0000;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_LINES = 0x0001;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_LINE_LOOP = 0x0002;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_LINE_STRIP = 0x0003;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_ES_VERSION_3_2 && !GL_SC_VERSION_2_0)
        public const GLenum GL_TRIANGLES = 0x0004;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_TRIANGLE_STRIP = 0x0005;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_TRIANGLE_FAN = 0x0006;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_QUADS = 0x0007;

#endif
        public const GLenum GL_QUAD_STRIP = 0x0008;
        public const GLenum GL_POLYGON = 0x0009;
        public const GLenum GL_ACCUM = 0x0100;
        public const GLenum GL_LOAD = 0x0101;
        public const GLenum GL_RETURN = 0x0102;
        public const GLenum GL_MULT = 0x0103;
        public const GLenum GL_ADD = 0x0104;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_NEVER = 0x0200;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_LESS = 0x0201;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_ES_VERSION_3_2 && !GL_SC_VERSION_2_0)
        public const GLenum GL_EQUAL = 0x0202;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_LEQUAL = 0x0203;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_GREATER = 0x0204;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_NOTEQUAL = 0x0205;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_GEQUAL = 0x0206;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_ALWAYS = 0x0207;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_SRC_COLOR = 0x0300;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_ONE_MINUS_SRC_COLOR = 0x0301;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_SRC_ALPHA = 0x0302;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_ONE_MINUS_SRC_ALPHA = 0x0303;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_DST_ALPHA = 0x0304;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_ONE_MINUS_DST_ALPHA = 0x0305;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_DST_COLOR = 0x0306;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_ONE_MINUS_DST_COLOR = 0x0307;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_SRC_ALPHA_SATURATE = 0x0308;

#endif
        public const GLenum GL_FRONT_LEFT = 0x0400;
        public const GLenum GL_FRONT_RIGHT = 0x0401;
        public const GLenum GL_BACK_LEFT = 0x0402;
        public const GLenum GL_BACK_RIGHT = 0x0403;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_FRONT = 0x0404;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_BACK = 0x0405;

#endif
        public const GLenum GL_LEFT = 0x0406;
        public const GLenum GL_RIGHT = 0x0407;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_FRONT_AND_BACK = 0x0408;

#endif
        public const GLenum GL_AUX0 = 0x0409;
        public const GLenum GL_AUX1 = 0x040A;
        public const GLenum GL_AUX2 = 0x040B;
        public const GLenum GL_AUX3 = 0x040C;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_INVALID_ENUM = 0x0500;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_INVALID_VALUE = 0x0501;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_INVALID_OPERATION = 0x0502;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_STACK_OVERFLOW = 0x0503;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_STACK_UNDERFLOW = 0x0504;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_OUT_OF_MEMORY = 0x0505;

#endif
        public const GLenum GL_2D = 0x0600;
        public const GLenum GL_3D = 0x0601;
        public const GLenum GL_3D_COLOR = 0x0602;
        public const GLenum GL_3D_COLOR_TEXTURE = 0x0603;
        public const GLenum GL_4D_COLOR_TEXTURE = 0x0604;
        public const GLenum GL_PASS_THROUGH_TOKEN = 0x0700;
        public const GLenum GL_POINT_TOKEN = 0x0701;
        public const GLenum GL_LINE_TOKEN = 0x0702;
        public const GLenum GL_POLYGON_TOKEN = 0x0703;
        public const GLenum GL_BITMAP_TOKEN = 0x0704;
        public const GLenum GL_DRAW_PIXEL_TOKEN = 0x0705;
        public const GLenum GL_COPY_PIXEL_TOKEN = 0x0706;
        public const GLenum GL_LINE_RESET_TOKEN = 0x0707;
        public const GLenum GL_EXP = 0x0800;
        public const GLenum GL_EXP2 = 0x0801;

#if (!GL_ES_VERSION_2_0 && !GL_ES_VERSION_3_2 && !GL_SC_VERSION_2_0)
        public const GLenum GL_CW = 0x0900;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_ES_VERSION_3_2 && !GL_SC_VERSION_2_0)
        public const GLenum GL_CCW = 0x0901;

#endif
        public const GLenum GL_COEFF = 0x0A00;
        public const GLenum GL_ORDER = 0x0A01;
        public const GLenum GL_DOMAIN = 0x0A02;
        public const GLenum GL_CURRENT_COLOR = 0x0B00;
        public const GLenum GL_CURRENT_INDEX = 0x0B01;
        public const GLenum GL_CURRENT_NORMAL = 0x0B02;
        public const GLenum GL_CURRENT_TEXTURE_COORDS = 0x0B03;
        public const GLenum GL_CURRENT_RASTER_COLOR = 0x0B04;
        public const GLenum GL_CURRENT_RASTER_INDEX = 0x0B05;
        public const GLenum GL_CURRENT_RASTER_TEXTURE_COORDS = 0x0B06;
        public const GLenum GL_CURRENT_RASTER_POSITION = 0x0B07;
        public const GLenum GL_CURRENT_RASTER_POSITION_VALID = 0x0B08;
        public const GLenum GL_CURRENT_RASTER_DISTANCE = 0x0B09;
        public const GLenum GL_POINT_SMOOTH = 0x0B10;
        public const GLenum GL_POINT_SIZE = 0x0B11;
        public const GLenum GL_POINT_SIZE_RANGE = 0x0B12;
        public const GLenum GL_POINT_SIZE_GRANULARITY = 0x0B13;
        public const GLenum GL_LINE_SMOOTH = 0x0B20;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_LINE_WIDTH = 0x0B21;

#endif
        public const GLenum GL_LINE_WIDTH_RANGE = 0x0B22;
        public const GLenum GL_LINE_WIDTH_GRANULARITY = 0x0B23;
        public const GLenum GL_LINE_STIPPLE = 0x0B24;
        public const GLenum GL_LINE_STIPPLE_PATTERN = 0x0B25;
        public const GLenum GL_LINE_STIPPLE_REPEAT = 0x0B26;
        public const GLenum GL_LIST_MODE = 0x0B30;
        public const GLenum GL_MAX_LIST_NESTING = 0x0B31;
        public const GLenum GL_LIST_BASE = 0x0B32;
        public const GLenum GL_LIST_INDEX = 0x0B33;
        public const GLenum GL_POLYGON_MODE = 0x0B40;
        public const GLenum GL_POLYGON_SMOOTH = 0x0B41;
        public const GLenum GL_POLYGON_STIPPLE = 0x0B42;
        public const GLenum GL_EDGE_FLAG = 0x0B43;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_CULL_FACE = 0x0B44;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_CULL_FACE_MODE = 0x0B45;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_FRONT_FACE = 0x0B46;

#endif
        public const GLenum GL_LIGHTING = 0x0B50;
        public const GLenum GL_LIGHT_MODEL_LOCAL_VIEWER = 0x0B51;
        public const GLenum GL_LIGHT_MODEL_TWO_SIDE = 0x0B52;
        public const GLenum GL_LIGHT_MODEL_AMBIENT = 0x0B53;
        public const GLenum GL_SHADE_MODEL = 0x0B54;
        public const GLenum GL_COLOR_MATERIAL_FACE = 0x0B55;
        public const GLenum GL_COLOR_MATERIAL_PARAMETER = 0x0B56;
        public const GLenum GL_COLOR_MATERIAL = 0x0B57;
        public const GLenum GL_FOG = 0x0B60;
        public const GLenum GL_FOG_INDEX = 0x0B61;
        public const GLenum GL_FOG_DENSITY = 0x0B62;
        public const GLenum GL_FOG_START = 0x0B63;
        public const GLenum GL_FOG_END = 0x0B64;
        public const GLenum GL_FOG_MODE = 0x0B65;
        public const GLenum GL_FOG_COLOR = 0x0B66;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEPTH_RANGE = 0x0B70;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEPTH_TEST = 0x0B71;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEPTH_WRITEMASK = 0x0B72;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEPTH_CLEAR_VALUE = 0x0B73;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEPTH_FUNC = 0x0B74;

#endif
        public const GLenum GL_ACCUM_CLEAR_VALUE = 0x0B80;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_STENCIL_TEST = 0x0B90;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_STENCIL_CLEAR_VALUE = 0x0B91;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_STENCIL_FUNC = 0x0B92;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_STENCIL_VALUE_MASK = 0x0B93;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_STENCIL_FAIL = 0x0B94;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_STENCIL_PASS_DEPTH_FAIL = 0x0B95;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_STENCIL_PASS_DEPTH_PASS = 0x0B96;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_STENCIL_REF = 0x0B97;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_STENCIL_WRITEMASK = 0x0B98;

#endif
        public const GLenum GL_MATRIX_MODE = 0x0BA0;
        public const GLenum GL_NORMALIZE = 0x0BA1;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_VIEWPORT = 0x0BA2;

#endif
        public const GLenum GL_MODELVIEW_STACK_DEPTH = 0x0BA3;
        public const GLenum GL_PROJECTION_STACK_DEPTH = 0x0BA4;
        public const GLenum GL_TEXTURE_STACK_DEPTH = 0x0BA5;
        public const GLenum GL_MODELVIEW_MATRIX = 0x0BA6;
        public const GLenum GL_PROJECTION_MATRIX = 0x0BA7;
        public const GLenum GL_TEXTURE_MATRIX = 0x0BA8;
        public const GLenum GL_ATTRIB_STACK_DEPTH = 0x0BB0;
        public const GLenum GL_ALPHA_TEST = 0x0BC0;
        public const GLenum GL_ALPHA_TEST_FUNC = 0x0BC1;
        public const GLenum GL_ALPHA_TEST_REF = 0x0BC2;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_DITHER = 0x0BD0;

#endif
        public const GLenum GL_BLEND_DST = 0x0BE0;
        public const GLenum GL_BLEND_SRC = 0x0BE1;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_BLEND = 0x0BE2;

#endif
        public const GLenum GL_LOGIC_OP_MODE = 0x0BF0;
        public const GLenum GL_LOGIC_OP = 0x0BF1;
        public const GLenum GL_AUX_BUFFERS = 0x0C00;
        public const GLenum GL_DRAW_BUFFER = 0x0C01;

#if !GL_ES_VERSION_3_0
        public const GLenum GL_READ_BUFFER = 0x0C02;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_SCISSOR_BOX = 0x0C10;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_SCISSOR_TEST = 0x0C11;

#endif
        public const GLenum GL_INDEX_CLEAR_VALUE = 0x0C20;
        public const GLenum GL_INDEX_WRITEMASK = 0x0C21;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_CLEAR_VALUE = 0x0C22;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_COLOR_WRITEMASK = 0x0C23;

#endif
        public const GLenum GL_INDEX_MODE = 0x0C30;
        public const GLenum GL_RGBA_MODE = 0x0C31;
        public const GLenum GL_DOUBLEBUFFER = 0x0C32;
        public const GLenum GL_STEREO = 0x0C33;
        public const GLenum GL_RENDER_MODE = 0x0C40;
        public const GLenum GL_PERSPECTIVE_CORRECTION_HINT = 0x0C50;
        public const GLenum GL_POINT_SMOOTH_HINT = 0x0C51;
        public const GLenum GL_LINE_SMOOTH_HINT = 0x0C52;
        public const GLenum GL_POLYGON_SMOOTH_HINT = 0x0C53;
        public const GLenum GL_FOG_HINT = 0x0C54;
        public const GLenum GL_TEXTURE_GEN_S = 0x0C60;
        public const GLenum GL_TEXTURE_GEN_T = 0x0C61;
        public const GLenum GL_TEXTURE_GEN_R = 0x0C62;
        public const GLenum GL_TEXTURE_GEN_Q = 0x0C63;
        public const GLenum GL_PIXEL_MAP_I_TO_I = 0x0C70;
        public const GLenum GL_PIXEL_MAP_S_TO_S = 0x0C71;
        public const GLenum GL_PIXEL_MAP_I_TO_R = 0x0C72;
        public const GLenum GL_PIXEL_MAP_I_TO_G = 0x0C73;
        public const GLenum GL_PIXEL_MAP_I_TO_B = 0x0C74;
        public const GLenum GL_PIXEL_MAP_I_TO_A = 0x0C75;
        public const GLenum GL_PIXEL_MAP_R_TO_R = 0x0C76;
        public const GLenum GL_PIXEL_MAP_G_TO_G = 0x0C77;
        public const GLenum GL_PIXEL_MAP_B_TO_B = 0x0C78;
        public const GLenum GL_PIXEL_MAP_A_TO_A = 0x0C79;
        public const GLenum GL_PIXEL_MAP_I_TO_I_SIZE = 0x0CB0;
        public const GLenum GL_PIXEL_MAP_S_TO_S_SIZE = 0x0CB1;
        public const GLenum GL_PIXEL_MAP_I_TO_R_SIZE = 0x0CB2;
        public const GLenum GL_PIXEL_MAP_I_TO_G_SIZE = 0x0CB3;
        public const GLenum GL_PIXEL_MAP_I_TO_B_SIZE = 0x0CB4;
        public const GLenum GL_PIXEL_MAP_I_TO_A_SIZE = 0x0CB5;
        public const GLenum GL_PIXEL_MAP_R_TO_R_SIZE = 0x0CB6;
        public const GLenum GL_PIXEL_MAP_G_TO_G_SIZE = 0x0CB7;
        public const GLenum GL_PIXEL_MAP_B_TO_B_SIZE = 0x0CB8;
        public const GLenum GL_PIXEL_MAP_A_TO_A_SIZE = 0x0CB9;
        public const GLenum GL_UNPACK_SWAP_BYTES = 0x0CF0;
        public const GLenum GL_UNPACK_LSB_FIRST = 0x0CF1;

#if !GL_ES_VERSION_3_0
        public const GLenum GL_UNPACK_ROW_LENGTH = 0x0CF2;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_UNPACK_SKIP_ROWS = 0x0CF3;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_UNPACK_SKIP_PIXELS = 0x0CF4;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_UNPACK_ALIGNMENT = 0x0CF5;

#endif
        public const GLenum GL_PACK_SWAP_BYTES = 0x0D00;
        public const GLenum GL_PACK_LSB_FIRST = 0x0D01;

#if !GL_ES_VERSION_3_0
        public const GLenum GL_PACK_ROW_LENGTH = 0x0D02;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_PACK_SKIP_ROWS = 0x0D03;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_PACK_SKIP_PIXELS = 0x0D04;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_PACK_ALIGNMENT = 0x0D05;

#endif
        public const GLenum GL_MAP_COLOR = 0x0D10;
        public const GLenum GL_MAP_STENCIL = 0x0D11;
        public const GLenum GL_INDEX_SHIFT = 0x0D12;
        public const GLenum GL_INDEX_OFFSET = 0x0D13;
        public const GLenum GL_RED_SCALE = 0x0D14;
        public const GLenum GL_RED_BIAS = 0x0D15;
        public const GLenum GL_ZOOM_X = 0x0D16;
        public const GLenum GL_ZOOM_Y = 0x0D17;
        public const GLenum GL_GREEN_SCALE = 0x0D18;
        public const GLenum GL_GREEN_BIAS = 0x0D19;
        public const GLenum GL_BLUE_SCALE = 0x0D1A;
        public const GLenum GL_BLUE_BIAS = 0x0D1B;
        public const GLenum GL_ALPHA_SCALE = 0x0D1C;
        public const GLenum GL_ALPHA_BIAS = 0x0D1D;
        public const GLenum GL_DEPTH_SCALE = 0x0D1E;
        public const GLenum GL_DEPTH_BIAS = 0x0D1F;
        public const GLenum GL_MAX_EVAL_ORDER = 0x0D30;
        public const GLenum GL_MAX_LIGHTS = 0x0D31;
        public const GLenum GL_MAX_CLIP_PLANES = 0x0D32;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TEXTURE_SIZE = 0x0D33;

#endif
        public const GLenum GL_MAX_PIXEL_MAP_TABLE = 0x0D34;
        public const GLenum GL_MAX_ATTRIB_STACK_DEPTH = 0x0D35;
        public const GLenum GL_MAX_MODELVIEW_STACK_DEPTH = 0x0D36;
        public const GLenum GL_MAX_NAME_STACK_DEPTH = 0x0D37;
        public const GLenum GL_MAX_PROJECTION_STACK_DEPTH = 0x0D38;
        public const GLenum GL_MAX_TEXTURE_STACK_DEPTH = 0x0D39;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_VIEWPORT_DIMS = 0x0D3A;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_SUBPIXEL_BITS = 0x0D50;

#endif
        public const GLbitfield GL_INDEX_BITS = 0x0D51;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_RED_BITS = 0x0D52;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_GREEN_BITS = 0x0D53;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_BLUE_BITS = 0x0D54;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_ALPHA_BITS = 0x0D55;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_DEPTH_BITS = 0x0D56;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLbitfield GL_STENCIL_BITS = 0x0D57;

#endif
        public const GLbitfield GL_ACCUM_RED_BITS = 0x0D58;
        public const GLbitfield GL_ACCUM_GREEN_BITS = 0x0D59;
        public const GLbitfield GL_ACCUM_BLUE_BITS = 0x0D5A;
        public const GLbitfield GL_ACCUM_ALPHA_BITS = 0x0D5B;
        public const GLenum GL_NAME_STACK_DEPTH = 0x0D70;
        public const GLenum GL_AUTO_NORMAL = 0x0D80;
        public const GLenum GL_MAP1_COLOR_4 = 0x0D90;
        public const GLenum GL_MAP1_INDEX = 0x0D91;
        public const GLenum GL_MAP1_NORMAL = 0x0D92;
        public const GLenum GL_MAP1_TEXTURE_COORD_1 = 0x0D93;
        public const GLenum GL_MAP1_TEXTURE_COORD_2 = 0x0D94;
        public const GLenum GL_MAP1_TEXTURE_COORD_3 = 0x0D95;
        public const GLenum GL_MAP1_TEXTURE_COORD_4 = 0x0D96;
        public const GLenum GL_MAP1_VERTEX_3 = 0x0D97;
        public const GLenum GL_MAP1_VERTEX_4 = 0x0D98;
        public const GLenum GL_MAP2_COLOR_4 = 0x0DB0;
        public const GLenum GL_MAP2_INDEX = 0x0DB1;
        public const GLenum GL_MAP2_NORMAL = 0x0DB2;
        public const GLenum GL_MAP2_TEXTURE_COORD_1 = 0x0DB3;
        public const GLenum GL_MAP2_TEXTURE_COORD_2 = 0x0DB4;
        public const GLenum GL_MAP2_TEXTURE_COORD_3 = 0x0DB5;
        public const GLenum GL_MAP2_TEXTURE_COORD_4 = 0x0DB6;
        public const GLenum GL_MAP2_VERTEX_3 = 0x0DB7;
        public const GLenum GL_MAP2_VERTEX_4 = 0x0DB8;
        public const GLenum GL_MAP1_GRID_DOMAIN = 0x0DD0;
        public const GLenum GL_MAP1_GRID_SEGMENTS = 0x0DD1;
        public const GLenum GL_MAP2_GRID_DOMAIN = 0x0DD2;
        public const GLenum GL_MAP2_GRID_SEGMENTS = 0x0DD3;
        public const GLenum GL_TEXTURE_1D = 0x0DE0;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_2D = 0x0DE1;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_TEXTURE_WIDTH = 0x1000;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_TEXTURE_HEIGHT = 0x1001;

#endif
        public const GLenum GL_TEXTURE_COMPONENTS = 0x1003;

#if !GL_ES_VERSION_3_2
        public const GLenum GL_TEXTURE_BORDER_COLOR = 0x1004;

#endif
        public const GLenum GL_TEXTURE_BORDER = 0x1005;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_DONT_CARE = 0x1100;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_FASTEST = 0x1101;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_NICEST = 0x1102;

#endif
        public const GLenum GL_AMBIENT = 0x1200;
        public const GLenum GL_DIFFUSE = 0x1201;
        public const GLenum GL_SPECULAR = 0x1202;
        public const GLenum GL_POSITION = 0x1203;
        public const GLenum GL_SPOT_DIRECTION = 0x1204;
        public const GLenum GL_SPOT_EXPONENT = 0x1205;
        public const GLenum GL_SPOT_CUTOFF = 0x1206;
        public const GLenum GL_CONSTANT_ATTENUATION = 0x1207;
        public const GLenum GL_LINEAR_ATTENUATION = 0x1208;
        public const GLenum GL_QUADRATIC_ATTENUATION = 0x1209;
        public const GLenum GL_COMPILE = 0x1300;
        public const GLenum GL_COMPILE_AND_EXECUTE = 0x1301;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_BYTE = 0x1400;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_BYTE = 0x1401;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_SHORT = 0x1402;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_SHORT = 0x1403;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_INT = 0x1404;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT = 0x1405;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_FLOAT = 0x1406;

#endif
        public const GLenum GL_2_BYTES = 0x1407;
        public const GLenum GL_3_BYTES = 0x1408;
        public const GLenum GL_4_BYTES = 0x1409;
        public const GLenum GL_CLEAR = 0x1500;
        public const GLenum GL_AND = 0x1501;
        public const GLenum GL_AND_REVERSE = 0x1502;
        public const GLenum GL_COPY = 0x1503;
        public const GLenum GL_AND_INVERTED = 0x1504;
        public const GLenum GL_NOOP = 0x1505;
        public const GLenum GL_XOR = 0x1506;
        public const GLenum GL_OR = 0x1507;
        public const GLenum GL_NOR = 0x1508;
        public const GLenum GL_EQUIV = 0x1509;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_INVERT = 0x150A;

#endif
        public const GLenum GL_OR_REVERSE = 0x150B;
        public const GLenum GL_COPY_INVERTED = 0x150C;
        public const GLenum GL_OR_INVERTED = 0x150D;
        public const GLenum GL_NAND = 0x150E;
        public const GLenum GL_SET = 0x150F;
        public const GLenum GL_EMISSION = 0x1600;
        public const GLenum GL_SHININESS = 0x1601;
        public const GLenum GL_AMBIENT_AND_DIFFUSE = 0x1602;
        public const GLenum GL_COLOR_INDEXES = 0x1603;
        public const GLenum GL_MODELVIEW = 0x1700;
        public const GLenum GL_PROJECTION = 0x1701;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE = 0x1702;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_COLOR = 0x1800;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_DEPTH = 0x1801;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_STENCIL = 0x1802;

#endif
        public const GLenum GL_COLOR_INDEX = 0x1900;

#if (!GL_ES_VERSION_3_1 && !GL_ES_VERSION_3_2)
        public const GLenum GL_STENCIL_INDEX = 0x1901;

#endif

#if !GL_ES_VERSION_2_0
        public const GLenum GL_DEPTH_COMPONENT = 0x1902;

#endif

#if (!GL_ES_VERSION_3_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_RED = 0x1903;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_GREEN = 0x1904;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_BLUE = 0x1905;

#endif

#if !GL_ES_VERSION_2_0
        public const GLenum GL_ALPHA = 0x1906;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_RGB = 0x1907;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_RGBA = 0x1908;

#endif

#if !GL_ES_VERSION_2_0
        public const GLenum GL_LUMINANCE = 0x1909;

#endif

#if !GL_ES_VERSION_2_0
        public const GLenum GL_LUMINANCE_ALPHA = 0x190A;

#endif
        public const GLenum GL_BITMAP = 0x1A00;
        public const GLenum GL_POINT = 0x1B00;
        public const GLenum GL_LINE = 0x1B01;
        public const GLenum GL_FILL = 0x1B02;
        public const GLenum GL_RENDER = 0x1C00;
        public const GLenum GL_FEEDBACK = 0x1C01;
        public const GLenum GL_SELECT = 0x1C02;
        public const GLenum GL_FLAT = 0x1D00;
        public const GLenum GL_SMOOTH = 0x1D01;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_KEEP = 0x1E00;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_REPLACE = 0x1E01;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_INCR = 0x1E02;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_DECR = 0x1E03;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_VENDOR = 0x1F00;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_RENDERER = 0x1F01;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_VERSION = 0x1F02;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_EXTENSIONS = 0x1F03;

#endif
        public const GLenum GL_S = 0x2000;
        public const GLenum GL_T = 0x2001;
        public const GLenum GL_R = 0x2002;
        public const GLenum GL_Q = 0x2003;
        public const GLenum GL_MODULATE = 0x2100;
        public const GLenum GL_DECAL = 0x2101;
        public const GLenum GL_TEXTURE_ENV_MODE = 0x2200;
        public const GLenum GL_TEXTURE_ENV_COLOR = 0x2201;
        public const GLenum GL_TEXTURE_ENV = 0x2300;
        public const GLenum GL_EYE_LINEAR = 0x2400;
        public const GLenum GL_OBJECT_LINEAR = 0x2401;
        public const GLenum GL_SPHERE_MAP = 0x2402;
        public const GLenum GL_TEXTURE_GEN_MODE = 0x2500;
        public const GLenum GL_OBJECT_PLANE = 0x2501;
        public const GLenum GL_EYE_PLANE = 0x2502;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_NEAREST = 0x2600;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_LINEAR = 0x2601;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_NEAREST_MIPMAP_NEAREST = 0x2700;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_LINEAR_MIPMAP_NEAREST = 0x2701;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_NEAREST_MIPMAP_LINEAR = 0x2702;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_LINEAR_MIPMAP_LINEAR = 0x2703;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_MAG_FILTER = 0x2800;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_MIN_FILTER = 0x2801;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_WRAP_S = 0x2802;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_WRAP_T = 0x2803;

#endif
        public const GLenum GL_CLAMP = 0x2900;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_REPEAT = 0x2901;

#endif
        public const GLenum GL_CLIP_PLANE0 = 0x3000;
        public const GLenum GL_CLIP_PLANE1 = 0x3001;
        public const GLenum GL_CLIP_PLANE2 = 0x3002;
        public const GLenum GL_CLIP_PLANE3 = 0x3003;
        public const GLenum GL_CLIP_PLANE4 = 0x3004;
        public const GLenum GL_CLIP_PLANE5 = 0x3005;
        public const GLenum GL_LIGHT0 = 0x4000;
        public const GLenum GL_LIGHT1 = 0x4001;
        public const GLenum GL_LIGHT2 = 0x4002;
        public const GLenum GL_LIGHT3 = 0x4003;
        public const GLenum GL_LIGHT4 = 0x4004;
        public const GLenum GL_LIGHT5 = 0x4005;
        public const GLenum GL_LIGHT6 = 0x4006;
        public const GLenum GL_LIGHT7 = 0x4007;
    }
}
#endif