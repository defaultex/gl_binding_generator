#if (GL_AMD_blend_minmax_factor && GL_API)
public partial class amd { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FACTOR_MIN_AMD = 0x901C;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FACTOR_MAX_AMD = 0x901D;
#endif
    }
}
#endif