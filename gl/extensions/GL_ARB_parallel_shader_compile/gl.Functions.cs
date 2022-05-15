#if GL_ARB_parallel_shader_compile

public partial class gl { 
    public partial class Functions { 

        /// <summary>void glMaxShaderCompilerThreadsARB(GLuint count);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glMaxShaderCompilerThreadsARB;
    }
}

#endif