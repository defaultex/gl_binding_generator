#if (GL_ARB_vertex_array_object && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_VERTEX_ARRAY_BINDING = 0x85B5;
    }
}
#endif