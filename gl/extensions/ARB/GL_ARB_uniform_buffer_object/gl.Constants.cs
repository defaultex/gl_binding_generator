#if (GL_ARB_uniform_buffer_object && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_UNIFORM_BUFFER = 0x8A11;
        public const GLenum GL_UNIFORM_BUFFER_BINDING = 0x8A28;
        public const GLenum GL_UNIFORM_BUFFER_START = 0x8A29;
        public const GLenum GL_UNIFORM_BUFFER_SIZE = 0x8A2A;
        public const GLenum GL_MAX_VERTEX_UNIFORM_BLOCKS = 0x8A2B;
        public const GLenum GL_MAX_GEOMETRY_UNIFORM_BLOCKS = 0x8A2C;
        public const GLenum GL_MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D;
        public const GLenum GL_MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E;
        public const GLenum GL_MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F;
        public const GLenum GL_MAX_UNIFORM_BLOCK_SIZE = 0x8A30;
        public const GLenum GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31;
        public const GLenum GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS = 0x8A32;
        public const GLenum GL_MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33;
        public const GLenum GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x8A34;
        public const GLenum GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35;
        public const GLenum GL_ACTIVE_UNIFORM_BLOCKS = 0x8A36;
        public const GLenum GL_UNIFORM_TYPE = 0x8A37;
        public const GLenum GL_UNIFORM_SIZE = 0x8A38;
        public const GLenum GL_UNIFORM_NAME_LENGTH = 0x8A39;
        public const GLenum GL_UNIFORM_BLOCK_INDEX = 0x8A3A;
        public const GLenum GL_UNIFORM_OFFSET = 0x8A3B;
        public const GLenum GL_UNIFORM_ARRAY_STRIDE = 0x8A3C;
        public const GLenum GL_UNIFORM_MATRIX_STRIDE = 0x8A3D;
        public const GLenum GL_UNIFORM_IS_ROW_MAJOR = 0x8A3E;
        public const GLenum GL_UNIFORM_BLOCK_BINDING = 0x8A3F;
        public const GLenum GL_UNIFORM_BLOCK_DATA_SIZE = 0x8A40;
        public const GLenum GL_UNIFORM_BLOCK_NAME_LENGTH = 0x8A41;
        public const GLenum GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42;
        public const GLenum GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43;
        public const GLenum GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44;
        public const GLenum GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER = 0x8A45;
        public const GLenum GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46;
        public const GLenum GL_INVALID_INDEX = 0xFFFFFFFF;
    }
}
#endif