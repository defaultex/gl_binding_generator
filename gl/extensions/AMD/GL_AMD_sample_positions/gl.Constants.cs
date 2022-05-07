#if (GL_AMD_sample_positions && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_SUBSAMPLE_DISTANCE_AMD = 0x883F;
    }
}
#endif