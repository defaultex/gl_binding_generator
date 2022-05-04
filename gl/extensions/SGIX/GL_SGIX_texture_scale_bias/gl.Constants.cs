#if (GL_SGIX_texture_scale_bias && GL_API)
public partial class sgix { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_TEXTURE_FILTER_BIAS_SGIX = 0x8179;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_TEXTURE_FILTER_SCALE_SGIX = 0x817A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_TEXTURE_FILTER_BIAS_RANGE_SGIX = 0x817B;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_POST_TEXTURE_FILTER_SCALE_RANGE_SGIX = 0x817C;
#endif
    }
}
#endif