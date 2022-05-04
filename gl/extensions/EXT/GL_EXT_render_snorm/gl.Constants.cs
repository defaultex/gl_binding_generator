#if (GL_EXT_render_snorm && GLES2_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_BYTE = 0x1400;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_SHORT = 0x1402;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_R8_SNORM = 0x8F94;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_RG8_SNORM = 0x8F95;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_RGBA8_SNORM = 0x8F97;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_R16_SNORM_EXT = 0x8F98;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RG16_SNORM_EXT = 0x8F99;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGBA16_SNORM_EXT = 0x8F9B;
#endif
    }
}
#endif