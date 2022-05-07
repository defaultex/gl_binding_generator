#if (GL_ARB_polygon_offset_clamp && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_POLYGON_OFFSET_CLAMP = 0x8E1B;
    }
}
#endif