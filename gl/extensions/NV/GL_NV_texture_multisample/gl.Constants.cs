#if (GL_NV_texture_multisample && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_COVERAGE_SAMPLES_NV = 0x9045;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_COLOR_SAMPLES_NV = 0x9046;
#endif
    }
}
#endif