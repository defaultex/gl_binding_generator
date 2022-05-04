#if (GL_ARB_sampler_objects && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_SAMPLER_BINDING = 0x8919;
#endif
    }
}
#endif