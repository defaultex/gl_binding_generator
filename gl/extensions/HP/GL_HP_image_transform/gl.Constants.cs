#if (GL_HP_image_transform && GL_API)
public partial class hp { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IMAGE_SCALE_X_HP = 0x8155;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IMAGE_SCALE_Y_HP = 0x8156;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IMAGE_TRANSLATE_X_HP = 0x8157;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IMAGE_TRANSLATE_Y_HP = 0x8158;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IMAGE_ROTATE_ANGLE_HP = 0x8159;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IMAGE_ROTATE_ORIGIN_X_HP = 0x815A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IMAGE_ROTATE_ORIGIN_Y_HP = 0x815B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IMAGE_MAG_FILTER_HP = 0x815C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IMAGE_MIN_FILTER_HP = 0x815D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IMAGE_CUBIC_WEIGHT_HP = 0x815E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CUBIC_HP = 0x815F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_AVERAGE_HP = 0x8160;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_IMAGE_TRANSFORM_2D_HP = 0x8161;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP = 0x8162;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PROXY_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP = 0x8163;
#endif
    }
}
#endif