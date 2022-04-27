#if (GL_EXT_render_snorm && GLES2_API)
public partial class glext_ext { 
    public partial class Constants { 
        public const GLenum GL_BYTE = 0x1400;
        public const GLenum GL_SHORT = 0x1402;
        public const GLenum GL_R8_SNORM = 0x8F94;
        public const GLenum GL_RG8_SNORM = 0x8F95;
        public const GLenum GL_RGBA8_SNORM = 0x8F97;
        public const GLenum GL_R16_SNORM_EXT = 0x8F98;
        public const GLenum GL_RG16_SNORM_EXT = 0x8F99;
        public const GLenum GL_RGBA16_SNORM_EXT = 0x8F9B;
    }
}
#endif