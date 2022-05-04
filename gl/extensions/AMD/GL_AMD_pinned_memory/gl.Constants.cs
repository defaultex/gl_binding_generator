#if (GL_AMD_pinned_memory && GL_API)
public partial class amd { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_EXTERNAL_VIRTUAL_MEMORY_BUFFER_AMD = 0x9160;
#endif
    }
}
#endif