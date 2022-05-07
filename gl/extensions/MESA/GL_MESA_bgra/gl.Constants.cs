#if (GL_MESA_bgra && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_BGR_EXT = 0x80E0;
        public const GLenum GL_BGRA_EXT = 0x80E1;
    }
}
#endif