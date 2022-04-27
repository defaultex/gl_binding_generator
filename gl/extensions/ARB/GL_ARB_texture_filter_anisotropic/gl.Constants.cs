#if (GL_ARB_texture_filter_anisotropic && (GL_API || GLCORE_API))
public partial class glext_arb { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_MAX_ANISOTROPY = 0x84FE;
        public const GLenum GL_MAX_TEXTURE_MAX_ANISOTROPY = 0x84FF;
    }
}
#endif