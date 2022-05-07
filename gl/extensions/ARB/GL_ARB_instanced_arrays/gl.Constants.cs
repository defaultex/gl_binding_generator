#if (GL_ARB_instanced_arrays && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_VERTEX_ATTRIB_ARRAY_DIVISOR_ARB = 0x88FE;
    }
}
#endif