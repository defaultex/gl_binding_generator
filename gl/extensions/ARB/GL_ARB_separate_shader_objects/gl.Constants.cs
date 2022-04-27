#if (GL_ARB_separate_shader_objects && (GL_API || GLCORE_API))
public partial class glext_arb { 
    public partial class Constants { 
        public const GLbitfield GL_VERTEX_SHADER_BIT = 0x00000001;
        public const GLbitfield GL_FRAGMENT_SHADER_BIT = 0x00000002;
        public const GLbitfield GL_GEOMETRY_SHADER_BIT = 0x00000004;
        public const GLbitfield GL_TESS_CONTROL_SHADER_BIT = 0x00000008;
        public const GLbitfield GL_TESS_EVALUATION_SHADER_BIT = 0x00000010;
        public const GLbitfield GL_ALL_SHADER_BITS = 0xFFFFFFFF;
        public const GLenum GL_PROGRAM_SEPARABLE = 0x8258;
        public const GLenum GL_ACTIVE_PROGRAM = 0x8259;
        public const GLenum GL_PROGRAM_PIPELINE_BINDING = 0x825A;
    }
}
#endif