#if (GL_NV_multisample_coverage && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_SAMPLES_ARB = 0x80A9;
        public const GLenum GL_COLOR_SAMPLES_NV = 0x8E20;
    }
}
#endif