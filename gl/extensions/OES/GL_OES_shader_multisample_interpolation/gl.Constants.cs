#if (GL_OES_shader_multisample_interpolation && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_MIN_FRAGMENT_INTERPOLATION_OFFSET_OES = 0x8E5B;
        public const GLenum GL_MAX_FRAGMENT_INTERPOLATION_OFFSET_OES = 0x8E5C;
        public const GLenum GL_FRAGMENT_INTERPOLATION_OFFSET_BITS_OES = 0x8E5D;
    }
}
#endif