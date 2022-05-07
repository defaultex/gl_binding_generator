#if (GL_NV_transform_feedback2 && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TRANSFORM_FEEDBACK_NV = 0x8E22;
        public const GLenum GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED_NV = 0x8E23;
        public const GLenum GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE_NV = 0x8E24;
        public const GLenum GL_TRANSFORM_FEEDBACK_BINDING_NV = 0x8E25;
    }
}
#endif