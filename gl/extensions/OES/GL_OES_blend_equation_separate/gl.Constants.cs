#if (GL_OES_blend_equation_separate && GLES1_API)
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BLEND_EQUATION_RGB_OES = 0x8009;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BLEND_EQUATION_ALPHA_OES = 0x883D;
#endif
    }
}
#endif