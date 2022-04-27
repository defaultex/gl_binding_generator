#if (GL_ARB_shader_storage_buffer_object && (GL_API || GLCORE_API))
public partial class glext_arb { 
    public partial class Constants { 
        public const GLbitfield GL_SHADER_STORAGE_BARRIER_BIT = 0x00002000;
        public const GLenum GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS = 0x8F39;
        public const GLenum GL_MAX_COMBINED_SHADER_OUTPUT_RESOURCES = 0x8F39;
        public const GLenum GL_SHADER_STORAGE_BUFFER = 0x90D2;
        public const GLenum GL_SHADER_STORAGE_BUFFER_BINDING = 0x90D3;
        public const GLenum GL_SHADER_STORAGE_BUFFER_START = 0x90D4;
        public const GLenum GL_SHADER_STORAGE_BUFFER_SIZE = 0x90D5;
        public const GLenum GL_MAX_VERTEX_SHADER_STORAGE_BLOCKS = 0x90D6;
        public const GLenum GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS = 0x90D7;
        public const GLenum GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS = 0x90D8;
        public const GLenum GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS = 0x90D9;
        public const GLenum GL_MAX_FRAGMENT_SHADER_STORAGE_BLOCKS = 0x90DA;
        public const GLenum GL_MAX_COMPUTE_SHADER_STORAGE_BLOCKS = 0x90DB;
        public const GLenum GL_MAX_COMBINED_SHADER_STORAGE_BLOCKS = 0x90DC;
        public const GLenum GL_MAX_SHADER_STORAGE_BUFFER_BINDINGS = 0x90DD;
        public const GLenum GL_MAX_SHADER_STORAGE_BLOCK_SIZE = 0x90DE;
        public const GLenum GL_SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT = 0x90DF;
    }
}
#endif