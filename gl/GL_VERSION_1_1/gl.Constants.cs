#if (GL_VERSION_1_1 && GL_API)
public partial class gl { 
    public partial class Constants { 
        public const GLbitfield GL_CLIENT_PIXEL_STORE_BIT = 0x00000001;
        public const GLbitfield GL_CLIENT_VERTEX_ARRAY_BIT = 0x00000002;
        public const GLbitfield GL_CLIENT_ALL_ATTRIB_BITS = 0xFFFFFFFF;
        public const GLenum GL_CLIENT_ATTRIB_STACK_DEPTH = 0x0BB1;
        public const GLenum GL_INDEX_LOGIC_OP = 0x0BF1;
        public const GLenum GL_COLOR_LOGIC_OP = 0x0BF2;
        public const GLenum GL_MAX_CLIENT_ATTRIB_STACK_DEPTH = 0x0D3B;
        public const GLenum GL_FEEDBACK_BUFFER_POINTER = 0x0DF0;
        public const GLenum GL_FEEDBACK_BUFFER_SIZE = 0x0DF1;
        public const GLenum GL_FEEDBACK_BUFFER_TYPE = 0x0DF2;
        public const GLenum GL_SELECTION_BUFFER_POINTER = 0x0DF3;
        public const GLenum GL_SELECTION_BUFFER_SIZE = 0x0DF4;

#if !GL_ES_VERSION_3_1
        public const GLenum GL_TEXTURE_INTERNAL_FORMAT = 0x1003;

#endif
        public const GLenum GL_DOUBLE = 0x140A;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_POLYGON_OFFSET_UNITS = 0x2A00;

#endif
        public const GLenum GL_POLYGON_OFFSET_POINT = 0x2A01;
        public const GLenum GL_POLYGON_OFFSET_LINE = 0x2A02;
        public const GLenum GL_R3_G3_B2 = 0x2A10;
        public const GLenum GL_V2F = 0x2A20;
        public const GLenum GL_V3F = 0x2A21;
        public const GLenum GL_C4UB_V2F = 0x2A22;
        public const GLenum GL_C4UB_V3F = 0x2A23;
        public const GLenum GL_C3F_V3F = 0x2A24;
        public const GLenum GL_N3F_V3F = 0x2A25;
        public const GLenum GL_C4F_N3F_V3F = 0x2A26;
        public const GLenum GL_T2F_V3F = 0x2A27;
        public const GLenum GL_T4F_V4F = 0x2A28;
        public const GLenum GL_T2F_C4UB_V3F = 0x2A29;
        public const GLenum GL_T2F_C3F_V3F = 0x2A2A;
        public const GLenum GL_T2F_N3F_V3F = 0x2A2B;
        public const GLenum GL_T2F_C4F_N3F_V3F = 0x2A2C;
        public const GLenum GL_T4F_C4F_N3F_V4F = 0x2A2D;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_POLYGON_OFFSET_FILL = 0x8037;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_POLYGON_OFFSET_FACTOR = 0x8038;

#endif
        public const GLenum GL_ALPHA4 = 0x803B;
        public const GLenum GL_ALPHA8 = 0x803C;
        public const GLenum GL_ALPHA12 = 0x803D;
        public const GLenum GL_ALPHA16 = 0x803E;
        public const GLenum GL_LUMINANCE4 = 0x803F;
        public const GLenum GL_LUMINANCE8 = 0x8040;
        public const GLenum GL_LUMINANCE12 = 0x8041;
        public const GLenum GL_LUMINANCE16 = 0x8042;
        public const GLenum GL_LUMINANCE4_ALPHA4 = 0x8043;
        public const GLenum GL_LUMINANCE6_ALPHA2 = 0x8044;
        public const GLenum GL_LUMINANCE8_ALPHA8 = 0x8045;
        public const GLenum GL_LUMINANCE12_ALPHA4 = 0x8046;
        public const GLenum GL_LUMINANCE12_ALPHA12 = 0x8047;
        public const GLenum GL_LUMINANCE16_ALPHA16 = 0x8048;
        public const GLenum GL_INTENSITY = 0x8049;
        public const GLenum GL_INTENSITY4 = 0x804A;
        public const GLenum GL_INTENSITY8 = 0x804B;
        public const GLenum GL_INTENSITY12 = 0x804C;
        public const GLenum GL_INTENSITY16 = 0x804D;
        public const GLenum GL_RGB4 = 0x804F;
        public const GLenum GL_RGB5 = 0x8050;

#if (!GL_ES_VERSION_3_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_RGB8 = 0x8051;

#endif
        public const GLenum GL_RGB10 = 0x8052;
        public const GLenum GL_RGB12 = 0x8053;
        public const GLenum GL_RGB16 = 0x8054;
        public const GLenum GL_RGBA2 = 0x8055;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_RGBA4 = 0x8056;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_RGB5_A1 = 0x8057;

#endif

#if (!GL_ES_VERSION_3_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_RGBA8 = 0x8058;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_RGB10_A2 = 0x8059;

#endif
        public const GLenum GL_RGBA12 = 0x805A;
        public const GLenum GL_RGBA16 = 0x805B;

#if !GL_ES_VERSION_3_1
        public const GLenum GL_TEXTURE_RED_SIZE = 0x805C;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_TEXTURE_GREEN_SIZE = 0x805D;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_TEXTURE_BLUE_SIZE = 0x805E;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_TEXTURE_ALPHA_SIZE = 0x805F;

#endif
        public const GLenum GL_TEXTURE_LUMINANCE_SIZE = 0x8060;
        public const GLenum GL_TEXTURE_INTENSITY_SIZE = 0x8061;
        public const GLenum GL_PROXY_TEXTURE_1D = 0x8063;
        public const GLenum GL_PROXY_TEXTURE_2D = 0x8064;
        public const GLenum GL_TEXTURE_PRIORITY = 0x8066;
        public const GLenum GL_TEXTURE_RESIDENT = 0x8067;
        public const GLenum GL_TEXTURE_BINDING_1D = 0x8068;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_BINDING_2D = 0x8069;

#endif

#if !GL_ES_VERSION_3_2
        public const GLenum GL_VERTEX_ARRAY = 0x8074;

#endif
        public const GLenum GL_NORMAL_ARRAY = 0x8075;
        public const GLenum GL_COLOR_ARRAY = 0x8076;
        public const GLenum GL_INDEX_ARRAY = 0x8077;
        public const GLenum GL_TEXTURE_COORD_ARRAY = 0x8078;
        public const GLenum GL_EDGE_FLAG_ARRAY = 0x8079;
        public const GLenum GL_VERTEX_ARRAY_SIZE = 0x807A;
        public const GLenum GL_VERTEX_ARRAY_TYPE = 0x807B;
        public const GLenum GL_VERTEX_ARRAY_STRIDE = 0x807C;
        public const GLenum GL_NORMAL_ARRAY_TYPE = 0x807E;
        public const GLenum GL_NORMAL_ARRAY_STRIDE = 0x807F;
        public const GLenum GL_COLOR_ARRAY_SIZE = 0x8081;
        public const GLenum GL_COLOR_ARRAY_TYPE = 0x8082;
        public const GLenum GL_COLOR_ARRAY_STRIDE = 0x8083;
        public const GLenum GL_INDEX_ARRAY_TYPE = 0x8085;
        public const GLenum GL_INDEX_ARRAY_STRIDE = 0x8086;
        public const GLenum GL_TEXTURE_COORD_ARRAY_SIZE = 0x8088;
        public const GLenum GL_TEXTURE_COORD_ARRAY_TYPE = 0x8089;
        public const GLenum GL_TEXTURE_COORD_ARRAY_STRIDE = 0x808A;
        public const GLenum GL_EDGE_FLAG_ARRAY_STRIDE = 0x808C;
        public const GLenum GL_VERTEX_ARRAY_POINTER = 0x808E;
        public const GLenum GL_NORMAL_ARRAY_POINTER = 0x808F;
        public const GLenum GL_COLOR_ARRAY_POINTER = 0x8090;
        public const GLenum GL_INDEX_ARRAY_POINTER = 0x8091;
        public const GLenum GL_TEXTURE_COORD_ARRAY_POINTER = 0x8092;
        public const GLenum GL_EDGE_FLAG_ARRAY_POINTER = 0x8093;
    }
}
#endif