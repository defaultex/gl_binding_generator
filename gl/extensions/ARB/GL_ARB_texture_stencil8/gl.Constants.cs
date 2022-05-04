#if (GL_ARB_texture_stencil8 && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_STENCIL_INDEX = 0x1901;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_STENCIL_INDEX8 = 0x8D48;
#endif
    }
}
#endif