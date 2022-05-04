#if (GL_EXT_blend_equation_separate && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BLEND_EQUATION_RGB_EXT = 0x8009;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BLEND_EQUATION_ALPHA_EXT = 0x883D;
#endif
    }
}
#endif