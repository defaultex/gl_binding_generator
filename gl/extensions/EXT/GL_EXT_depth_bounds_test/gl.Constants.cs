#if (GL_EXT_depth_bounds_test && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_DEPTH_BOUNDS_TEST_EXT = 0x8890;
        public const GLenum GL_DEPTH_BOUNDS_EXT = 0x8891;
    }
}
#endif