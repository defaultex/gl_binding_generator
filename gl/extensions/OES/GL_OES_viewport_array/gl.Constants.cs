#if (GL_OES_viewport_array && GLES2_API)
public partial class glext_oes { 
    public partial class Constants { 
        public const GLenum GL_DEPTH_RANGE = 0x0B70;
        public const GLenum GL_VIEWPORT = 0x0BA2;
        public const GLenum GL_SCISSOR_BOX = 0x0C10;
        public const GLenum GL_SCISSOR_TEST = 0x0C11;
        public const GLenum GL_MAX_VIEWPORTS_OES = 0x825B;
        public const GLenum GL_VIEWPORT_SUBPIXEL_BITS_OES = 0x825C;
        public const GLenum GL_VIEWPORT_BOUNDS_RANGE_OES = 0x825D;
        public const GLenum GL_VIEWPORT_INDEX_PROVOKING_VERTEX_OES = 0x825F;
    }
}
#endif