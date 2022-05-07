#if (GL_NV_gpu_program5 && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_MAX_GEOMETRY_PROGRAM_INVOCATIONS_NV = 0x8E5A;
        public const GLenum GL_MIN_FRAGMENT_INTERPOLATION_OFFSET_NV = 0x8E5B;
        public const GLenum GL_MAX_FRAGMENT_INTERPOLATION_OFFSET_NV = 0x8E5C;
        public const GLenum GL_FRAGMENT_PROGRAM_INTERPOLATION_OFFSET_BITS_NV = 0x8E5D;
        public const GLenum GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET_NV = 0x8E5E;
        public const GLenum GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET_NV = 0x8E5F;
        public const GLenum GL_MAX_PROGRAM_SUBROUTINE_PARAMETERS_NV = 0x8F44;
        public const GLenum GL_MAX_PROGRAM_SUBROUTINE_NUM_NV = 0x8F45;
    }
}
#endif