#if (GL_KHR_parallel_shader_compile && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glMaxShaderCompilerThreadsKHR(GLuint count)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glMaxShaderCompilerThreadsKHR;
    }
}
#endif