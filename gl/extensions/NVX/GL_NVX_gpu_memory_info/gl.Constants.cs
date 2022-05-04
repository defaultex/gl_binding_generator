#if (GL_NVX_gpu_memory_info && GL_API)
public partial class nvx { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_GPU_MEMORY_INFO_DEDICATED_VIDMEM_NVX = 0x9047;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_GPU_MEMORY_INFO_TOTAL_AVAILABLE_MEMORY_NVX = 0x9048;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_GPU_MEMORY_INFO_CURRENT_AVAILABLE_VIDMEM_NVX = 0x9049;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_GPU_MEMORY_INFO_EVICTION_COUNT_NVX = 0x904A;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_GPU_MEMORY_INFO_EVICTED_MEMORY_NVX = 0x904B;
#endif
    }
}
#endif