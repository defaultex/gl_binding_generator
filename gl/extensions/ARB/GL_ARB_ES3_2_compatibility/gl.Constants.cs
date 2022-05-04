#if (GL_ARB_ES3_2_compatibility && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_PRIMITIVE_BOUNDING_BOX_ARB = 0x92BE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MULTISAMPLE_LINE_WIDTH_RANGE_ARB = 0x9381;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MULTISAMPLE_LINE_WIDTH_GRANULARITY_ARB = 0x9382;
#endif
    }
}
#endif