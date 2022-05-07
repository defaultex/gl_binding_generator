#if (GL_NV_vertex_attrib_integer_64bit && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_INT64_NV = 0x140E;
        public const GLenum GL_UNSIGNED_INT64_NV = 0x140F;
    }
}
#endif