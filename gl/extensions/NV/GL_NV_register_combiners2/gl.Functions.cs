#if (GL_NV_register_combiners2 && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glCombinerStageParameterfvNV(GLenum stage, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CombinerStageNV, CombinerParameterNV, GLfloat*, void> glCombinerStageParameterfvNV;

        /// <summary>void glGetCombinerStageParameterfvNV(GLenum stage, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CombinerStageNV, CombinerParameterNV, GLfloat*, void> glGetCombinerStageParameterfvNV;
    }
}
#endif