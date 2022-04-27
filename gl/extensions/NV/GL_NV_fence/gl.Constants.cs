#if (GL_NV_fence && (GL_API || GLES1_API || GLES2_API))
public partial class glext_nv { 
    public partial class Constants { 
        public const GLenum GL_ALL_COMPLETED_NV = 0x84F2;
        public const GLenum GL_FENCE_STATUS_NV = 0x84F3;
        public const GLenum GL_FENCE_CONDITION_NV = 0x84F4;
    }
}
#endif