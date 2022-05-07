#if (GL_EXT_polygon_offset_clamp && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_POLYGON_OFFSET_CLAMP_EXT = 0x8E1B;
    }
}
#endif