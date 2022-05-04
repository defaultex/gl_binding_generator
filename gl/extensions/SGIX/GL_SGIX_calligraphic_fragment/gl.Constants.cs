#if (GL_SGIX_calligraphic_fragment && GL_API)
public partial class sgix { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CALLIGRAPHIC_FRAGMENT_SGIX = 0x8183;
#endif
    }
}
#endif