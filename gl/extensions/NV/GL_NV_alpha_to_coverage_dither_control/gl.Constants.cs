#if (GL_NV_alpha_to_coverage_dither_control && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ALPHA_TO_COVERAGE_DITHER_MODE_NV = 0x92BF;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ALPHA_TO_COVERAGE_DITHER_DEFAULT_NV = 0x934D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ALPHA_TO_COVERAGE_DITHER_ENABLE_NV = 0x934E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_ALPHA_TO_COVERAGE_DITHER_DISABLE_NV = 0x934F;
#endif
    }
}
#endif