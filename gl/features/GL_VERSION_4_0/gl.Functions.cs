#if (GL_VERSION_4_0 && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBeginQueryIndexed(GLenum target, GLuint index, GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, GLuint, query, void> glBeginQueryIndexed;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBindTransformFeedback(GLenum target, GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BindTransformFeedbackTarget, transformfeedback, void> glBindTransformFeedback;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBlendEquationi(GLuint buf, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendEquationModeEXT, void> glBlendEquationi;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBlendEquationSeparatei(GLuint buf, GLenum modeRGB, GLenum modeAlpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendEquationModeEXT, BlendEquationModeEXT, void> glBlendEquationSeparatei;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBlendFunci(GLuint buf, GLenum src, GLenum dst);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendingFactor, BlendingFactor, void> glBlendFunci;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBlendFuncSeparatei(GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void> glBlendFuncSeparatei;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDeleteTransformFeedbacks(GLsizei n, GLuint* ids);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, transformfeedback*, void> glDeleteTransformFeedbacks;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDrawArraysIndirect(GLenum mode, void* indirect);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void*, void> glDrawArraysIndirect;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDrawElementsIndirect(GLenum mode, GLenum type, void* indirect);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, DrawElementsType, void*, void> glDrawElementsIndirect;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDrawTransformFeedback(GLenum mode, GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, transformfeedback, void> glDrawTransformFeedback;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDrawTransformFeedbackStream(GLenum mode, GLuint id, GLuint stream);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, transformfeedback, GLuint, void> glDrawTransformFeedbackStream;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glEndQueryIndexed(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, GLuint, void> glEndQueryIndexed;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGenTransformFeedbacks(GLsizei n, GLuint* ids);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, transformfeedback*, void> glGenTransformFeedbacks;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetActiveSubroutineName(GLuint program, GLenum shadertype, GLuint index, GLsizei bufSize, GLsizei* length, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ShaderType, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetActiveSubroutineName;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetActiveSubroutineUniformiv(GLuint program, GLenum shadertype, GLuint index, GLenum pname, GLint* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ShaderType, GLuint, SubroutineParameterName, GLint*, void> glGetActiveSubroutineUniformiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetActiveSubroutineUniformName(GLuint program, GLenum shadertype, GLuint index, GLsizei bufSize, GLsizei* length, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ShaderType, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetActiveSubroutineUniformName;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetProgramStageiv(GLuint program, GLenum shadertype, GLenum pname, GLint* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ShaderType, ProgramStagePName, GLint*, void> glGetProgramStageiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetQueryIndexediv(GLenum target, GLuint index, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, GLuint, QueryParameterName, GLint*, void> glGetQueryIndexediv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLuint glGetSubroutineIndex(GLuint program, GLenum shadertype, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ShaderType, GLchar*, GLuint> glGetSubroutineIndex;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLint glGetSubroutineUniformLocation(GLuint program, GLenum shadertype, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ShaderType, GLchar*, GLint> glGetSubroutineUniformLocation;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetUniformdv(GLuint program, GLint location, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLdouble*, void> glGetUniformdv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetUniformSubroutineuiv(GLenum shadertype, GLint location, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, GLint, GLuint*, void> glGetUniformSubroutineuiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLboolean glIsTransformFeedback(GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<transformfeedback, GLboolean> glIsTransformFeedback;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMinSampleShading(GLfloat value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glMinSampleShading;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPatchParameterfv(GLenum pname, GLfloat* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PatchParameterName, GLfloat*, void> glPatchParameterfv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPatchParameteri(GLenum pname, GLint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PatchParameterName, GLint, void> glPatchParameteri;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glPauseTransformFeedback();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPauseTransformFeedback;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glResumeTransformFeedback();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glResumeTransformFeedback;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform1d(GLint location, GLdouble x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLdouble, void> glUniform1d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform1dv(GLint location, GLsizei count, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLdouble*, void> glUniform1dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform2d(GLint location, GLdouble x, GLdouble y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLdouble, GLdouble, void> glUniform2d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform2dv(GLint location, GLsizei count, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLdouble*, void> glUniform2dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform3d(GLint location, GLdouble x, GLdouble y, GLdouble z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLdouble, GLdouble, GLdouble, void> glUniform3d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform3dv(GLint location, GLsizei count, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLdouble*, void> glUniform3dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform4d(GLint location, GLdouble x, GLdouble y, GLdouble z, GLdouble w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLdouble, GLdouble, GLdouble, GLdouble, void> glUniform4d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform4dv(GLint location, GLsizei count, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLdouble*, void> glUniform4dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniformMatrix2dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix2dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniformMatrix2x3dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix2x3dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniformMatrix2x4dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix2x4dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniformMatrix3dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix3dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniformMatrix3x2dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix3x2dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniformMatrix3x4dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix3x4dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniformMatrix4dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix4dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniformMatrix4x2dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix4x2dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniformMatrix4x3dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix4x3dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniformSubroutinesuiv(GLenum shadertype, GLsizei count, GLuint* indices);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, GLsizei, GLuint*, void> glUniformSubroutinesuiv;
#endif
    }
}
#endif