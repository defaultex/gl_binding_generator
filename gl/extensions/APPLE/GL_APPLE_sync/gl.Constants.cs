#if (GL_APPLE_sync && (!gles1 || !gles2))
public partial class gles1 { 
    public partial class Constants { 
        public const GLenum GL_TIMEOUT_IGNORED_APPLE = 0xFFFFFFFFFFFFFFFF;
        public const GLenum GL_SYNC_FLUSH_COMMANDS_BIT_APPLE = 0x00000001;
        public const GLenum GL_SYNC_OBJECT_APPLE = 0x8A53;
        public const GLenum GL_MAX_SERVER_WAIT_TIMEOUT_APPLE = 0x9111;
        public const GLenum GL_OBJECT_TYPE_APPLE = 0x9112;
        public const GLenum GL_SYNC_CONDITION_APPLE = 0x9113;
        public const GLenum GL_SYNC_STATUS_APPLE = 0x9114;
        public const GLenum GL_SYNC_FLAGS_APPLE = 0x9115;
        public const GLenum GL_SYNC_FENCE_APPLE = 0x9116;
        public const GLenum GL_SYNC_GPU_COMMANDS_COMPLETE_APPLE = 0x9117;
        public const GLenum GL_UNSIGNALED_APPLE = 0x9118;
        public const GLenum GL_SIGNALED_APPLE = 0x9119;
        public const GLenum GL_ALREADY_SIGNALED_APPLE = 0x911A;
        public const GLenum GL_TIMEOUT_EXPIRED_APPLE = 0x911B;
        public const GLenum GL_CONDITION_SATISFIED_APPLE = 0x911C;
        public const GLenum GL_WAIT_FAILED_APPLE = 0x911D;
    }
}
#endif