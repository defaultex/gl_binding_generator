#if (GL_ARB_cull_distance && (GL_API || GLCORE_API))
public partial class glext_arb { 
    public partial class Constants { 
        public const GLenum GL_MAX_CULL_DISTANCES = 0x82F9;
        public const GLenum GL_MAX_COMBINED_CLIP_AND_CULL_DISTANCES = 0x82FA;
    }
}
#endif