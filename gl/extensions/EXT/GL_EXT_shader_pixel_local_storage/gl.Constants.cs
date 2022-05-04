#if (GL_EXT_shader_pixel_local_storage && GLES2_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_SHADER_PIXEL_LOCAL_STORAGE_FAST_SIZE_EXT = 0x8F63;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADER_PIXEL_LOCAL_STORAGE_EXT = 0x8F64;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_SHADER_PIXEL_LOCAL_STORAGE_SIZE_EXT = 0x8F67;
#endif
    }
}
#endif