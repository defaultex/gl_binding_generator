#if (GL_ARB_texture_float && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_RGBA32F_ARB = 0x8814;
        public const GLenum GL_RGB32F_ARB = 0x8815;
        public const GLenum GL_ALPHA32F_ARB = 0x8816;
        public const GLenum GL_INTENSITY32F_ARB = 0x8817;
        public const GLenum GL_LUMINANCE32F_ARB = 0x8818;
        public const GLenum GL_LUMINANCE_ALPHA32F_ARB = 0x8819;
        public const GLenum GL_RGBA16F_ARB = 0x881A;
        public const GLenum GL_RGB16F_ARB = 0x881B;
        public const GLenum GL_ALPHA16F_ARB = 0x881C;
        public const GLenum GL_INTENSITY16F_ARB = 0x881D;
        public const GLenum GL_LUMINANCE16F_ARB = 0x881E;
        public const GLenum GL_LUMINANCE_ALPHA16F_ARB = 0x881F;
        public const GLenum GL_TEXTURE_RED_TYPE_ARB = 0x8C10;
        public const GLenum GL_TEXTURE_GREEN_TYPE_ARB = 0x8C11;
        public const GLenum GL_TEXTURE_BLUE_TYPE_ARB = 0x8C12;
        public const GLenum GL_TEXTURE_ALPHA_TYPE_ARB = 0x8C13;
        public const GLenum GL_TEXTURE_LUMINANCE_TYPE_ARB = 0x8C14;
        public const GLenum GL_TEXTURE_INTENSITY_TYPE_ARB = 0x8C15;
        public const GLenum GL_TEXTURE_DEPTH_TYPE_ARB = 0x8C16;
        public const GLenum GL_UNSIGNED_NORMALIZED_ARB = 0x8C17;
    }
}
#endif