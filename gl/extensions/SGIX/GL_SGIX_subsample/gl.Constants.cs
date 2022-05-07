#if (GL_SGIX_subsample && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_PACK_SUBSAMPLE_RATE_SGIX = 0x85A0;
        public const GLenum GL_UNPACK_SUBSAMPLE_RATE_SGIX = 0x85A1;
        public const GLenum GL_PIXEL_SUBSAMPLE_4444_SGIX = 0x85A2;
        public const GLenum GL_PIXEL_SUBSAMPLE_2424_SGIX = 0x85A3;
        public const GLenum GL_PIXEL_SUBSAMPLE_4242_SGIX = 0x85A4;
    }
}
#endif