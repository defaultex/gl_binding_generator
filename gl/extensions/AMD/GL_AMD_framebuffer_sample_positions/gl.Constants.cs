#if (GL_AMD_framebuffer_sample_positions && GL_API)
public partial class amd { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SUBSAMPLE_DISTANCE_AMD = 0x883F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXELS_PER_SAMPLE_PATTERN_X_AMD = 0x91AE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PIXELS_PER_SAMPLE_PATTERN_Y_AMD = 0x91AF;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ALL_PIXELS_AMD = 0xFFFFFFFF;
#endif
    }
}
#endif