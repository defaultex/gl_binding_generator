#if (GL_NV_texture_multisample && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_TEXTURE_COVERAGE_SAMPLES_NV = 0x9045;
        public const GLenum GL_TEXTURE_COLOR_SAMPLES_NV = 0x9046;
    }
}
#endif