#if (GL_ARB_vertex_array_bgra && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_BGRA = 0x80E1;
    }
}
#endif