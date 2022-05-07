#if (GL_ARB_buffer_storage && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLbitfield GL_MAP_READ_BIT = 0x0001;
        public const GLbitfield GL_MAP_WRITE_BIT = 0x0002;
        public const GLbitfield GL_MAP_PERSISTENT_BIT = 0x0040;
        public const GLbitfield GL_MAP_COHERENT_BIT = 0x0080;
        public const GLbitfield GL_DYNAMIC_STORAGE_BIT = 0x0100;
        public const GLbitfield GL_CLIENT_STORAGE_BIT = 0x0200;
        public const GLbitfield GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT = 0x00004000;
        public const GLenum GL_BUFFER_IMMUTABLE_STORAGE = 0x821F;
        public const GLenum GL_BUFFER_STORAGE_FLAGS = 0x8220;
    }
}
#endif