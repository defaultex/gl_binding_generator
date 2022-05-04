#if (GL_OES_blend_subtract && GLES1_API)
public partial class oes { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FUNC_ADD_OES = 0x8006;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_BLEND_EQUATION_OES = 0x8009;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FUNC_SUBTRACT_OES = 0x800A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FUNC_REVERSE_SUBTRACT_OES = 0x800B;
#endif
    }
}
#endif