#if (GL_OES_read_format && (GL_API || GLES1_API))
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IMPLEMENTATION_COLOR_READ_TYPE_OES = 0x8B9A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES = 0x8B9B;
#endif
    }
}
#endif