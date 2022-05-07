#if (GL_SGIX_resample && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_PACK_RESAMPLE_SGIX = 0x842E;
        public const GLenum GL_UNPACK_RESAMPLE_SGIX = 0x842F;
        public const GLenum GL_RESAMPLE_DECIMATE_SGIX = 0x8430;
        public const GLenum GL_RESAMPLE_REPLICATE_SGIX = 0x8433;
        public const GLenum GL_RESAMPLE_ZERO_FILL_SGIX = 0x8434;
    }
}
#endif