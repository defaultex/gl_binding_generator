#if (GL_ARB_viewport_array && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_DEPTH_RANGE = 0x0B70;
        public const GLenum GL_VIEWPORT = 0x0BA2;
        public const GLenum GL_SCISSOR_BOX = 0x0C10;
        public const GLenum GL_SCISSOR_TEST = 0x0C11;
        public const GLenum GL_MAX_VIEWPORTS = 0x825B;
        public const GLbitfield GL_VIEWPORT_SUBPIXEL_BITS = 0x825C;
        public const GLenum GL_VIEWPORT_BOUNDS_RANGE = 0x825D;
        public const GLenum GL_LAYER_PROVOKING_VERTEX = 0x825E;
        public const GLenum GL_VIEWPORT_INDEX_PROVOKING_VERTEX = 0x825F;
        public const GLenum GL_UNDEFINED_VERTEX = 0x8260;
        public const GLenum GL_FIRST_VERTEX_CONVENTION = 0x8E4D;
        public const GLenum GL_LAST_VERTEX_CONVENTION = 0x8E4E;
        public const GLenum GL_PROVOKING_VERTEX = 0x8E4F;
    }
}
#endif