#if (GL_AMD_query_buffer_object && GL_API)
public partial class amd { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_QUERY_BUFFER_AMD = 0x9192;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_QUERY_BUFFER_BINDING_AMD = 0x9193;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_QUERY_RESULT_NO_WAIT_AMD = 0x9194;
#endif
    }
}
#endif