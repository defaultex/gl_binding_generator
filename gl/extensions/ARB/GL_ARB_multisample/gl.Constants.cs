#if (GL_ARB_multisample && GL_API)
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MULTISAMPLE_ARB = 0x809D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLE_ALPHA_TO_COVERAGE_ARB = 0x809E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLE_ALPHA_TO_ONE_ARB = 0x809F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLE_COVERAGE_ARB = 0x80A0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLE_BUFFERS_ARB = 0x80A8;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLES_ARB = 0x80A9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLE_COVERAGE_VALUE_ARB = 0x80AA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLE_COVERAGE_INVERT_ARB = 0x80AB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MULTISAMPLE_BIT_ARB = 0x20000000;
#endif
    }
}
#endif