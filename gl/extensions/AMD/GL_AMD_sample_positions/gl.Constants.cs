#if (GL_AMD_sample_positions && GL_API)
public partial class amd { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SUBSAMPLE_DISTANCE_AMD = 0x883F;
#endif
    }
}
#endif