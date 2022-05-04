#if (GL_ARB_spirv_extensions && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_SPIR_V_EXTENSIONS = 0x9553;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        public const GLenum GL_NUM_SPIR_V_EXTENSIONS = 0x9554;
#endif
    }
}
#endif