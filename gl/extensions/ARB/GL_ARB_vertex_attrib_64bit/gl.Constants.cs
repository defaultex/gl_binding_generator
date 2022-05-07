#if (GL_ARB_vertex_attrib_64bit && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_RGB32I = 0x8D83;
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