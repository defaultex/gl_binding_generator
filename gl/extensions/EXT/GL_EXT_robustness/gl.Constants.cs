#if (GL_EXT_robustness && (!gles1 || !gles2))
public partial class gles1 { 
    public partial class Constants { 
        public const GLenum GL_NO_ERROR = 0;
        public const GLenum GL_LOSE_CONTEXT_ON_RESET_EXT = 0x8252;
        public const GLenum GL_GUILTY_CONTEXT_RESET_EXT = 0x8253;
        public const GLenum GL_INNOCENT_CONTEXT_RESET_EXT = 0x8254;
        public const GLenum GL_UNKNOWN_CONTEXT_RESET_EXT = 0x8255;
        public const GLenum GL_RESET_NOTIFICATION_STRATEGY_EXT = 0x8256;
        public const GLenum GL_NO_RESET_NOTIFICATION_EXT = 0x8261;
        public const GLenum GL_CONTEXT_ROBUST_ACCESS_EXT = 0x90F3;
    }
}
#endif