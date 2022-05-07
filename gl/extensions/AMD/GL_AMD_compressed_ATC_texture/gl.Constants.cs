#if (GL_AMD_compressed_ATC_texture && (!gles1 || !gles2))
public partial class gles1 { 
    public partial class Constants { 
        public const GLenum GL_ATC_RGBA_INTERPOLATED_ALPHA_AMD = 0x87EE;
        public const GLenum GL_ATC_RGB_AMD = 0x8C92;
        public const GLenum GL_ATC_RGBA_EXPLICIT_ALPHA_AMD = 0x8C93;
    }
}
#endif