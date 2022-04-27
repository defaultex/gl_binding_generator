#if (GL_ARB_color_buffer_float && GL_API)
public partial class glext_arb { 
    public partial class Constants { 
        public const GLenum GL_RGBA_FLOAT_MODE_ARB = 0x8820;
        public const GLenum GL_CLAMP_VERTEX_COLOR_ARB = 0x891A;
        public const GLenum GL_CLAMP_FRAGMENT_COLOR_ARB = 0x891B;
        public const GLenum GL_CLAMP_READ_COLOR_ARB = 0x891C;
        public const GLenum GL_FIXED_ONLY_ARB = 0x891D;
    }
}
#endif