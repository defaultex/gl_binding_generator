#if (GL_OES_blend_subtract && GLES1_API)
public partial class glext_oes { 
    public partial class Constants { 
        public const GLenum GL_FUNC_ADD_OES = 0x8006;
        public const GLenum GL_BLEND_EQUATION_OES = 0x8009;
        public const GLenum GL_FUNC_SUBTRACT_OES = 0x800A;
        public const GLenum GL_FUNC_REVERSE_SUBTRACT_OES = 0x800B;
    }
}
#endif