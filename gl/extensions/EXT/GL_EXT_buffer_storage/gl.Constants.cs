#if (GL_EXT_buffer_storage && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLbitfield GL_MAP_READ_BIT = 0x0001;
        public const GLbitfield GL_MAP_WRITE_BIT = 0x0002;
        public const GLenum GL_MAP_PERSISTENT_BIT_EXT = 0x0040;
        public const GLenum GL_MAP_COHERENT_BIT_EXT = 0x0080;
        public const GLenum GL_DYNAMIC_STORAGE_BIT_EXT = 0x0100;
        public const GLenum GL_CLIENT_STORAGE_BIT_EXT = 0x0200;
        public const GLenum GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT_EXT = 0x00004000;
        public const GLenum GL_BUFFER_IMMUTABLE_STORAGE_EXT = 0x821F;
        public const GLenum GL_BUFFER_STORAGE_FLAGS_EXT = 0x8220;
    }
}
#endif