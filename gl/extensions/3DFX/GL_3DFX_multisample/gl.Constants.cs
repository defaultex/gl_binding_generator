#if (GL_3DFX_multisample && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_MULTISAMPLE_3DFX = 0x86B2;
        public const GLenum GL_SAMPLE_BUFFERS_3DFX = 0x86B3;
        public const GLenum GL_SAMPLES_3DFX = 0x86B4;
        public const GLenum GL_MULTISAMPLE_BIT_3DFX = 0x20000000;
    }
}
#endif