#if (GL_INGR_interlace_read && GL_API)
public partial class ingr { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INTERLACE_READ_INGR = 0x8568;
#endif
    }
}
#endif