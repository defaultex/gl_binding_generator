#if (GL_EXT_draw_range_elements && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_MAX_ELEMENTS_VERTICES_EXT = 0x80E8;
        public const GLenum GL_MAX_ELEMENTS_INDICES_EXT = 0x80E9;
    }
}
#endif