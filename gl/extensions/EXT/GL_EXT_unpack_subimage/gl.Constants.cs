#if (GL_EXT_unpack_subimage && GLES2_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNPACK_ROW_LENGTH_EXT = 0x0CF2;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNPACK_SKIP_ROWS_EXT = 0x0CF3;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UNPACK_SKIP_PIXELS_EXT = 0x0CF4;
#endif
    }
}
#endif