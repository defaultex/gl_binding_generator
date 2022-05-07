#if (GL_NV_pixel_data_range && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_WRITE_PIXEL_DATA_RANGE_NV = 0x8878;
        public const GLenum GL_READ_PIXEL_DATA_RANGE_NV = 0x8879;
        public const GLenum GL_WRITE_PIXEL_DATA_RANGE_LENGTH_NV = 0x887A;
        public const GLenum GL_READ_PIXEL_DATA_RANGE_LENGTH_NV = 0x887B;
        public const GLenum GL_WRITE_PIXEL_DATA_RANGE_POINTER_NV = 0x887C;
        public const GLenum GL_READ_PIXEL_DATA_RANGE_POINTER_NV = 0x887D;
    }
}
#endif