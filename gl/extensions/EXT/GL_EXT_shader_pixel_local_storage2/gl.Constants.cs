#if (GL_EXT_shader_pixel_local_storage2 && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_MAX_SHADER_COMBINED_LOCAL_STORAGE_FAST_SIZE_EXT = 0x9650;
        public const GLenum GL_MAX_SHADER_COMBINED_LOCAL_STORAGE_SIZE_EXT = 0x9651;
        public const GLenum GL_FRAMEBUFFER_INCOMPLETE_INSUFFICIENT_SHADER_COMBINED_LOCAL_STORAGE_EXT = 0x9652;
    }
}
#endif