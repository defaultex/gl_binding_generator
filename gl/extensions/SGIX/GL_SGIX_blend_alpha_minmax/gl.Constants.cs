#if (GL_SGIX_blend_alpha_minmax && GL_API)
public partial class sgix { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ALPHA_MIN_SGIX = 0x8320;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ALPHA_MAX_SGIX = 0x8321;
#endif
    }
}
#endif