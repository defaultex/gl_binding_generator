#if (GL_ARB_explicit_uniform_location && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_UNIFORM_LOCATIONS = 0x826E;
#endif
    }
}
#endif