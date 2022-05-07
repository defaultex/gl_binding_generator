#if (GL_ARB_map_buffer_range && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLbitfield GL_MAP_READ_BIT = 0x0001;
        public const GLbitfield GL_MAP_WRITE_BIT = 0x0002;
        public const GLbitfield GL_MAP_INVALIDATE_RANGE_BIT = 0x0004;
        public const GLbitfield GL_MAP_INVALIDATE_BUFFER_BIT = 0x0008;
        public const GLbitfield GL_MAP_FLUSH_EXPLICIT_BIT = 0x0010;
        public const GLbitfield GL_MAP_UNSYNCHRONIZED_BIT = 0x0020;
    }
}
#endif