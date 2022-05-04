#if (GL_OML_interlace && GL_API)
public partial class oml { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INTERLACE_OML = 0x8980;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_INTERLACE_READ_OML = 0x8981;
#endif
    }
}
#endif