#if (GL_EXT_depth_bounds_test && GL_API)
public partial class ext { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH_BOUNDS_TEST_EXT = 0x8890;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_DEPTH_BOUNDS_EXT = 0x8891;
#endif
    }
}
#endif