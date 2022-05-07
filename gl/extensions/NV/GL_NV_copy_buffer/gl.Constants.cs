#if (GL_NV_copy_buffer && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_COPY_READ_BUFFER_NV = 0x8F36;
        public const GLenum GL_COPY_WRITE_BUFFER_NV = 0x8F37;
    }
}
#endif