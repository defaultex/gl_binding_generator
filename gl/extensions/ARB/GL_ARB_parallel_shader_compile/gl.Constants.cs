#if (GL_ARB_parallel_shader_compile && (GL_API || GLCORE_API))
public partial class glext_arb { 
    public partial class Constants { 
        public const GLenum GL_MAX_SHADER_COMPILER_THREADS_ARB = 0x91B0;
        public const GLenum GL_COMPLETION_STATUS_ARB = 0x91B1;
    }
}
#endif