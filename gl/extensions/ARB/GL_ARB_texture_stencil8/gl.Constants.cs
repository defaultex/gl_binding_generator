#if (GL_ARB_texture_stencil8 && (GL_API || GLCORE_API))
public partial class glext_arb { 
    public partial class Constants { 
        public const GLenum GL_STENCIL_INDEX = 0x1901;
        public const GLenum GL_STENCIL_INDEX8 = 0x8D48;
    }
}
#endif