#if (GL_ARB_texture_filter_anisotropic && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_MAX_ANISOTROPY = 0x84FE;
        public const GLenum GL_MAX_TEXTURE_MAX_ANISOTROPY = 0x84FF;
    }
}
#endif