#if (GL_NV_register_combiners2 && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCombinerStageParameterfvNV(GLenum stage, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CombinerStageNV, CombinerParameterNV, GLfloat*, void> glCombinerStageParameterfvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetCombinerStageParameterfvNV(GLenum stage, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CombinerStageNV, CombinerParameterNV, GLfloat*, void> glGetCombinerStageParameterfvNV;
#endif
    }
}
#endif