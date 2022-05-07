#if (GL_AMD_gpu_shader_half_float && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_FLOAT16_NV = 0x8FF8;
        public const GLenum GL_FLOAT16_VEC2_NV = 0x8FF9;
        public const GLenum GL_FLOAT16_VEC3_NV = 0x8FFA;
        public const GLenum GL_FLOAT16_VEC4_NV = 0x8FFB;
        public const GLenum GL_FLOAT16_MAT2_AMD = 0x91C5;
        public const GLenum GL_FLOAT16_MAT3_AMD = 0x91C6;
        public const GLenum GL_FLOAT16_MAT4_AMD = 0x91C7;
        public const GLenum GL_FLOAT16_MAT2x3_AMD = 0x91C8;
        public const GLenum GL_FLOAT16_MAT2x4_AMD = 0x91C9;
        public const GLenum GL_FLOAT16_MAT3x2_AMD = 0x91CA;
        public const GLenum GL_FLOAT16_MAT3x4_AMD = 0x91CB;
        public const GLenum GL_FLOAT16_MAT4x2_AMD = 0x91CC;
        public const GLenum GL_FLOAT16_MAT4x3_AMD = 0x91CD;
    }
}
#endif