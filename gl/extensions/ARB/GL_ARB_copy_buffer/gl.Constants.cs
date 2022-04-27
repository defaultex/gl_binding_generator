#if (GL_ARB_copy_buffer && (GL_API || GLCORE_API))
public partial class glext_arb { 
    public partial class Constants { 
        public const GLenum GL_COPY_READ_BUFFER = 0x8F36;
        public const GLenum GL_COPY_WRITE_BUFFER = 0x8F37;
    }
}
#endif