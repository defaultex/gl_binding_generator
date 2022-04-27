#if (GL_ARB_gpu_shader_fp64 && (GL_API || GLCORE_API))
public partial class glext_arb { 
    public partial class Constants { 
        public const GLenum GL_DOUBLE = 0x140A;
        public const GLenum GL_DOUBLE_MAT2 = 0x8F46;
        public const GLenum GL_DOUBLE_MAT3 = 0x8F47;
        public const GLenum GL_DOUBLE_MAT4 = 0x8F48;
        public const GLenum GL_DOUBLE_MAT2x3 = 0x8F49;
        public const GLenum GL_DOUBLE_MAT2x4 = 0x8F4A;
        public const GLenum GL_DOUBLE_MAT3x2 = 0x8F4B;
        public const GLenum GL_DOUBLE_MAT3x4 = 0x8F4C;
        public const GLenum GL_DOUBLE_MAT4x2 = 0x8F4D;
        public const GLenum GL_DOUBLE_MAT4x3 = 0x8F4E;
        public const GLenum GL_DOUBLE_VEC2 = 0x8FFC;
        public const GLenum GL_DOUBLE_VEC3 = 0x8FFD;
        public const GLenum GL_DOUBLE_VEC4 = 0x8FFE;
    }
}
#endif