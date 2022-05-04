#if (GL_EXT_texture_format_BGRA8888 && (GLES1_API || GLES2_API))
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BGRA_EXT = 0x80E1;
#endif
    }
}
#endif