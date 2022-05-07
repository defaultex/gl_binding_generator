#if (GL_ARB_vertex_buffer_object && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_BUFFER_SIZE_ARB = 0x8764;
        public const GLenum GL_BUFFER_USAGE_ARB = 0x8765;
        public const GLenum GL_ARRAY_BUFFER_ARB = 0x8892;
        public const GLenum GL_ELEMENT_ARRAY_BUFFER_ARB = 0x8893;
        public const GLenum GL_ARRAY_BUFFER_BINDING_ARB = 0x8894;
        public const GLenum GL_ELEMENT_ARRAY_BUFFER_BINDING_ARB = 0x8895;
        public const GLenum GL_VERTEX_ARRAY_BUFFER_BINDING_ARB = 0x8896;
        public const GLenum GL_NORMAL_ARRAY_BUFFER_BINDING_ARB = 0x8897;
        public const GLenum GL_COLOR_ARRAY_BUFFER_BINDING_ARB = 0x8898;
        public const GLenum GL_INDEX_ARRAY_BUFFER_BINDING_ARB = 0x8899;
        public const GLenum GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING_ARB = 0x889A;
        public const GLenum GL_EDGE_FLAG_ARRAY_BUFFER_BINDING_ARB = 0x889B;
        public const GLenum GL_SECONDARY_COLOR_ARRAY_BUFFER_BINDING_ARB = 0x889C;
        public const GLenum GL_FOG_COORDINATE_ARRAY_BUFFER_BINDING_ARB = 0x889D;
        public const GLenum GL_WEIGHT_ARRAY_BUFFER_BINDING_ARB = 0x889E;
        public const GLenum GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING_ARB = 0x889F;
        public const GLenum GL_READ_ONLY_ARB = 0x88B8;
        public const GLenum GL_WRITE_ONLY_ARB = 0x88B9;
        public const GLenum GL_READ_WRITE_ARB = 0x88BA;
        public const GLenum GL_BUFFER_ACCESS_ARB = 0x88BB;
        public const GLenum GL_BUFFER_MAPPED_ARB = 0x88BC;
        public const GLenum GL_BUFFER_MAP_POINTER_ARB = 0x88BD;
        public const GLenum GL_STREAM_DRAW_ARB = 0x88E0;
        public const GLenum GL_STREAM_READ_ARB = 0x88E1;
        public const GLenum GL_STREAM_COPY_ARB = 0x88E2;
        public const GLenum GL_STATIC_DRAW_ARB = 0x88E4;
        public const GLenum GL_STATIC_READ_ARB = 0x88E5;
        public const GLenum GL_STATIC_COPY_ARB = 0x88E6;
        public const GLenum GL_DYNAMIC_DRAW_ARB = 0x88E8;
        public const GLenum GL_DYNAMIC_READ_ARB = 0x88E9;
        public const GLenum GL_DYNAMIC_COPY_ARB = 0x88EA;
    }
}
#endif