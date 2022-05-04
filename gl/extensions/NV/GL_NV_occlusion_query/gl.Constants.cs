#if (GL_NV_occlusion_query && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_COUNTER_BITS_NV = 0x8864;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_CURRENT_OCCLUSION_QUERY_ID_NV = 0x8865;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_COUNT_NV = 0x8866;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXEL_COUNT_AVAILABLE_NV = 0x8867;
#endif
    }
}
#endif