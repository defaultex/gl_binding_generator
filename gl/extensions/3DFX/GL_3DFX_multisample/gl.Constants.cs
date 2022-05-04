#if (GL_3DFX_multisample && GL_API)
public partial class 3dfx { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MULTISAMPLE_3DFX = 0x86B2;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLE_BUFFERS_3DFX = 0x86B3;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLES_3DFX = 0x86B4;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MULTISAMPLE_BIT_3DFX = 0x20000000;
#endif
    }
}
#endif