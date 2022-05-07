#if (GL_EXT_compiled_vertex_array && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_ARRAY_ELEMENT_LOCK_FIRST_EXT = 0x81A8;
        public const GLenum GL_ARRAY_ELEMENT_LOCK_COUNT_EXT = 0x81A9;
    }
}
#endif