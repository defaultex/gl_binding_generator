#if (GL_ARB_occlusion_query2 && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_ANY_SAMPLES_PASSED = 0x8C2F;
#endif
    }
}
#endif