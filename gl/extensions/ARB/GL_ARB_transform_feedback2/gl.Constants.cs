#if (GL_ARB_transform_feedback2 && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TRANSFORM_FEEDBACK = 0x8E22;
        public const GLenum GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED = 0x8E23;
        public const GLenum GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE = 0x8E24;
        public const GLenum GL_TRANSFORM_FEEDBACK_BINDING = 0x8E25;
    }
}
#endif