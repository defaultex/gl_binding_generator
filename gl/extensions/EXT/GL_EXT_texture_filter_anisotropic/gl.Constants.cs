#if (GL_EXT_texture_filter_anisotropic && (GL_API || GLES1_API || GLES2_API))
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FF;
#endif
    }
}
#endif