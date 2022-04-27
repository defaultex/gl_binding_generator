#if (GL_VERSION_1_5 && GL_API)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_FOG_COORD_SRC = 0x8450;
        public const GLenum GL_FOG_COORD = 0x8451;
        public const GLenum GL_CURRENT_FOG_COORD = 0x8453;
        public const GLenum GL_FOG_COORD_ARRAY_TYPE = 0x8454;
        public const GLenum GL_FOG_COORD_ARRAY_STRIDE = 0x8455;
        public const GLenum GL_FOG_COORD_ARRAY_POINTER = 0x8456;
        public const GLenum GL_FOG_COORD_ARRAY = 0x8457;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_BUFFER_SIZE = 0x8764;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_BUFFER_USAGE = 0x8765;

#endif
        public const GLbitfield GL_QUERY_COUNTER_BITS = 0x8864;

#if !GL_ES_VERSION_3_0
        public const GLenum GL_CURRENT_QUERY = 0x8865;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_QUERY_RESULT = 0x8866;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_QUERY_RESULT_AVAILABLE = 0x8867;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_ARRAY_BUFFER = 0x8892;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_ELEMENT_ARRAY_BUFFER = 0x8893;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_ARRAY_BUFFER_BINDING = 0x8894;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;

#endif
        public const GLenum GL_VERTEX_ARRAY_BUFFER_BINDING = 0x8896;
        public const GLenum GL_NORMAL_ARRAY_BUFFER_BINDING = 0x8897;
        public const GLenum GL_COLOR_ARRAY_BUFFER_BINDING = 0x8898;
        public const GLenum GL_INDEX_ARRAY_BUFFER_BINDING = 0x8899;
        public const GLenum GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING = 0x889A;
        public const GLenum GL_EDGE_FLAG_ARRAY_BUFFER_BINDING = 0x889B;
        public const GLenum GL_SECONDARY_COLOR_ARRAY_BUFFER_BINDING = 0x889C;
        public const GLenum GL_FOG_COORDINATE_ARRAY_BUFFER_BINDING = 0x889D;
        public const GLenum GL_FOG_COORD_ARRAY_BUFFER_BINDING = 0x889D;
        public const GLenum GL_WEIGHT_ARRAY_BUFFER_BINDING = 0x889E;

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_READ_ONLY = 0x88B8;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_WRITE_ONLY = 0x88B9;

#endif

#if !GL_ES_VERSION_3_1
        public const GLenum GL_READ_WRITE = 0x88BA;

#endif
        public const GLenum GL_BUFFER_ACCESS = 0x88BB;

#if !GL_ES_VERSION_3_0
        public const GLenum GL_BUFFER_MAPPED = 0x88BC;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_BUFFER_MAP_POINTER = 0x88BD;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_STREAM_DRAW = 0x88E0;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_STREAM_READ = 0x88E1;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_STREAM_COPY = 0x88E2;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_STATIC_DRAW = 0x88E4;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_STATIC_READ = 0x88E5;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_STATIC_COPY = 0x88E6;

#endif

#if (!GL_ES_VERSION_2_0 && !GL_SC_VERSION_2_0)
        public const GLenum GL_DYNAMIC_DRAW = 0x88E8;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_DYNAMIC_READ = 0x88E9;

#endif

#if !GL_ES_VERSION_3_0
        public const GLenum GL_DYNAMIC_COPY = 0x88EA;

#endif
        public const GLenum GL_SAMPLES_PASSED = 0x8914;
        public const GLenum GL_SRC0_RGB = 0x8580;
        public const GLenum GL_SRC1_RGB = 0x8581;
        public const GLenum GL_SRC2_RGB = 0x8582;
        public const GLenum GL_SRC0_ALPHA = 0x8588;
        public const GLenum GL_SRC1_ALPHA = 0x8589;
        public const GLenum GL_SRC2_ALPHA = 0x858A;
    }
}
#endif