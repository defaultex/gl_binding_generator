#if (GL_ARB_texture_rgb10_a2ui && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_RGB10_A2UI = 0x906F;
#endif
    }
}
#endif