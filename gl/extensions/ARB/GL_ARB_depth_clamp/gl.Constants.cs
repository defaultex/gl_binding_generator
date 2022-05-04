#if (GL_ARB_depth_clamp && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_DEPTH_CLAMP = 0x864F;
#endif
    }
}
#endif