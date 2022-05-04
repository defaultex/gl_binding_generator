#if (GL_ARB_gl_spirv && (GL_API || GLCORE_API))
public partial class arb { 
    public partial class Constants { 

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SHADER_BINARY_FORMAT_SPIR_V_ARB = 0x9551;
#endif

#if (!GL_EXT_texture_shadow_lod)
        public const GLenum GL_SPIR_V_BINARY_ARB = 0x9552;
#endif
    }
}
#endif