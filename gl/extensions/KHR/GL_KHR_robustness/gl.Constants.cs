#if (GL_KHR_robustness && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_NO_ERROR = 0;
        public const GLenum GL_CONTEXT_LOST = 0x0507;
        public const GLenum GL_CONTEXT_LOST_KHR = 0x0507;
        public const GLenum GL_LOSE_CONTEXT_ON_RESET = 0x8252;
        public const GLenum GL_LOSE_CONTEXT_ON_RESET_KHR = 0x8252;
        public const GLenum GL_GUILTY_CONTEXT_RESET = 0x8253;
        public const GLenum GL_GUILTY_CONTEXT_RESET_KHR = 0x8253;
        public const GLenum GL_INNOCENT_CONTEXT_RESET = 0x8254;
        public const GLenum GL_INNOCENT_CONTEXT_RESET_KHR = 0x8254;
        public const GLenum GL_UNKNOWN_CONTEXT_RESET = 0x8255;
        public const GLenum GL_UNKNOWN_CONTEXT_RESET_KHR = 0x8255;
        public const GLenum GL_RESET_NOTIFICATION_STRATEGY = 0x8256;
        public const GLenum GL_RESET_NOTIFICATION_STRATEGY_KHR = 0x8256;
        public const GLenum GL_NO_RESET_NOTIFICATION = 0x8261;
        public const GLenum GL_NO_RESET_NOTIFICATION_KHR = 0x8261;
        public const GLenum GL_CONTEXT_ROBUST_ACCESS = 0x90F3;
        public const GLenum GL_CONTEXT_ROBUST_ACCESS_KHR = 0x90F3;
    }
}
#endif