#if (GL_ARB_texture_filter_minmax && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_TEXTURE_REDUCTION_MODE_ARB = 0x9366;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_WEIGHTED_AVERAGE_ARB = 0x9367;
#endif
    }
}
#endif