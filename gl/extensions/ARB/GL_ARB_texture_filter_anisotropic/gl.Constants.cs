#if (GL_ARB_texture_filter_anisotropic && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_TEXTURE_MAX_ANISOTROPY = 0x84FE;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_MAX_TEXTURE_MAX_ANISOTROPY = 0x84FF;
#endif
    }
}
#endif