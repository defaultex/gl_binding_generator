#if (GL_ARB_occlusion_query && GL_API)
public partial class glext_arb { 
    public partial class Constants { 
        public const GLenum GL_QUERY_COUNTER_BITS_ARB = 0x8864;
        public const GLenum GL_CURRENT_QUERY_ARB = 0x8865;
        public const GLenum GL_QUERY_RESULT_ARB = 0x8866;
        public const GLenum GL_QUERY_RESULT_AVAILABLE_ARB = 0x8867;
        public const GLenum GL_SAMPLES_PASSED_ARB = 0x8914;
    }
}
#endif