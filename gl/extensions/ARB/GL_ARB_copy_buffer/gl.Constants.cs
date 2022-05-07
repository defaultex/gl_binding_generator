#if (GL_ARB_copy_buffer && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_COPY_READ_BUFFER = 0x8F36;
        public const GLenum GL_COPY_WRITE_BUFFER = 0x8F37;
    }
}
#endif