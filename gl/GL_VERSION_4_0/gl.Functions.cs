#if (GL_VERSION_4_0 && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBeginQueryIndexed(GLenum target, GLuint index, GLuint id)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, GLuint, GLquery, void> glBeginQueryIndexed;

#if !GL_ES_VERSION_3_0

        /// <summary>void glBindTransformFeedback(GLenum target, GLuint id)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BindTransformFeedbackTarget, GLtransformfeedback, void> glBindTransformFeedback;

#endif

#if !GL_ES_VERSION_3_2

        /// <summary>void glBlendEquationSeparatei(GLuint buf, GLenum modeRGB, GLenum modeAlpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendEquationModeEXT, BlendEquationModeEXT, void> glBlendEquationSeparatei;

#endif

#if !GL_ES_VERSION_3_2

        /// <summary>void glBlendEquationi(GLuint buf, GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendEquationModeEXT, void> glBlendEquationi;

#endif

#if !GL_ES_VERSION_3_2

        /// <summary>void glBlendFuncSeparatei(GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void> glBlendFuncSeparatei;

#endif

#if !GL_ES_VERSION_3_2

        /// <summary>void glBlendFunci(GLuint buf, GLenum src, GLenum dst)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendingFactor, BlendingFactor, void> glBlendFunci;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glDeleteTransformFeedbacks(GLsizei n, const GLuint* ids)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLtransformfeedback*, void> glDeleteTransformFeedbacks;

#endif

#if !GL_ES_VERSION_3_1

        /// <summary>void glDrawArraysIndirect(GLenum mode, const void* indirect)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void*, void> glDrawArraysIndirect;

#endif

#if !GL_ES_VERSION_3_1

        /// <summary>void glDrawElementsIndirect(GLenum mode, GLenum type, const void* indirect)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, DrawElementsType, void*, void> glDrawElementsIndirect;

#endif

        /// <summary>void glDrawTransformFeedback(GLenum mode, GLuint id)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLtransformfeedback, void> glDrawTransformFeedback;

        /// <summary>void glDrawTransformFeedbackStream(GLenum mode, GLuint id, GLuint stream)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLtransformfeedback, GLuint, void> glDrawTransformFeedbackStream;

        /// <summary>void glEndQueryIndexed(GLenum target, GLuint index)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, GLuint, void> glEndQueryIndexed;

#if !GL_ES_VERSION_3_0

        /// <summary>void glGenTransformFeedbacks(GLsizei n, GLuint* ids)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLtransformfeedback*, void> glGenTransformFeedbacks;

#endif

        /// <summary>void glGetActiveSubroutineName(GLuint program, GLenum shadertype, GLuint index, GLsizei bufSize, GLsizei* length, GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ShaderType, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetActiveSubroutineName;

        /// <summary>void glGetActiveSubroutineUniformName(GLuint program, GLenum shadertype, GLuint index, GLsizei bufSize, GLsizei* length, GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ShaderType, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetActiveSubroutineUniformName;

        /// <summary>void glGetActiveSubroutineUniformiv(GLuint program, GLenum shadertype, GLuint index, GLenum pname, GLint* values)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ShaderType, GLuint, SubroutineParameterName, GLint*, void> glGetActiveSubroutineUniformiv;

        /// <summary>void glGetProgramStageiv(GLuint program, GLenum shadertype, GLenum pname, GLint* values)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ShaderType, ProgramStagePName, GLint*, void> glGetProgramStageiv;

        /// <summary>void glGetQueryIndexediv(GLenum target, GLuint index, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, GLuint, QueryParameterName, GLint*, void> glGetQueryIndexediv;

        /// <summary>GLuint glGetSubroutineIndex(GLuint program, GLenum shadertype, const GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ShaderType, GLchar*, GLuint> glGetSubroutineIndex;

        /// <summary>GLint glGetSubroutineUniformLocation(GLuint program, GLenum shadertype, const GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ShaderType, GLchar*, GLint> glGetSubroutineUniformLocation;

        /// <summary>void glGetUniformSubroutineuiv(GLenum shadertype, GLint location, GLuint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, GLint, GLuint*, void> glGetUniformSubroutineuiv;

        /// <summary>void glGetUniformdv(GLuint program, GLint location, GLdouble* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLdouble*, void> glGetUniformdv;

