#if (GL_EXT_pixel_transform && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_TRANSFORM_2D_EXT = 0x8330;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_MAG_FILTER_EXT = 0x8331;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_MIN_FILTER_EXT = 0x8332;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_CUBIC_WEIGHT_EXT = 0x8333;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CUBIC_EXT = 0x8334;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_AVERAGE_EXT = 0x8335;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT = 0x8336;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT = 0x8337;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_TRANSFORM_2D_MATRIX_EXT = 0x8338;
#endif
    }
}
#endif