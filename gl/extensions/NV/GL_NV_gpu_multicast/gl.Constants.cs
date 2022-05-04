#if (GL_NV_gpu_multicast && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PER_GPU_STORAGE_BIT_NV = 0x0800;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MULTICAST_GPUS_NV = 0x92BA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PER_GPU_STORAGE_NV = 0x9548;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MULTICAST_PROGRAMMABLE_SAMPLE_LOCATION_NV = 0x9549;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_RENDER_GPU_MASK_NV = 0x9558;
#endif
    }
}
#endif