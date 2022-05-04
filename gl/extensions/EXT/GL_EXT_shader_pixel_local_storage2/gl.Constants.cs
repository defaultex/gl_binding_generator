#if (GL_EXT_shader_pixel_local_storage2 && GLES2_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_SHADER_COMBINED_LOCAL_STORAGE_FAST_SIZE_EXT = 0x9650;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_SHADER_COMBINED_LOCAL_STORAGE_SIZE_EXT = 0x9651;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAMEBUFFER_INCOMPLETE_INSUFFICIENT_SHADER_COMBINED_LOCAL_STORAGE_EXT = 0x9652;
#endif
    }
}
#endif