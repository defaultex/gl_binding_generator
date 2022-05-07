#if (GL_EXT_discard_framebuffer && (!gles1 || !gles2))
public partial class gles1 { 
    public partial class Constants { 
        public const GLenum GL_COLOR_EXT = 0x1800;
        public const GLenum GL_DEPTH_EXT = 0x1801;
        public const GLenum GL_STENCIL_EXT = 0x1802;
    }
}
#endif