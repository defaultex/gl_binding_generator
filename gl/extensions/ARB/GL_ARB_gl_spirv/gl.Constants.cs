#if (GL_ARB_gl_spirv && (GL_API || GLCORE_API))
public partial class glext_arb { 
    public partial class Constants { 
        public const GLenum GL_SHADER_BINARY_FORMAT_SPIR_V_ARB = 0x9551;
        public const GLenum GL_SPIR_V_BINARY_ARB = 0x9552;
    }
}
#endif