#if (GL_ARB_internalformat_query && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_NUM_SAMPLE_COUNTS = 0x9380;
    }
}
#endif