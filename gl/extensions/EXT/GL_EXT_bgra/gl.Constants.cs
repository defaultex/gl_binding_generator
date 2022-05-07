#if (GL_EXT_bgra && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_BGR_EXT = 0x80E0;
        public const GLenum GL_BGRA_EXT = 0x80E1;
    }
}
#endif