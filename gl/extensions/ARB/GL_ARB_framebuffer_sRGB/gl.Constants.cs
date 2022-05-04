#if (GL_ARB_framebuffer_sRGB && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_FRAMEBUFFER_SRGB = 0x8DB9;
#endif
    }
}
#endif