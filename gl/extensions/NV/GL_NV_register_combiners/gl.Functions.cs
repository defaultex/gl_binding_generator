#if (GL_NV_register_combiners && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCombinerInputNV(GLenum stage, GLenum portion, GLenum variable, GLenum input, GLenum mapping, GLenum componentUsage);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CombinerStageNV, CombinerPortionNV, CombinerVariableNV, CombinerRegisterNV, CombinerMappingNV, CombinerComponentUsageNV, void> glCombinerInputNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCombinerOutputNV(GLenum stage, GLenum portion, GLenum abOutput, GLenum cdOutput, GLenum sumOutput, GLenum scale, GLenum bias, GLboolean abDotProduct, GLboolean cdDotProduct, GLboolean muxSum);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CombinerStageNV, CombinerPortionNV, CombinerRegisterNV, CombinerRegisterNV, CombinerRegisterNV, CombinerScaleNV, CombinerBiasNV, GLboolean, GLboolean, GLboolean, void> glCombinerOutputNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCombinerParameterfNV(GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CombinerParameterNV, GLfloat, void> glCombinerParameterfNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCombinerParameterfvNV(GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CombinerParameterNV, GLfloat*, void> glCombinerParameterfvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCombinerParameteriNV(GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CombinerParameterNV, GLint, void> glCombinerParameteriNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCombinerParameterivNV(GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CombinerParameterNV, GLint*, void> glCombinerParameterivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFinalCombinerInputNV(GLenum variable, GLenum input, GLenum mapping, GLenum componentUsage);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CombinerVariableNV, CombinerRegisterNV, CombinerMappingNV, CombinerComponentUsageNV, void> glFinalCombinerInputNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetCombinerInputParameterfvNV(GLenum stage, GLenum portion, GLenum variable, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CombinerStageNV, CombinerPortionNV, CombinerVariableNV, CombinerParameterNV, GLfloat*, void> glGetCombinerInputParameterfvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetCombinerInputParameterivNV(GLenum stage, GLenum portion, GLenum variable, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CombinerStageNV, CombinerPortionNV, CombinerVariableNV, CombinerParameterNV, GLint*, void> glGetCombinerInputParameterivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetCombinerOutputParameterfvNV(GLenum stage, GLenum portion, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CombinerStageNV, CombinerPortionNV, CombinerParameterNV, GLfloat*, void> glGetCombinerOutputParameterfvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetCombinerOutputParameterivNV(GLenum stage, GLenum portion, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CombinerStageNV, CombinerPortionNV, CombinerParameterNV, GLint*, void> glGetCombinerOutputParameterivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetFinalCombinerInputParameterfvNV(GLenum variable, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CombinerVariableNV, CombinerParameterNV, GLfloat*, void> glGetFinalCombinerInputParameterfvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetFinalCombinerInputParameterivNV(GLenum variable, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CombinerVariableNV, CombinerParameterNV, GLint*, void> glGetFinalCombinerInputParameterivNV;
#endif
    }
}
#endif