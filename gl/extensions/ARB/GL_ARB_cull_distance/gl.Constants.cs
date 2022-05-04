#if (GL_ARB_cull_distance && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_CULL_DISTANCES = 0x82F9;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_COMBINED_CLIP_AND_CULL_DISTANCES = 0x82FA;
#endif
    }
}
#endif