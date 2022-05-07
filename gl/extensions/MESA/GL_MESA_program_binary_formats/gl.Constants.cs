#if (GL_MESA_program_binary_formats && (!gl || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_PROGRAM_BINARY_FORMAT_MESA = 0x875F;
    }
}
#endif