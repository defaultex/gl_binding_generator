#if (GL_SGIX_framezoom && GL_API)
public partial class sgix { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAMEZOOM_SGIX = 0x818B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAMEZOOM_FACTOR_SGIX = 0x818C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_FRAMEZOOM_FACTOR_SGIX = 0x818D;
#endif
    }
}
#endif