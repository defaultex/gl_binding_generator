#if (GL_ARB_sample_shading && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SAMPLE_SHADING_ARB = 0x8C36;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_MIN_SAMPLE_SHADING_VALUE_ARB = 0x8C37;
#endif
    }
}
#endif