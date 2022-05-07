#if (GL_ARB_indirect_parameters && (!gl || !glcore))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_PARAMETER_BUFFER_ARB = 0x80EE;
        public const GLenum GL_PARAMETER_BUFFER_BINDING_ARB = 0x80EF;
    }
}
#endif