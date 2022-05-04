#if (GL_EXT_sRGB && (GLES1_API || GLES2_API))
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING_EXT = 0x8210;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SRGB_EXT = 0x8C40;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SRGB_ALPHA_EXT = 0x8C42;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SRGB8_ALPHA8_EXT = 0x8C43;
#endif
    }
}
#endif