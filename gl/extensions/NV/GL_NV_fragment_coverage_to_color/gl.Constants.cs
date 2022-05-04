#if (GL_NV_fragment_coverage_to_color && (GL_API || GLCORE_API || GLES2_API))
public partial class nv { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAGMENT_COVERAGE_TO_COLOR_NV = 0x92DD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_FRAGMENT_COVERAGE_COLOR_NV = 0x92DE;
#endif
    }
}
#endif