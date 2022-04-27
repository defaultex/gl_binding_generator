#if (GL_ARB_gpu_shader5 && (GL_API || GLCORE_API))
public partial class glext_arb { 
    public partial class Constants { 
        public const GLenum GL_GEOMETRY_SHADER_INVOCATIONS = 0x887F;
        public const GLenum GL_MAX_GEOMETRY_SHADER_INVOCATIONS = 0x8E5A;
        public const GLenum GL_MIN_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5B;
        public const GLenum GL_MAX_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5C;
        public const GLbitfield GL_FRAGMENT_INTERPOLATION_OFFSET_BITS = 0x8E5D;
        public const GLenum GL_MAX_VERTEX_STREAMS = 0x8E71;
    }
}
#endif