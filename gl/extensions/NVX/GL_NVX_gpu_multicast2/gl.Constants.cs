#if (GL_NVX_gpu_multicast2 && GL_API)
public partial class nvx { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_UPLOAD_GPU_MASK_NVX = 0x954A;
#endif
    }
}
#endif