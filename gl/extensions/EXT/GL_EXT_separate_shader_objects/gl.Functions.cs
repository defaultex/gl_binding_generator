#if (GL_EXT_separate_shader_objects && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glActiveProgramEXT(GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, void> glActiveProgramEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glActiveShaderProgramEXT(GLuint pipeline, GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<programpipeline, program, void> glActiveShaderProgramEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBindProgramPipelineEXT(GLuint pipeline);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<programpipeline, void> glBindProgramPipelineEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLuint glCreateShaderProgramEXT(GLenum type, GLchar* string);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, GLchar*, program> glCreateShaderProgramEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLuint glCreateShaderProgramvEXT(GLenum type, GLsizei count, GLchar** strings);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, GLsizei, GLchar**, program> glCreateShaderProgramvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeleteProgramPipelinesEXT(GLsizei n, GLuint* pipelines);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, programpipeline*, void> glDeleteProgramPipelinesEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGenProgramPipelinesEXT(GLsizei n, GLuint* pipelines);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, programpipeline*, void> glGenProgramPipelinesEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetProgramPipelineInfoLogEXT(GLuint pipeline, GLsizei bufSize, GLsizei* length, GLchar* infoLog);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<programpipeline, GLsizei, GLsizei*, GLchar*, void> glGetProgramPipelineInfoLogEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetProgramPipelineivEXT(GLuint pipeline, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<programpipeline, PipelineParameterName, GLint*, void> glGetProgramPipelineivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsProgramPipelineEXT(GLuint pipeline);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<programpipeline, GLboolean> glIsProgramPipelineEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramParameteriEXT(GLuint program, GLenum pname, GLint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramParameterPName, GLint, void> glProgramParameteriEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform1fEXT(GLuint program, GLint location, GLfloat v0);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLfloat, void> glProgramUniform1fEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform1fvEXT(GLuint program, GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLfloat*, void> glProgramUniform1fvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform1iEXT(GLuint program, GLint location, GLint v0);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLint, void> glProgramUniform1iEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform1ivEXT(GLuint program, GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLint*, void> glProgramUniform1ivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform1uiEXT(GLuint program, GLint location, GLuint v0);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLuint, void> glProgramUniform1uiEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform1uivEXT(GLuint program, GLint location, GLsizei count, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLuint*, void> glProgramUniform1uivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform2fEXT(GLuint program, GLint location, GLfloat v0, GLfloat v1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLfloat, GLfloat, void> glProgramUniform2fEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform2fvEXT(GLuint program, GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLfloat*, void> glProgramUniform2fvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform2iEXT(GLuint program, GLint location, GLint v0, GLint v1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLint, GLint, void> glProgramUniform2iEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform2ivEXT(GLuint program, GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLint*, void> glProgramUniform2ivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform2uiEXT(GLuint program, GLint location, GLuint v0, GLuint v1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLuint, GLuint, void> glProgramUniform2uiEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform2uivEXT(GLuint program, GLint location, GLsizei count, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLuint*, void> glProgramUniform2uivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform3fEXT(GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLfloat, GLfloat, GLfloat, void> glProgramUniform3fEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform3fvEXT(GLuint program, GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLfloat*, void> glProgramUniform3fvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform3iEXT(GLuint program, GLint location, GLint v0, GLint v1, GLint v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLint, GLint, GLint, void> glProgramUniform3iEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform3ivEXT(GLuint program, GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLint*, void> glProgramUniform3ivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform3uiEXT(GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLuint, GLuint, GLuint, void> glProgramUniform3uiEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform3uivEXT(GLuint program, GLint location, GLsizei count, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLuint*, void> glProgramUniform3uivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform4fEXT(GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLfloat, GLfloat, GLfloat, GLfloat, void> glProgramUniform4fEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform4fvEXT(GLuint program, GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLfloat*, void> glProgramUniform4fvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform4iEXT(GLuint program, GLint location, GLint v0, GLint v1, GLint v2, GLint v3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLint, GLint, GLint, GLint, void> glProgramUniform4iEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform4ivEXT(GLuint program, GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLint*, void> glProgramUniform4ivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform4uiEXT(GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLuint, GLuint, GLuint, GLuint, void> glProgramUniform4uiEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniform4uivEXT(GLuint program, GLint location, GLsizei count, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLuint*, void> glProgramUniform4uivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformMatrix2fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix2fvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformMatrix2x3fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix2x3fvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformMatrix2x4fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix2x4fvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformMatrix3fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix3fvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformMatrix3x2fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix3x2fvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformMatrix3x4fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix3x4fvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformMatrix4fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix4fvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformMatrix4x2fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix4x2fvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformMatrix4x3fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLboolean, GLfloat*, void> glProgramUniformMatrix4x3fvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUseProgramStagesEXT(GLuint pipeline, GLbitfield stages, GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<programpipeline, UseProgramStageMask, program, void> glUseProgramStagesEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUseShaderProgramEXT(GLenum type, GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, program, void> glUseShaderProgramEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glValidateProgramPipelineEXT(GLuint pipeline);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<programpipeline, void> glValidateProgramPipelineEXT;
#endif
    }
}
#endif