#if (GL_ARB_get_program_binary && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257;
        public const GLenum GL_PROGRAM_BINARY_LENGTH = 0x8741;
        public const GLenum GL_NUM_PROGRAM_BINARY_FORMATS = 0x87FE;
        public const GLenum GL_PROGRAM_BINARY_FORMATS = 0x87FF;
    }
}
#endif