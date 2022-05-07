#if (GL_NV_present_video && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_FRAME_NV = 0x8E26;
        public const GLenum GL_FIELDS_NV = 0x8E27;
        public const GLenum GL_CURRENT_TIME_NV = 0x8E28;
        public const GLenum GL_NUM_FILL_STREAMS_NV = 0x8E29;
        public const GLenum GL_PRESENT_TIME_NV = 0x8E2A;
        public const GLenum GL_PRESENT_DURATION_NV = 0x8E2B;
    }
}
#endif