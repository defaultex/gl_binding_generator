#if (GL_NV_polygon_mode && !gles2)
public partial class gles2 { 
    public partial class Constants { 
        public const GLenum GL_POLYGON_MODE_NV = 0x0B40;
        public const GLenum GL_POINT_NV = 0x1B00;
        public const GLenum GL_LINE_NV = 0x1B01;
        public const GLenum GL_FILL_NV = 0x1B02;
        public const GLenum GL_POLYGON_OFFSET_POINT_NV = 0x2A01;
        public const GLenum GL_POLYGON_OFFSET_LINE_NV = 0x2A02;
    }
}
#endif