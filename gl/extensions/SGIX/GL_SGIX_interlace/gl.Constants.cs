#if (GL_SGIX_interlace && GL_API)
public partial class sgix { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INTERLACE_SGIX = 0x8094;
#endif
    }
}
#endif