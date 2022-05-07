#if (GL_NV_robustness_video_memory_purge && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_PURGED_CONTEXT_RESET_NV = 0x92BB;
    }
}
#endif