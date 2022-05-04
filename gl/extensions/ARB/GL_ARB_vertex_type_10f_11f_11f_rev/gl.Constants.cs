#if (GL_ARB_vertex_type_10f_11f_11f_rev && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B;
#endif
    }
}
#endif