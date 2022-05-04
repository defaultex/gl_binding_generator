#if (GL_ARB_vertex_type_2_10_10_10_rev && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_INT_2_10_10_10_REV = 0x8D9F;
#endif
    }
}
#endif