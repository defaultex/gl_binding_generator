#if (GL_EXT_convolution && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONVOLUTION_1D_EXT = 0x8010;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONVOLUTION_2D_EXT = 0x8011;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SEPARABLE_2D_EXT = 0x8012;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONVOLUTION_BORDER_MODE_EXT = 0x8013;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONVOLUTION_FILTER_SCALE_EXT = 0x8014;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONVOLUTION_FILTER_BIAS_EXT = 0x8015;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_REDUCE_EXT = 0x8016;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONVOLUTION_FORMAT_EXT = 0x8017;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONVOLUTION_WIDTH_EXT = 0x8018;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CONVOLUTION_HEIGHT_EXT = 0x8019;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_CONVOLUTION_WIDTH_EXT = 0x801A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_CONVOLUTION_HEIGHT_EXT = 0x801B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_CONVOLUTION_RED_SCALE_EXT = 0x801C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_CONVOLUTION_GREEN_SCALE_EXT = 0x801D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_CONVOLUTION_BLUE_SCALE_EXT = 0x801E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_CONVOLUTION_ALPHA_SCALE_EXT = 0x801F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_CONVOLUTION_RED_BIAS_EXT = 0x8020;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_CONVOLUTION_GREEN_BIAS_EXT = 0x8021;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_CONVOLUTION_BLUE_BIAS_EXT = 0x8022;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_CONVOLUTION_ALPHA_BIAS_EXT = 0x8023;
#endif
    }
}
#endif