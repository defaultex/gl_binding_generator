#if (GL_ARB_conditional_render_inverted && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_QUERY_WAIT_INVERTED = 0x8E17;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_QUERY_NO_WAIT_INVERTED = 0x8E18;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_QUERY_BY_REGION_WAIT_INVERTED = 0x8E19;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_QUERY_BY_REGION_NO_WAIT_INVERTED = 0x8E1A;
#endif
    }
}
#endif