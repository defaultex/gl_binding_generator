#if (GL_ARB_compute_variable_group_size && (GL_API || GLCORE_API))
public partial class glext_arb { 
    public partial class Constants { 
        public const GLenum GL_MAX_COMPUTE_FIXED_GROUP_INVOCATIONS_ARB = 0x90EB;
        public const GLenum GL_MAX_COMPUTE_FIXED_GROUP_SIZE_ARB = 0x91BF;
        public const GLenum GL_MAX_COMPUTE_VARIABLE_GROUP_INVOCATIONS_ARB = 0x9344;
        public const GLenum GL_MAX_COMPUTE_VARIABLE_GROUP_SIZE_ARB = 0x9345;
    }
}
#endif