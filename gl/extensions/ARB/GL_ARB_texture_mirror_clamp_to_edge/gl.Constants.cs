#if (GL_ARB_texture_mirror_clamp_to_edge && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_MIRROR_CLAMP_TO_EDGE = 0x8743;
#endif
    }
}
#endif