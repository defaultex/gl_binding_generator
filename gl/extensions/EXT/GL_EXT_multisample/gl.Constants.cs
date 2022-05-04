#if (GL_EXT_multisample && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MULTISAMPLE_EXT = 0x809D;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLE_ALPHA_TO_MASK_EXT = 0x809E;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLE_ALPHA_TO_ONE_EXT = 0x809F;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLE_MASK_EXT = 0x80A0;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_1PASS_EXT = 0x80A1;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_2PASS_0_EXT = 0x80A2;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_2PASS_1_EXT = 0x80A3;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_4PASS_0_EXT = 0x80A4;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_4PASS_1_EXT = 0x80A5;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_4PASS_2_EXT = 0x80A6;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_4PASS_3_EXT = 0x80A7;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLE_BUFFERS_EXT = 0x80A8;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLES_EXT = 0x80A9;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLE_MASK_VALUE_EXT = 0x80AA;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLE_MASK_INVERT_EXT = 0x80AB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLE_PATTERN_EXT = 0x80AC;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MULTISAMPLE_BIT_EXT = 0x20000000;
#endif
    }
}
#endif