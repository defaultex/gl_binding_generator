#if (GL_OES_rgb8_rgba8 && (GLES1_API || GLES2_API || GLSC2_API))
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGB8_OES = 0x8051;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RGBA8_OES = 0x8058;
#endif
    }
}
#endif