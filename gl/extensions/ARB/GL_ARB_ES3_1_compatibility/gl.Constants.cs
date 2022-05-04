#if (GL_ARB_ES3_1_compatibility && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_BACK = 0x0405;
#endif
    }
}
#endif