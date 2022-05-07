#if (GL_EXT_texture_filter_anisotropic && (!gl || !gles1 || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FE;
        public const GLenum GL_MAX_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FF;
    }
}
#endif