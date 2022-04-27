#if (GL_EXT_multiview_draw_buffers && GLES2_API)
public partial class glext_ext { 
    public partial class Constants { 
        public const GLenum GL_DRAW_BUFFER_EXT = 0x0C01;
        public const GLenum GL_READ_BUFFER_EXT = 0x0C02;
        public const GLenum GL_COLOR_ATTACHMENT_EXT = 0x90F0;
        public const GLenum GL_MULTIVIEW_EXT = 0x90F1;
        public const GLenum GL_MAX_MULTIVIEW_BUFFERS_EXT = 0x90F2;
    }
}
#endif