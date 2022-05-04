#if (GL_NV_multisample_coverage && GL_API)
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLES_ARB = 0x80A9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_COLOR_SAMPLES_NV = 0x8E20;
#endif
    }
}
#endif