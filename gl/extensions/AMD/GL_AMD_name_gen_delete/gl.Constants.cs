#if (GL_AMD_name_gen_delete && GL_API)
public partial class amd { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DATA_BUFFER_AMD = 0x9151;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PERFORMANCE_MONITOR_AMD = 0x9152;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_QUERY_OBJECT_AMD = 0x9153;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_VERTEX_ARRAY_OBJECT_AMD = 0x9154;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLER_OBJECT_AMD = 0x9155;
#endif
    }
}
#endif