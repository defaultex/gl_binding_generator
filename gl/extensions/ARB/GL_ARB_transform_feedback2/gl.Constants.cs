#if (GL_ARB_transform_feedback2 && (GL_API || GLCORE_API))
public partial class glext_arb { 
    public partial class Constants { 
        public const GLenum GL_TRANSFORM_FEEDBACK = 0x8E22;
        public const GLenum GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED = 0x8E23;
        public const GLenum GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE = 0x8E24;
        public const GLenum GL_TRANSFORM_FEEDBACK_BINDING = 0x8E25;
    }
}
#endif