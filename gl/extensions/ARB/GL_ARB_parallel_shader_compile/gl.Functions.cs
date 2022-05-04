#if (GL_ARB_parallel_shader_compile && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMaxShaderCompilerThreadsARB(GLuint count);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glMaxShaderCompilerThreadsARB;
#endif
    }
}
#endif