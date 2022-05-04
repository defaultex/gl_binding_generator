#if (GL_APPLE_texture_format_BGRA8888 && (GLES1_API || GLES2_API))
public partial class apple { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BGRA_EXT = 0x80E1;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BGRA8_EXT = 0x93A1;
#endif
    }
}
#endif