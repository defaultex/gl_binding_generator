#if (GL_AMD_depth_clamp_separate && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_DEPTH_CLAMP_NEAR_AMD = 0x901E;
        public const GLenum GL_DEPTH_CLAMP_FAR_AMD = 0x901F;
    }
}
#endif