#if (GL_ARB_transform_feedback_overflow_query && (GL_API || GLCORE_API))
public partial class glext_arb { 
    public partial class Constants { 
        public const GLenum GL_TRANSFORM_FEEDBACK_OVERFLOW_ARB = 0x82EC;
        public const GLenum GL_TRANSFORM_FEEDBACK_STREAM_OVERFLOW_ARB = 0x82ED;
    }
}
#endif