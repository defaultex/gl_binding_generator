#if (GL_OES_get_program_binary && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_PROGRAM_BINARY_LENGTH_OES = 0x8741;
        public const GLenum GL_NUM_PROGRAM_BINARY_FORMATS_OES = 0x87FE;
        public const GLenum GL_PROGRAM_BINARY_FORMATS_OES = 0x87FF;
    }
}
#endif