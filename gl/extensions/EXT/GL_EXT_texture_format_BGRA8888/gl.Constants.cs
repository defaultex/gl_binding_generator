#if (GL_EXT_texture_format_BGRA8888 && (!gles1 || !gles2))
public partial class gles1 { 
    public partial class Constants { 
        public const GLenum GL_BGRA_EXT = 0x80E1;
    }
}
#endif