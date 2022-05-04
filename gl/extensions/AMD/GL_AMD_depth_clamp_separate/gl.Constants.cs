#if (GL_AMD_depth_clamp_separate && GL_API)
public partial class amd { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH_CLAMP_NEAR_AMD = 0x901E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH_CLAMP_FAR_AMD = 0x901F;
#endif
    }
}
#endif