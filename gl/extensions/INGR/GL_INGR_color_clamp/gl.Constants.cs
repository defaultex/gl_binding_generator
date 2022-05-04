#if (GL_INGR_color_clamp && GL_API)
public partial class ingr { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RED_MIN_CLAMP_INGR = 0x8560;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_GREEN_MIN_CLAMP_INGR = 0x8561;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BLUE_MIN_CLAMP_INGR = 0x8562;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ALPHA_MIN_CLAMP_INGR = 0x8563;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RED_MAX_CLAMP_INGR = 0x8564;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_GREEN_MAX_CLAMP_INGR = 0x8565;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BLUE_MAX_CLAMP_INGR = 0x8566;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ALPHA_MAX_CLAMP_INGR = 0x8567;
#endif
    }
}
#endif