#if (GL_ARB_shader_subroutine && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetActiveSubroutineName(GLuint program, GLenum shadertype, GLuint index, GLsizei bufSize, GLsizei* length, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ShaderType, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetActiveSubroutineName;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetActiveSubroutineUniformiv(GLuint program, GLenum shadertype, GLuint index, GLenum pname, GLint* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ShaderType, GLuint, SubroutineParameterName, GLint*, void> glGetActiveSubroutineUniformiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetActiveSubroutineUniformName(GLuint program, GLenum shadertype, GLuint index, GLsizei bufSize, GLsizei* length, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ShaderType, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetActiveSubroutineUniformName;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetProgramStageiv(GLuint program, GLenum shadertype, GLenum pname, GLint* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ShaderType, ProgramStagePName, GLint*, void> glGetProgramStageiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>GLuint glGetSubroutineIndex(GLuint program, GLenum shadertype, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ShaderType, GLchar*, GLuint> glGetSubroutineIndex;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>GLint glGetSubroutineUniformLocation(GLuint program, GLenum shadertype, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ShaderType, GLchar*, GLint> glGetSubroutineUniformLocation;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetUniformSubroutineuiv(GLenum shadertype, GLint location, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, GLint, GLuint*, void> glGetUniformSubroutineuiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glUniformSubroutinesuiv(GLenum shadertype, GLsizei count, GLuint* indices);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, GLsizei, GLuint*, void> glUniformSubroutinesuiv;
#endif
    }
}
#endif