#if (GL_ATI_texture_float && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_RGBA_FLOAT32_ATI = 0x8814;
        public const GLenum GL_RGB_FLOAT32_ATI = 0x8815;
        public const GLenum GL_ALPHA_FLOAT32_ATI = 0x8816;
        public const GLenum GL_INTENSITY_FLOAT32_ATI = 0x8817;
        public const GLenum GL_LUMINANCE_FLOAT32_ATI = 0x8818;
        public const GLenum GL_LUMINANCE_ALPHA_FLOAT32_ATI = 0x8819;
        public const GLenum GL_RGBA_FLOAT16_ATI = 0x881A;
        public const GLenum GL_RGB_FLOAT16_ATI = 0x881B;
        public const GLenum GL_ALPHA_FLOAT16_ATI = 0x881C;
        public const GLenum GL_INTENSITY_FLOAT16_ATI = 0x881D;
        public const GLenum GL_LUMINANCE_FLOAT16_ATI = 0x881E;
        public const GLenum GL_LUMINANCE_ALPHA_FLOAT16_ATI = 0x881F;
    }
}
#endif