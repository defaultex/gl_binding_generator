#if (GL_EXT_stencil_wrap && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_INCR_WRAP_EXT = 0x8507;
        public const GLenum GL_DECR_WRAP_EXT = 0x8508;
    }
}
#endif