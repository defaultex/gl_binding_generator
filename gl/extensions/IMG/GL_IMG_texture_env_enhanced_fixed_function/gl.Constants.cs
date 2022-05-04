#if (GL_IMG_texture_env_enhanced_fixed_function && GLES1_API)
public partial class img { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DOT3_RGBA_IMG = 0x86AF;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MODULATE_COLOR_IMG = 0x8C04;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RECIP_ADD_SIGNED_ALPHA_IMG = 0x8C05;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_ALPHA_MODULATE_IMG = 0x8C06;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FACTOR_ALPHA_MODULATE_IMG = 0x8C07;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAGMENT_ALPHA_MODULATE_IMG = 0x8C08;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ADD_BLEND_IMG = 0x8C09;
#endif
    }
}
#endif