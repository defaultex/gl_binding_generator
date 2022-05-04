#if (GL_SGIS_point_parameters && GL_API)
public partial class sgis { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POINT_SIZE_MIN_SGIS = 0x8126;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POINT_SIZE_MAX_SGIS = 0x8127;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POINT_FADE_THRESHOLD_SIZE_SGIS = 0x8128;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DISTANCE_ATTENUATION_SGIS = 0x8129;
#endif
    }
}
#endif