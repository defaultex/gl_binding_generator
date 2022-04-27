#if (GL_EXT_discard_framebuffer && (GLES1_API || GLES2_API))
public partial class glext_ext { 
    public partial class Constants { 
        public const GLenum GL_COLOR_EXT = 0x1800;
        public const GLenum GL_DEPTH_EXT = 0x1801;
        public const GLenum GL_STENCIL_EXT = 0x1802;
    }
}
#endif