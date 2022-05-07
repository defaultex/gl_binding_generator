#if (GL_EXT_shader_pixel_local_storage && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_MAX_SHADER_PIXEL_LOCAL_STORAGE_FAST_SIZE_EXT = 0x8F63;
        public const GLenum GL_SHADER_PIXEL_LOCAL_STORAGE_EXT = 0x8F64;
        public const GLenum GL_MAX_SHADER_PIXEL_LOCAL_STORAGE_SIZE_EXT = 0x8F67;
    }
}
#endif