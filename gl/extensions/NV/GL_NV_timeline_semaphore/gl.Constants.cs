#if (GL_NV_timeline_semaphore && (!gl || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TIMELINE_SEMAPHORE_VALUE_NV = 0x9595;
        public const GLenum GL_SEMAPHORE_TYPE_NV = 0x95B3;
        public const GLenum GL_SEMAPHORE_TYPE_BINARY_NV = 0x95B4;
        public const GLenum GL_SEMAPHORE_TYPE_TIMELINE_NV = 0x95B5;
        public const GLenum GL_MAX_TIMELINE_SEMAPHORE_VALUE_DIFFERENCE_NV = 0x95B6;
    }
}
#endif