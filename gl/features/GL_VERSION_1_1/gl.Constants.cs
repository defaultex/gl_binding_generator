#if (GL_VERSION_1_1 && GL_API)
public partial class gl { 
    public partial class Constants { 

#if !GL_SC_VERSION_2_0
        public const GLbitfield GL_CLIENT_PIXEL_STORE_BIT = 0x00000001;
#endif

#if !GL_SC_VERSION_2_0
        public const GLbitfield GL_CLIENT_VERTEX_ARRAY_BIT = 0x00000002;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_CLIENT_ATTRIB_STACK_DEPTH = 0x0BB1;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_INDEX_LOGIC_OP = 0x0BF1;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_COLOR_LOGIC_OP = 0x0BF2;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_MAX_CLIENT_ATTRIB_STACK_DEPTH = 0x0D3B;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_FEEDBACK_BUFFER_POINTER = 0x0DF0;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_FEEDBACK_BUFFER_SIZE = 0x0DF1;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_FEEDBACK_BUFFER_TYPE = 0x0DF2;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_SELECTION_BUFFER_POINTER = 0x0DF3;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_SELECTION_BUFFER_SIZE = 0x0DF4;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_INTERNAL_FORMAT = 0x1003;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_DOUBLE = 0x140A;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_POLYGON_OFFSET_UNITS = 0x2A00;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_POLYGON_OFFSET_POINT = 0x2A01;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_POLYGON_OFFSET_LINE = 0x2A02;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_R3_G3_B2 = 0x2A10;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_V2F = 0x2A20;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_V3F = 0x2A21;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_C4UB_V2F = 0x2A22;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_C4UB_V3F = 0x2A23;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_C3F_V3F = 0x2A24;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_N3F_V3F = 0x2A25;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_C4F_N3F_V3F = 0x2A26;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_T2F_V3F = 0x2A27;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_T4F_V4F = 0x2A28;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_T2F_C4UB_V3F = 0x2A29;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_T2F_C3F_V3F = 0x2A2A;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_T2F_N3F_V3F = 0x2A2B;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_T2F_C4F_N3F_V3F = 0x2A2C;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_T4F_C4F_N3F_V4F = 0x2A2D;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_POLYGON_OFFSET_FILL = 0x8037;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_POLYGON_OFFSET_FACTOR = 0x8038;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_ALPHA4 = 0x803B;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_ALPHA8 = 0x803C;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_ALPHA12 = 0x803D;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_ALPHA16 = 0x803E;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_LUMINANCE4 = 0x803F;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_LUMINANCE8 = 0x8040;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_LUMINANCE12 = 0x8041;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_LUMINANCE16 = 0x8042;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_LUMINANCE4_ALPHA4 = 0x8043;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_LUMINANCE6_ALPHA2 = 0x8044;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_LUMINANCE8_ALPHA8 = 0x8045;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_LUMINANCE12_ALPHA4 = 0x8046;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_LUMINANCE12_ALPHA12 = 0x8047;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_LUMINANCE16_ALPHA16 = 0x8048;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_INTENSITY = 0x8049;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_INTENSITY4 = 0x804A;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_INTENSITY8 = 0x804B;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_INTENSITY12 = 0x804C;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_INTENSITY16 = 0x804D;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_RGB4 = 0x804F;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_RGB5 = 0x8050;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_RGB8 = 0x8051;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_RGB10 = 0x8052;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_RGB12 = 0x8053;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_RGB16 = 0x8054;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_RGBA2 = 0x8055;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_RGBA4 = 0x8056;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_RGB5_A1 = 0x8057;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_RGBA8 = 0x8058;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_RGB10_A2 = 0x8059;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_RGBA12 = 0x805A;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_RGBA16 = 0x805B;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_RED_SIZE = 0x805C;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_GREEN_SIZE = 0x805D;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_BLUE_SIZE = 0x805E;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_ALPHA_SIZE = 0x805F;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_LUMINANCE_SIZE = 0x8060;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_INTENSITY_SIZE = 0x8061;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_PROXY_TEXTURE_1D = 0x8063;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_PROXY_TEXTURE_2D = 0x8064;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_PRIORITY = 0x8066;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_RESIDENT = 0x8067;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_BINDING_1D = 0x8068;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_BINDING_2D = 0x8069;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_VERTEX_ARRAY = 0x8074;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_NORMAL_ARRAY = 0x8075;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_COLOR_ARRAY = 0x8076;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_INDEX_ARRAY = 0x8077;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_COORD_ARRAY = 0x8078;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_EDGE_FLAG_ARRAY = 0x8079;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_VERTEX_ARRAY_SIZE = 0x807A;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_VERTEX_ARRAY_TYPE = 0x807B;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_VERTEX_ARRAY_STRIDE = 0x807C;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_NORMAL_ARRAY_TYPE = 0x807E;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_NORMAL_ARRAY_STRIDE = 0x807F;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_COLOR_ARRAY_SIZE = 0x8081;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_COLOR_ARRAY_TYPE = 0x8082;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_COLOR_ARRAY_STRIDE = 0x8083;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_INDEX_ARRAY_TYPE = 0x8085;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_INDEX_ARRAY_STRIDE = 0x8086;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_COORD_ARRAY_SIZE = 0x8088;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_COORD_ARRAY_TYPE = 0x8089;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_COORD_ARRAY_STRIDE = 0x808A;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_EDGE_FLAG_ARRAY_STRIDE = 0x808C;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_VERTEX_ARRAY_POINTER = 0x808E;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_NORMAL_ARRAY_POINTER = 0x808F;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_COLOR_ARRAY_POINTER = 0x8090;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_INDEX_ARRAY_POINTER = 0x8091;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_TEXTURE_COORD_ARRAY_POINTER = 0x8092;
#endif

#if !GL_SC_VERSION_2_0
        public const GLenum GL_EDGE_FLAG_ARRAY_POINTER = 0x8093;
#endif

#if !GL_SC_VERSION_2_0
        public const GLbitfield GL_CLIENT_ALL_ATTRIB_BITS = 0xFFFFFFFF;
#endif
    }
}
#endif