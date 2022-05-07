#if (GL_EXT_draw_buffers_indexed && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_ZERO = 0;
        public const GLenum GL_ONE = 1;
        public const GLenum GL_SRC_COLOR = 0x0300;
        public const GLenum GL_ONE_MINUS_SRC_COLOR = 0x0301;
        public const GLenum GL_SRC_ALPHA = 0x0302;
        public const GLenum GL_ONE_MINUS_SRC_ALPHA = 0x0303;
        public const GLenum GL_DST_ALPHA = 0x0304;
        public const GLenum GL_ONE_MINUS_DST_ALPHA = 0x0305;
        public const GLenum GL_DST_COLOR = 0x0306;
        public const GLenum GL_ONE_MINUS_DST_COLOR = 0x0307;
        public const GLenum GL_SRC_ALPHA_SATURATE = 0x0308;
        public const GLenum GL_BLEND = 0x0BE2;
        public const GLenum GL_COLOR_WRITEMASK = 0x0C23;
        public const GLenum GL_CONSTANT_COLOR = 0x8001;
        public const GLenum GL_ONE_MINUS_CONSTANT_COLOR = 0x8002;
        public const GLenum GL_CONSTANT_ALPHA = 0x8003;
        public const GLenum GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004;
        public const GLenum GL_FUNC_ADD = 0x8006;
        public const GLenum GL_MIN = 0x8007;
        public const GLenum GL_MAX = 0x8008;
        public const GLenum GL_BLEND_EQUATION_RGB = 0x8009;
        public const GLenum GL_FUNC_SUBTRACT = 0x800A;
        public const GLenum GL_FUNC_REVERSE_SUBTRACT = 0x800B;
        public const GLenum GL_BLEND_DST_RGB = 0x80C8;
        public const GLenum GL_BLEND_SRC_RGB = 0x80C9;
        public const GLenum GL_BLEND_DST_ALPHA = 0x80CA;
        public const GLenum GL_BLEND_SRC_ALPHA = 0x80CB;
        public const GLenum GL_BLEND_EQUATION_ALPHA = 0x883D;
    }
}
#endif