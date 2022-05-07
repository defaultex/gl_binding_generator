#if (GL_NV_shader_thread_group && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_WARP_SIZE_NV = 0x9339;
        public const GLenum GL_WARPS_PER_SM_NV = 0x933A;
        public const GLenum GL_SM_COUNT_NV = 0x933B;
    }
}
#endif