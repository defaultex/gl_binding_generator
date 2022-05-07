#if (GL_OES_read_format && (!gl || !gles1))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_IMPLEMENTATION_COLOR_READ_TYPE_OES = 0x8B9A;
        public const GLenum GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES = 0x8B9B;
    }
}
#endif