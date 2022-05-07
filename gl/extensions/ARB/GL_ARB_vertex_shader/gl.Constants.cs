#if (GL_ARB_vertex_shader && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_FLOAT = 0x1406;
        public const GLenum GL_VERTEX_ATTRIB_ARRAY_ENABLED_ARB = 0x8622;
        public const GLenum GL_VERTEX_ATTRIB_ARRAY_SIZE_ARB = 0x8623;
        public const GLenum GL_VERTEX_ATTRIB_ARRAY_STRIDE_ARB = 0x8624;
        public const GLenum GL_VERTEX_ATTRIB_ARRAY_TYPE_ARB = 0x8625;
        public const GLenum GL_CURRENT_VERTEX_ATTRIB_ARB = 0x8626;
        public const GLenum GL_VERTEX_PROGRAM_POINT_SIZE_ARB = 0x8642;
        public const GLenum GL_VERTEX_PROGRAM_TWO_SIDE_ARB = 0x8643;
        public const GLenum GL_VERTEX_ATTRIB_ARRAY_POINTER_ARB = 0x8645;
        public const GLenum GL_MAX_VERTEX_ATTRIBS_ARB = 0x8869;
        public const GLenum GL_VERTEX_ATTRIB_ARRAY_NORMALIZED_ARB = 0x886A;
        public const GLenum GL_MAX_TEXTURE_COORDS_ARB = 0x8871;
        public const GLenum GL_MAX_TEXTURE_IMAGE_UNITS_ARB = 0x8872;
        public const GLenum GL_VERTEX_SHADER_ARB = 0x8B31;
        public const GLenum GL_MAX_VERTEX_UNIFORM_COMPONENTS_ARB = 0x8B4A;
        public const GLenum GL_MAX_VARYING_FLOATS_ARB = 0x8B4B;
        public const GLenum GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS_ARB = 0x8B4C;
        public const GLenum GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS_ARB = 0x8B4D;
        public const GLenum GL_FLOAT_VEC2_ARB = 0x8B50;
        public const GLenum GL_FLOAT_VEC3_ARB = 0x8B51;
        public const GLenum GL_FLOAT_VEC4_ARB = 0x8B52;
        public const GLenum GL_FLOAT_MAT2_ARB = 0x8B5A;
        public const GLenum GL_FLOAT_MAT3_ARB = 0x8B5B;
        public const GLenum GL_FLOAT_MAT4_ARB = 0x8B5C;
        public const GLenum GL_OBJECT_ACTIVE_ATTRIBUTES_ARB = 0x8B89;
        public const GLenum GL_OBJECT_ACTIVE_ATTRIBUTE_MAX_LENGTH_ARB = 0x8B8A;
    }
}
#endif