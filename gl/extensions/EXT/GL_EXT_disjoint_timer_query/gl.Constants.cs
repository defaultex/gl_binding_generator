#if (GL_EXT_disjoint_timer_query && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_QUERY_COUNTER_BITS_EXT = 0x8864;
        public const GLenum GL_CURRENT_QUERY_EXT = 0x8865;
        public const GLenum GL_QUERY_RESULT_EXT = 0x8866;
        public const GLenum GL_QUERY_RESULT_AVAILABLE_EXT = 0x8867;
        public const GLenum GL_TIME_ELAPSED_EXT = 0x88BF;
        public const GLenum GL_TIMESTAMP_EXT = 0x8E28;
        public const GLenum GL_GPU_DISJOINT_EXT = 0x8FBB;
    }
}
#endif