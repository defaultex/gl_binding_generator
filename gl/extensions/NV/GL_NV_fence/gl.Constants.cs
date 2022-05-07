#if (GL_NV_fence && (!gl || !gles1 || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_ALL_COMPLETED_NV = 0x84F2;
        public const GLenum GL_FENCE_STATUS_NV = 0x84F3;
        public const GLenum GL_FENCE_CONDITION_NV = 0x84F4;
    }
}
#endif