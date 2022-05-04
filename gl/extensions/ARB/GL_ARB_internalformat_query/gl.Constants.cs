#if (GL_ARB_internalformat_query && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_NUM_SAMPLE_COUNTS = 0x9380;
#endif
    }
}
#endif