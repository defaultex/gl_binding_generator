#if (GL_NV_query_resource && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_QUERY_RESOURCE_TYPE_VIDMEM_ALLOC_NV = 0x9540;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_QUERY_RESOURCE_MEMTYPE_VIDMEM_NV = 0x9542;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_QUERY_RESOURCE_SYS_RESERVED_NV = 0x9544;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_QUERY_RESOURCE_TEXTURE_NV = 0x9545;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_QUERY_RESOURCE_RENDERBUFFER_NV = 0x9546;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_QUERY_RESOURCE_BUFFEROBJECT_NV = 0x9547;
#endif
    }
}
#endif