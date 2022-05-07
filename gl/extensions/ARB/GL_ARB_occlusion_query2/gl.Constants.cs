#if (GL_ARB_occlusion_query2 && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_ANY_SAMPLES_PASSED = 0x8C2F;
    }
}
#endif