#if !GL_ES_VERSION_3_0

        /// <summary>GLboolean glIsTransformFeedback(GLuint id)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtransformfeedback, GLboolean> glIsTransformFeedback;

#endif

#if !GL_ES_VERSION_3_2

        /// <summary>void glMinSampleShading(GLfloat value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glMinSampleShading;

#endif

        /// <summary>void glPatchParameterfv(GLenum pname, const GLfloat* values)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PatchParameterName, GLfloat*, void> glPatchParameterfv;

#if !GL_ES_VERSION_3_2

        /// <summary>void glPatchParameteri(GLenum pname, GLint value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PatchParameterName, GLint, void> glPatchParameteri;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glPauseTransformFeedback()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPauseTransformFeedback;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glResumeTransformFeedback()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glResumeTransformFeedback;

#endif

        /// <summary>void glUniform1d(GLint location, GLdouble x)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLdouble, void> glUniform1d;

        /// <summary>void glUniform1dv(GLint location, GLsizei count, const GLdouble* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLdouble*, void> glUniform1dv;

        /// <summary>void glUniform2d(GLint location, GLdouble x, GLdouble y)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLdouble, GLdouble, void> glUniform2d;

        /// <summary>void glUniform2dv(GLint location, GLsizei count, const GLdouble* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLdouble*, void> glUniform2dv;

        /// <summary>void glUniform3d(GLint location, GLdouble x, GLdouble y, GLdouble z)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLdouble, GLdouble, GLdouble, void> glUniform3d;

        /// <summary>void glUniform3dv(GLint location, GLsizei count, const GLdouble* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLdouble*, void> glUniform3dv;

        /// <summary>void glUniform4d(GLint location, GLdouble x, GLdouble y, GLdouble z, GLdouble w)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLdouble, GLdouble, GLdouble, GLdouble, void> glUniform4d;

        /// <summary>void glUniform4dv(GLint location, GLsizei count, const GLdouble* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLdouble*, void> glUniform4dv;

        /// <summary>void glUniformMatrix2dv(GLint location, GLsizei count, GLboolean transpose, const GLdouble* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix2dv;

        /// <summary>void glUniformMatrix2x3dv(GLint location, GLsizei count, GLboolean transpose, const GLdouble* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix2x3dv;

        /// <summary>void glUniformMatrix2x4dv(GLint location, GLsizei count, GLboolean transpose, const GLdouble* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix2x4dv;

        /// <summary>void glUniformMatrix3dv(GLint location, GLsizei count, GLboolean transpose, const GLdouble* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix3dv;

        /// <summary>void glUniformMatrix3x2dv(GLint location, GLsizei count, GLboolean transpose, const GLdouble* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix3x2dv;

        /// <summary>void glUniformMatrix3x4dv(GLint location, GLsizei count, GLboolean transpose, const GLdouble* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix3x4dv;

        /// <summary>void glUniformMatrix4dv(GLint location, GLsizei count, GLboolean transpose, const GLdouble* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix4dv;

        /// <summary>void glUniformMatrix4x2dv(GLint location, GLsizei count, GLboolean transpose, const GLdouble* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix4x2dv;

        /// <summary>void glUniformMatrix4x3dv(GLint location, GLsizei count, GLboolean transpose, const GLdouble* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix4x3dv;

        /// <summary>void glUniformSubroutinesuiv(GLenum shadertype, GLsizei count, const GLuint* indices)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, GLsizei, GLuint*, void> glUniformSubroutinesuiv;
    }
}
#endif