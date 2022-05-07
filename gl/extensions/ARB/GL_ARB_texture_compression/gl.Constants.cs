#if (GL_ARB_texture_compression && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_COMPRESSED_ALPHA_ARB = 0x84E9;
        public const GLenum GL_COMPRESSED_LUMINANCE_ARB = 0x84EA;
        public const GLenum GL_COMPRESSED_LUMINANCE_ALPHA_ARB = 0x84EB;
        public const GLenum GL_COMPRESSED_INTENSITY_ARB = 0x84EC;
        public const GLenum GL_COMPRESSED_RGB_ARB = 0x84ED;
        public const GLenum GL_COMPRESSED_RGBA_ARB = 0x84EE;
        public const GLenum GL_TEXTURE_COMPRESSION_HINT_ARB = 0x84EF;
        public const GLenum GL_TEXTURE_COMPRESSED_IMAGE_SIZE_ARB = 0x86A0;
        public const GLenum GL_TEXTURE_COMPRESSED_ARB = 0x86A1;
        public const GLenum GL_NUM_COMPRESSED_TEXTURE_FORMATS_ARB = 0x86A2;
        public const GLenum GL_COMPRESSED_TEXTURE_FORMATS_ARB = 0x86A3;
    }
}
#endif