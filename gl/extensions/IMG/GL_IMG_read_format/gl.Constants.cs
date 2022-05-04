#if (GL_IMG_read_format && (GLES1_API || GLES2_API))
public partial class img { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BGRA_IMG = 0x80E1;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNSIGNED_SHORT_4_4_4_4_REV_IMG = 0x8365;
#endif
    }
}
#endif