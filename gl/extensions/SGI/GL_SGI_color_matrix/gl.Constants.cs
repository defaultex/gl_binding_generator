#if (GL_SGI_color_matrix && GL_API)
public partial class sgi { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_MATRIX_SGI = 0x80B1;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B2;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B3;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_COLOR_MATRIX_RED_SCALE_SGI = 0x80B4;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI = 0x80B5;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI = 0x80B6;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI = 0x80B7;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_COLOR_MATRIX_RED_BIAS_SGI = 0x80B8;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI = 0x80B9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI = 0x80BA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_COLOR_MATRIX_ALPHA_BIAS_SGI = 0x80BB;
#endif
    }
}
#endif