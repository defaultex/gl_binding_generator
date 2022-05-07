#if (GL_SGIX_texture_scale_bias && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_POST_TEXTURE_FILTER_BIAS_SGIX = 0x8179;
        public const GLenum GL_POST_TEXTURE_FILTER_SCALE_SGIX = 0x817A;
        public const GLenum GL_POST_TEXTURE_FILTER_BIAS_RANGE_SGIX = 0x817B;
        public const GLenum GL_POST_TEXTURE_FILTER_SCALE_RANGE_SGIX = 0x817C;
    }
}
#endif