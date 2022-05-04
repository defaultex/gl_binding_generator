#if (GL_EXT_EGL_image_storage_compression && GLES2_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SURFACE_COMPRESSION_EXT = 0x96C0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SURFACE_COMPRESSION_FIXED_RATE_NONE_EXT = 0x96C1;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SURFACE_COMPRESSION_FIXED_RATE_DEFAULT_EXT = 0x96C2;
#endif
    }
}
#endif