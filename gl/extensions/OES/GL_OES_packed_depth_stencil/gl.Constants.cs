#if (GL_OES_packed_depth_stencil && (!gles1 || !gles2))
public partial class gles1 { 
    public partial class Constants { 
        public const GLenum GL_DEPTH_STENCIL_OES = 0x84F9;
        public const GLenum GL_UNSIGNED_INT_24_8_OES = 0x84FA;
        public const GLenum GL_DEPTH24_STENCIL8_OES = 0x88F0;
    }
}
#endif