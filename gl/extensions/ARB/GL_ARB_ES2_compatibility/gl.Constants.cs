#if (GL_ARB_ES2_compatibility && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_FIXED = 0x140C;
        public const GLenum GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A;
        public const GLenum GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;
        public const GLenum GL_RGB565 = 0x8D62;
        public const GLenum GL_LOW_FLOAT = 0x8DF0;
        public const GLenum GL_MEDIUM_FLOAT = 0x8DF1;
        public const GLenum GL_HIGH_FLOAT = 0x8DF2;
        public const GLenum GL_LOW_INT = 0x8DF3;
        public const GLenum GL_MEDIUM_INT = 0x8DF4;
        public const GLenum GL_HIGH_INT = 0x8DF5;
        public const GLenum GL_SHADER_BINARY_FORMATS = 0x8DF8;
        public const GLenum GL_NUM_SHADER_BINARY_FORMATS = 0x8DF9;
        public const GLenum GL_SHADER_COMPILER = 0x8DFA;
        public const GLenum GL_MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;
        public const GLenum GL_MAX_VARYING_VECTORS = 0x8DFC;
        public const GLenum GL_MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;
    }
}
#endif