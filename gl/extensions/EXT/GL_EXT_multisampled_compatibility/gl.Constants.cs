#if (GL_EXT_multisampled_compatibility && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_MULTISAMPLE_EXT = 0x809D;
        public const GLenum GL_SAMPLE_ALPHA_TO_ONE_EXT = 0x809F;
    }
}
#endif