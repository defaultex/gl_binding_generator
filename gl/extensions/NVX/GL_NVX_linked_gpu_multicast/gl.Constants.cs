#if (GL_NVX_linked_gpu_multicast && GL_API)
public partial class nvx { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_LGPU_SEPARATE_STORAGE_BIT_NVX = 0x0800;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MAX_LGPU_GPUS_NVX = 0x92BA;
#endif
    }
}
#endif