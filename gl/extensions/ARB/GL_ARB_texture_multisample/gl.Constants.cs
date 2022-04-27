#if (GL_ARB_texture_multisample && (GL_API || GLCORE_API))
public partial class glext_arb { 
    public partial class Constants { 
        public const GLenum GL_SAMPLE_POSITION = 0x8E50;
        public const GLenum GL_SAMPLE_MASK = 0x8E51;
        public const GLenum GL_SAMPLE_MASK_VALUE = 0x8E52;
        public const GLenum GL_MAX_SAMPLE_MASK_WORDS = 0x8E59;
        public const GLenum GL_TEXTURE_2D_MULTISAMPLE = 0x9100;
        public const GLenum GL_PROXY_TEXTURE_2D_MULTISAMPLE = 0x9101;
        public const GLenum GL_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102;
        public const GLenum GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9103;
        public const GLenum GL_TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104;
        public const GLenum GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105;
        public const GLenum GL_TEXTURE_SAMPLES = 0x9106;
        public const GLenum GL_TEXTURE_FIXED_SAMPLE_LOCATIONS = 0x9107;
        public const GLenum GL_SAMPLER_2D_MULTISAMPLE = 0x9108;
        public const GLenum GL_INT_SAMPLER_2D_MULTISAMPLE = 0x9109;
        public const GLenum GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A;
        public const GLenum GL_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910B;
        public const GLenum GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C;
        public const GLenum GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D;
        public const GLenum GL_MAX_COLOR_TEXTURE_SAMPLES = 0x910E;
        public const GLenum GL_MAX_DEPTH_TEXTURE_SAMPLES = 0x910F;
        public const GLenum GL_MAX_INTEGER_SAMPLES = 0x9110;
    }
}
#endif