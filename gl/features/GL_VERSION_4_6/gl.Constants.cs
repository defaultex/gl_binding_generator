#if (GL_VERSION_4_6 && GL_API)
public partial class gl { 
    public partial class Constants { 
        public const GLbitfield GL_CONTEXT_FLAG_NO_ERROR_BIT = 0x00000008;
        public const GLenum GL_PARAMETER_BUFFER = 0x80EE;
        public const GLenum GL_PARAMETER_BUFFER_BINDING = 0x80EF;
        public const GLenum GL_TRANSFORM_FEEDBACK_OVERFLOW = 0x82EC;
        public const GLenum GL_TRANSFORM_FEEDBACK_STREAM_OVERFLOW = 0x82ED;
        public const GLenum GL_VERTICES_SUBMITTED = 0x82EE;
        public const GLenum GL_PRIMITIVES_SUBMITTED = 0x82EF;
        public const GLenum GL_VERTEX_SHADER_INVOCATIONS = 0x82F0;
        public const GLenum GL_TESS_CONTROL_SHADER_PATCHES = 0x82F1;
        public const GLenum GL_TESS_EVALUATION_SHADER_INVOCATIONS = 0x82F2;
        public const GLenum GL_GEOMETRY_SHADER_PRIMITIVES_EMITTED = 0x82F3;
        public const GLenum GL_FRAGMENT_SHADER_INVOCATIONS = 0x82F4;
        public const GLenum GL_COMPUTE_SHADER_INVOCATIONS = 0x82F5;
        public const GLenum GL_CLIPPING_INPUT_PRIMITIVES = 0x82F6;
        public const GLenum GL_CLIPPING_OUTPUT_PRIMITIVES = 0x82F7;
        public const GLenum GL_TEXTURE_MAX_ANISOTROPY = 0x84FE;
        public const GLenum GL_MAX_TEXTURE_MAX_ANISOTROPY = 0x84FF;
        public const GLenum GL_POLYGON_OFFSET_CLAMP = 0x8E1B;
        public const GLenum GL_SHADER_BINARY_FORMAT_SPIR_V = 0x9551;
        public const GLenum GL_SPIR_V_BINARY = 0x9552;
        public const GLenum GL_SPIR_V_EXTENSIONS = 0x9553;
        public const GLenum GL_NUM_SPIR_V_EXTENSIONS = 0x9554;
    }
}
#endif