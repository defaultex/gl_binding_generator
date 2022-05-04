#if (GL_SGIX_pixel_texture && GL_API)
public partial class sgix { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_TEX_GEN_SGIX = 0x8139;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_TEX_GEN_MODE_SGIX = 0x832B;
#endif
    }
}
#endif