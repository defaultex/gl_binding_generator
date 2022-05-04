#if (GL_VERSION_3_1 && GL_API)
public partial class gl { 
    public partial class Constants { 

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_RECTANGLE = 0x84F5;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_BINDING_RECTANGLE = 0x84F6;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PROXY_TEXTURE_RECTANGLE = 0x84F7;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_RECTANGLE_TEXTURE_SIZE = 0x84F8;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_BUFFER = 0x8A11;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_BUFFER_BINDING = 0x8A28;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_BUFFER_START = 0x8A29;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_BUFFER_SIZE = 0x8A2A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_VERTEX_UNIFORM_BLOCKS = 0x8A2B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_GEOMETRY_UNIFORM_BLOCKS = 0x8A2C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_UNIFORM_BLOCK_SIZE = 0x8A30;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS = 0x8A32;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x8A34;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_ACTIVE_UNIFORM_BLOCKS = 0x8A36;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_TYPE = 0x8A37;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_SIZE = 0x8A38;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_NAME_LENGTH = 0x8A39;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_BLOCK_INDEX = 0x8A3A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_OFFSET = 0x8A3B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_ARRAY_STRIDE = 0x8A3C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_MATRIX_STRIDE = 0x8A3D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_IS_ROW_MAJOR = 0x8A3E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_BLOCK_BINDING = 0x8A3F;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_BLOCK_DATA_SIZE = 0x8A40;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_BLOCK_NAME_LENGTH = 0x8A41;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER = 0x8A45;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SAMPLER_2D_RECT = 0x8B63;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SAMPLER_2D_RECT_SHADOW = 0x8B64;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_BUFFER = 0x8C2A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TEXTURE_BUFFER_SIZE = 0x8C2B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_BINDING_BUFFER = 0x8C2C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_BUFFER_DATA_STORE_BINDING = 0x8C2D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SAMPLER_BUFFER = 0x8DC2;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_INT_SAMPLER_2D_RECT = 0x8DCD;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_INT_SAMPLER_BUFFER = 0x8DD0;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_SAMPLER_2D_RECT = 0x8DD5;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_SAMPLER_BUFFER = 0x8DD8;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COPY_READ_BUFFER = 0x8F36;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_COPY_WRITE_BUFFER = 0x8F37;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_R8_SNORM = 0x8F94;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RG8_SNORM = 0x8F95;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGB8_SNORM = 0x8F96;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGBA8_SNORM = 0x8F97;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_R16_SNORM = 0x8F98;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RG16_SNORM = 0x8F99;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGB16_SNORM = 0x8F9A;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_RGBA16_SNORM = 0x8F9B;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_SIGNED_NORMALIZED = 0x8F9C;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PRIMITIVE_RESTART = 0x8F9D;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_PRIMITIVE_RESTART_INDEX = 0x8F9E;
#endif

#if (!GL_SC_VERSION_2_0)
        public const GLenum GL_INVALID_INDEX = 0xFFFFFFFF;
#endif
    }
}
#endif