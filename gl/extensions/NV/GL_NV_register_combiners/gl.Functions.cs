#if (GL_NV_register_combiners && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glCombinerInputNV(GLenum stage, GLenum portion, GLenum variable, GLenum input, GLenum mapping, GLenum componentUsage);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CombinerStageNV, CombinerPortionNV, CombinerVariableNV, CombinerRegisterNV, CombinerMappingNV, CombinerComponentUsageNV, void> glCombinerInputNV;

        /// <summary>void glCombinerOutputNV(GLenum stage, GLenum portion, GLenum abOutput, GLenum cdOutput, GLenum sumOutput, GLenum scale, GLenum bias, GLboolean abDotProduct, GLboolean cdDotProduct, GLboolean muxSum);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CombinerStageNV, CombinerPortionNV, CombinerRegisterNV, CombinerRegisterNV, CombinerRegisterNV, CombinerScaleNV, CombinerBiasNV, GLboolean, GLboolean, GLboolean, void> glCombinerOutputNV;

        /// <summary>void glCombinerParameterfNV(GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CombinerParameterNV, GLfloat, void> glCombinerParameterfNV;

        /// <summary>void glCombinerParameterfvNV(GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CombinerParameterNV, GLfloat*, void> glCombinerParameterfvNV;

        /// <summary>void glCombinerParameteriNV(GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CombinerParameterNV, GLint, void> glCombinerParameteriNV;

        /// <summary>void glCombinerParameterivNV(GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CombinerParameterNV, GLint*, void> glCombinerParameterivNV;

        /// <summary>void glFinalCombinerInputNV(GLenum variable, GLenum input, GLenum mapping, GLenum componentUsage);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CombinerVariableNV, CombinerRegisterNV, CombinerMappingNV, CombinerComponentUsageNV, void> glFinalCombinerInputNV;

        /// <summary>void glGetCombinerInputParameterfvNV(GLenum stage, GLenum portion, GLenum variable, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CombinerStageNV, CombinerPortionNV, CombinerVariableNV, CombinerParameterNV, GLfloat*, void> glGetCombinerInputParameterfvNV;

        /// <summary>void glGetCombinerInputParameterivNV(GLenum stage, GLenum portion, GLenum variable, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CombinerStageNV, CombinerPortionNV, CombinerVariableNV, CombinerParameterNV, GLint*, void> glGetCombinerInputParameterivNV;

        /// <summary>void glGetCombinerOutputParameterfvNV(GLenum stage, GLenum portion, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CombinerStageNV, CombinerPortionNV, CombinerParameterNV, GLfloat*, void> glGetCombinerOutputParameterfvNV;

        /// <summary>void glGetCombinerOutputParameterivNV(GLenum stage, GLenum portion, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CombinerStageNV, CombinerPortionNV, CombinerParameterNV, GLint*, void> glGetCombinerOutputParameterivNV;

        /// <summary>void glGetFinalCombinerInputParameterfvNV(GLenum variable, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CombinerVariableNV, CombinerParameterNV, GLfloat*, void> glGetFinalCombinerInputParameterfvNV;

        /// <summary>void glGetFinalCombinerInputParameterivNV(GLenum variable, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CombinerVariableNV, CombinerParameterNV, GLint*, void> glGetFinalCombinerInputParameterivNV;
    }
}
#endif