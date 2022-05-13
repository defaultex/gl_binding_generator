#if GL_KHR_parallel_shader_compile

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glMaxShaderCompilerThreadsKHR;
    }
}

#endif