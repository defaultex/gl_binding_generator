#if (GL_AMD_occlusion_query_event && GL_API)
public partial class amd { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_QUERY_DEPTH_PASS_EVENT_BIT_AMD = 0x00000001;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_QUERY_DEPTH_FAIL_EVENT_BIT_AMD = 0x00000002;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_QUERY_STENCIL_FAIL_EVENT_BIT_AMD = 0x00000004;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_QUERY_DEPTH_BOUNDS_FAIL_EVENT_BIT_AMD = 0x00000008;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_OCCLUSION_QUERY_EVENT_MASK_AMD = 0x874F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_QUERY_ALL_EVENT_BITS_AMD = 0xFFFFFFFF;
#endif
    }
}
#endif