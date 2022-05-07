#if (GL_NV_video_capture && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_VIDEO_BUFFER_NV = 0x9020;
        public const GLenum GL_VIDEO_BUFFER_BINDING_NV = 0x9021;
        public const GLenum GL_FIELD_UPPER_NV = 0x9022;
        public const GLenum GL_FIELD_LOWER_NV = 0x9023;
        public const GLenum GL_NUM_VIDEO_CAPTURE_STREAMS_NV = 0x9024;
        public const GLenum GL_NEXT_VIDEO_CAPTURE_BUFFER_STATUS_NV = 0x9025;
        public const GLenum GL_VIDEO_CAPTURE_TO_422_SUPPORTED_NV = 0x9026;
        public const GLenum GL_LAST_VIDEO_CAPTURE_STATUS_NV = 0x9027;
        public const GLenum GL_VIDEO_BUFFER_PITCH_NV = 0x9028;
        public const GLenum GL_VIDEO_COLOR_CONVERSION_MATRIX_NV = 0x9029;
        public const GLenum GL_VIDEO_COLOR_CONVERSION_MAX_NV = 0x902A;
        public const GLenum GL_VIDEO_COLOR_CONVERSION_MIN_NV = 0x902B;
        public const GLenum GL_VIDEO_COLOR_CONVERSION_OFFSET_NV = 0x902C;
        public const GLenum GL_VIDEO_BUFFER_INTERNAL_FORMAT_NV = 0x902D;
        public const GLenum GL_PARTIAL_SUCCESS_NV = 0x902E;
        public const GLenum GL_SUCCESS_NV = 0x902F;
        public const GLenum GL_FAILURE_NV = 0x9030;
        public const GLenum GL_YCBYCR8_422_NV = 0x9031;
        public const GLenum GL_YCBAYCR8A_4224_NV = 0x9032;
        public const GLenum GL_Z6Y10Z6CB10Z6Y10Z6CR10_422_NV = 0x9033;
        public const GLenum GL_Z6Y10Z6CB10Z6A10Z6Y10Z6CR10Z6A10_4224_NV = 0x9034;
        public const GLenum GL_Z4Y12Z4CB12Z4Y12Z4CR12_422_NV = 0x9035;
        public const GLenum GL_Z4Y12Z4CB12Z4A12Z4Y12Z4CR12Z4A12_4224_NV = 0x9036;
        public const GLenum GL_Z4Y12Z4CB12Z4CR12_444_NV = 0x9037;
        public const GLenum GL_VIDEO_CAPTURE_FRAME_WIDTH_NV = 0x9038;
        public const GLenum GL_VIDEO_CAPTURE_FRAME_HEIGHT_NV = 0x9039;
        public const GLenum GL_VIDEO_CAPTURE_FIELD_UPPER_HEIGHT_NV = 0x903A;
        public const GLenum GL_VIDEO_CAPTURE_FIELD_LOWER_HEIGHT_NV = 0x903B;
        public const GLenum GL_VIDEO_CAPTURE_SURFACE_ORIGIN_NV = 0x903C;
    }
}
#endif