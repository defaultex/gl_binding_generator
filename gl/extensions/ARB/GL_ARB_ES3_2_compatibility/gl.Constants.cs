#if (GL_ARB_ES3_2_compatibility && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_PRIMITIVE_BOUNDING_BOX_ARB = 0x92BE;
        public const GLenum GL_MULTISAMPLE_LINE_WIDTH_RANGE_ARB = 0x9381;
        public const GLenum GL_MULTISAMPLE_LINE_WIDTH_GRANULARITY_ARB = 0x9382;
    }
}
#endif