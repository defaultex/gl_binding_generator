#if (GL_EXT_direct_state_access && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_PROGRAM_MATRIX_EXT = 0x8E2D;
        public const GLenum GL_TRANSPOSE_PROGRAM_MATRIX_EXT = 0x8E2E;
        public const GLenum GL_PROGRAM_MATRIX_STACK_DEPTH_EXT = 0x8E2F;
    }
}
#endif