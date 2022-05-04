#if (GL_SGI_color_table && GL_API)
public partial class sgi { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_TABLE_SGI = 0x80D0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D1;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D2;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROXY_COLOR_TABLE_SGI = 0x80D3;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROXY_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D4;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D5;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_TABLE_SCALE_SGI = 0x80D6;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_TABLE_BIAS_SGI = 0x80D7;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_TABLE_FORMAT_SGI = 0x80D8;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_TABLE_WIDTH_SGI = 0x80D9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_TABLE_RED_SIZE_SGI = 0x80DA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_TABLE_GREEN_SIZE_SGI = 0x80DB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_TABLE_BLUE_SIZE_SGI = 0x80DC;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_TABLE_ALPHA_SIZE_SGI = 0x80DD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_TABLE_LUMINANCE_SIZE_SGI = 0x80DE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_TABLE_INTENSITY_SIZE_SGI = 0x80DF;
#endif
    }
}
#endif