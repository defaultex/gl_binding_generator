#if (GL_EXT_vertex_array_bgra && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_BGRA = 0x80E1;
    }
}
#endif