#if (GL_KHR_parallel_shader_compile && (!gl || !glcore || !gles2))
public partial class gl { 
    public partial class Constants { 
        public const GLenum GL_MAX_SHADER_COMPILER_THREADS_KHR = 0x91B0;
        public const GLenum GL_COMPLETION_STATUS_KHR = 0x91B1;
    }
}
#endif