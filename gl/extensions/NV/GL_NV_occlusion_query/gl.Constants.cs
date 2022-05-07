#if (GL_NV_occlusion_query && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_PIXEL_COUNTER_BITS_NV = 0x8864;
        public const GLenum GL_CURRENT_OCCLUSION_QUERY_ID_NV = 0x8865;
        public const GLenum GL_PIXEL_COUNT_NV = 0x8866;
        public const GLenum GL_PIXEL_COUNT_AVAILABLE_NV = 0x8867;
    }
}
#endif