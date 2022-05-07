#if (GL_AMD_framebuffer_sample_positions && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_SUBSAMPLE_DISTANCE_AMD = 0x883F;
        public const GLenum GL_PIXELS_PER_SAMPLE_PATTERN_X_AMD = 0x91AE;
        public const GLenum GL_PIXELS_PER_SAMPLE_PATTERN_Y_AMD = 0x91AF;
        public const GLenum GL_ALL_PIXELS_AMD = 0xFFFFFFFF;
    }
}
#endif