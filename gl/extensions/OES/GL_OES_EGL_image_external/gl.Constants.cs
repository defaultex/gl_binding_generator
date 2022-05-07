#if (GL_OES_EGL_image_external && (!gles1 || !gles2))
public partial class gles1 { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_EXTERNAL_OES = 0x8D65;
        public const GLenum GL_SAMPLER_EXTERNAL_OES = 0x8D66;
        public const GLenum GL_TEXTURE_BINDING_EXTERNAL_OES = 0x8D67;
        public const GLenum GL_REQUIRED_TEXTURE_IMAGE_UNITS_OES = 0x8D68;
    }
}
#endif