#if (GL_AMD_stencil_operation_extended && !gl)
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_SET_AMD = 0x874A;
        public const GLenum GL_REPLACE_VALUE_AMD = 0x874B;
        public const GLenum GL_STENCIL_OP_VALUE_AMD = 0x874C;
        public const GLenum GL_STENCIL_BACK_OP_VALUE_AMD = 0x874D;
    }
}
#endif