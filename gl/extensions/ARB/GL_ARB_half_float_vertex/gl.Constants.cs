#if (GL_ARB_half_float_vertex && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_HALF_FLOAT = 0x140B;
    }
}
#endif