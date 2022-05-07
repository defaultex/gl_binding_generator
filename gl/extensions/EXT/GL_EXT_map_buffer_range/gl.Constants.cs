#if (GL_EXT_map_buffer_range && (!gles1 || !gles2))
public partial class gles1 { 
    public partial class Constants { 
        public const GLenum GL_MAP_READ_BIT_EXT = 0x0001;
        public const GLenum GL_MAP_WRITE_BIT_EXT = 0x0002;
        public const GLenum GL_MAP_INVALIDATE_RANGE_BIT_EXT = 0x0004;
        public const GLenum GL_MAP_INVALIDATE_BUFFER_BIT_EXT = 0x0008;
        public const GLenum GL_MAP_FLUSH_EXPLICIT_BIT_EXT = 0x0010;
        public const GLenum GL_MAP_UNSYNCHRONIZED_BIT_EXT = 0x0020;
    }
}
#endif