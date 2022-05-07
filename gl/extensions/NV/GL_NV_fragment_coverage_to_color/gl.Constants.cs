#if (GL_NV_fragment_coverage_to_color && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_FRAGMENT_COVERAGE_TO_COLOR_NV = 0x92DD;
        public const GLenum GL_FRAGMENT_COVERAGE_COLOR_NV = 0x92DE;
    }
}
#endif