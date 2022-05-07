#if (GL_ATI_vertex_array_object && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_STATIC_ATI = 0x8760;
        public const GLenum GL_DYNAMIC_ATI = 0x8761;
        public const GLenum GL_PRESERVE_ATI = 0x8762;
        public const GLenum GL_DISCARD_ATI = 0x8763;
        public const GLenum GL_OBJECT_BUFFER_SIZE_ATI = 0x8764;
        public const GLenum GL_OBJECT_BUFFER_USAGE_ATI = 0x8765;
        public const GLenum GL_ARRAY_OBJECT_BUFFER_ATI = 0x8766;
        public const GLenum GL_ARRAY_OBJECT_OFFSET_ATI = 0x8767;
    }
}
#endif