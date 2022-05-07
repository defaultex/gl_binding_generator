#if (GL_NV_vertex_array_range && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_VERTEX_ARRAY_RANGE_NV = 0x851D;
        public const GLenum GL_VERTEX_ARRAY_RANGE_LENGTH_NV = 0x851E;
        public const GLenum GL_VERTEX_ARRAY_RANGE_VALID_NV = 0x851F;
        public const GLenum GL_MAX_VERTEX_ARRAY_RANGE_ELEMENT_NV = 0x8520;
        public const GLenum GL_VERTEX_ARRAY_RANGE_POINTER_NV = 0x8521;
    }
}
#endif