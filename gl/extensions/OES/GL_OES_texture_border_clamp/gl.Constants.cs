#if (GL_OES_texture_border_clamp && GLES2_API)
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_BORDER_COLOR_OES = 0x1004;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CLAMP_TO_BORDER_OES = 0x812D;
#endif
    }
}
#endif