#if (GL_ARB_gpu_shader_int64 && (GL_API || GLCORE_API))
public partial class glext_arb { 
    public partial class Constants { 
        public const GLenum GL_INT64_ARB = 0x140E;
        public const GLenum GL_UNSIGNED_INT64_ARB = 0x140F;
        public const GLenum GL_INT64_VEC2_ARB = 0x8FE9;
        public const GLenum GL_INT64_VEC3_ARB = 0x8FEA;
        public const GLenum GL_INT64_VEC4_ARB = 0x8FEB;
        public const GLenum GL_UNSIGNED_INT64_VEC2_ARB = 0x8FF5;
        public const GLenum GL_UNSIGNED_INT64_VEC3_ARB = 0x8FF6;
        public const GLenum GL_UNSIGNED_INT64_VEC4_ARB = 0x8FF7;
    }
}
#endif