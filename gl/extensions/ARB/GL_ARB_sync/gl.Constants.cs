#if (GL_ARB_sync && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLuint64 GL_TIMEOUT_IGNORED = 0xFFFFFFFFFFFFFFFF;
        public const GLbitfield GL_SYNC_FLUSH_COMMANDS_BIT = 0x00000001;
        public const GLenum GL_MAX_SERVER_WAIT_TIMEOUT = 0x9111;
        public const GLenum GL_OBJECT_TYPE = 0x9112;
        public const GLenum GL_SYNC_CONDITION = 0x9113;
        public const GLenum GL_SYNC_STATUS = 0x9114;
        public const GLenum GL_SYNC_FLAGS = 0x9115;
        public const GLenum GL_SYNC_FENCE = 0x9116;
        public const GLenum GL_SYNC_GPU_COMMANDS_COMPLETE = 0x9117;
        public const GLenum GL_UNSIGNALED = 0x9118;
        public const GLenum GL_SIGNALED = 0x9119;
        public const GLenum GL_ALREADY_SIGNALED = 0x911A;
        public const GLenum GL_TIMEOUT_EXPIRED = 0x911B;
        public const GLenum GL_CONDITION_SATISFIED = 0x911C;
        public const GLenum GL_WAIT_FAILED = 0x911D;
    }
}
#endif