#if (GL_EXT_polygon_offset && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_POLYGON_OFFSET_EXT = 0x8037;
        public const GLenum GL_POLYGON_OFFSET_FACTOR_EXT = 0x8038;
        public const GLenum GL_POLYGON_OFFSET_BIAS_EXT = 0x8039;
    }
}
#endif