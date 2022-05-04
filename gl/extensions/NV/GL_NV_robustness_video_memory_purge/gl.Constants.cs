#if (GL_NV_robustness_video_memory_purge && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PURGED_CONTEXT_RESET_NV = 0x92BB;
#endif
    }
}
#endif