#if (GL_ARB_indirect_parameters && (GL_API || GLCORE_API))
public partial class glext_arb { 
    public partial class Constants { 
        public const GLenum GL_PARAMETER_BUFFER_ARB = 0x80EE;
        public const GLenum GL_PARAMETER_BUFFER_BINDING_ARB = 0x80EF;
    }
}
#endif