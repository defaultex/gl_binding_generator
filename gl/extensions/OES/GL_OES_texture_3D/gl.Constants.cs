#if (GL_OES_texture_3D && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_BINDING_3D_OES = 0x806A;
        public const GLenum GL_TEXTURE_3D_OES = 0x806F;
        public const GLenum GL_TEXTURE_WRAP_R_OES = 0x8072;
        public const GLenum GL_MAX_3D_TEXTURE_SIZE_OES = 0x8073;
        public const GLenum GL_SAMPLER_3D_OES = 0x8B5F;
        public const GLenum GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_OES = 0x8CD4;
    }
}
#endif