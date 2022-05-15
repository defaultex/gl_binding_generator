public partial class gl { 
    public partial class Functions { 

        /// <summary>void glBeginQueryIndexed(GLenum target, GLuint index, GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, GLuint, GLquery, void> glBeginQueryIndexed;

        /// <summary>void glBindTransformFeedback(GLenum target, GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BindTransformFeedbackTarget, GLtransformfeedback, void> glBindTransformFeedback;

        /// <summary>void glBlendEquationi(GLuint buf, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendEquationMode, void> glBlendEquationi;

        /// <summary>void glBlendEquationSeparatei(GLuint buf, GLenum modeRGB, GLenum modeAlpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendEquationMode, BlendEquationMode, void> glBlendEquationSeparatei;

        /// <summary>void glBlendFunci(GLuint buf, GLenum src, GLenum dst);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendingFactor, BlendingFactor, void> glBlendFunci;

        /// <summary>void glBlendFuncSeparatei(GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void> glBlendFuncSeparatei;

        /// <summary>void glDeleteTransformFeedbacks(GLsizei n, GLuint* ids);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLtransformfeedback*, void> glDeleteTransformFeedbacks;

        /// <summary>void glDrawArraysIndirect(GLenum mode, void* indirect);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void*, void> glDrawArraysIndirect;

        /// <summary>void glDrawElementsIndirect(GLenum mode, GLenum type, void* indirect);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, ElementType, void*, void> glDrawElementsIndirect;

        /// <summary>void glDrawTransformFeedback(GLenum mode, GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLtransformfeedback, void> glDrawTransformFeedback;

        /// <summary>void glDrawTransformFeedbackStream(GLenum mode, GLuint id, GLuint stream);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLtransformfeedback, GLuint, void> glDrawTransformFeedbackStream;

        /// <summary>void glEndQueryIndexed(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, GLuint, void> glEndQueryIndexed;

        /// <summary>void glGenTransformFeedbacks(GLsizei n, GLuint* ids);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLtransformfeedback*, void> glGenTransformFeedbacks;

        /// <summary>void glGetActiveSubroutineName(GLuint program, GLenum shadertype, GLuint index, GLsizei bufSize, GLsizei* length, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ShaderType, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetActiveSubroutineName;

        /// <summary>void glGetActiveSubroutineUniformiv(GLuint program, GLenum shadertype, GLuint index, GLenum pname, GLint* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ShaderType, GLuint, SubroutineParameter, GLint*, void> glGetActiveSubroutineUniformiv;

        /// <summary>void glGetActiveSubroutineUniformName(GLuint program, GLenum shadertype, GLuint index, GLsizei bufSize, GLsizei* length, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ShaderType, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetActiveSubroutineUniformName;

        /// <summary>void glGetProgramStageiv(GLuint program, GLenum shadertype, GLenum pname, GLint* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ShaderType, ProgramStageParameter, GLint*, void> glGetProgramStageiv;

        /// <summary>void glGetQueryIndexediv(GLenum target, GLuint index, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, GLuint, QueryParameter, GLint*, void> glGetQueryIndexediv;

        /// <summary>GLuint glGetSubroutineIndex(GLuint program, GLenum shadertype, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ShaderType, GLchar*, GLuint> glGetSubroutineIndex;

        /// <summary>GLint glGetSubroutineUniformLocation(GLuint program, GLenum shadertype, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ShaderType, GLchar*, GLint> glGetSubroutineUniformLocation;

        /// <summary>void glGetUniformdv(GLuint program, GLint location, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLdouble*, void> glGetUniformdv;

        /// <summary>void glGetUniformSubroutineuiv(GLenum shadertype, GLint location, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, GLint, GLuint*, void> glGetUniformSubroutineuiv;

        /// <summary>GLboolean glIsTransformFeedback(GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtransformfeedback, GLboolean> glIsTransformFeedback;

        /// <summary>void glMinSampleShading(GLfloat value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glMinSampleShading;

        /// <summary>void glPatchParameterfv(GLenum pname, GLfloat* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PatchParameter, GLfloat*, void> glPatchParameterfv;

        /// <summary>void glPatchParameteri(GLenum pname, GLint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PatchParameter, GLint, void> glPatchParameteri;

        /// <summary>void glPauseTransformFeedback();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPauseTransformFeedback;

        /// <summary>void glResumeTransformFeedback();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glResumeTransformFeedback;

        /// <summary>void glUniform1d(GLint location, GLdouble x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLdouble, void> glUniform1d;

        /// <summary>void glUniform1dv(GLint location, GLsizei count, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLdouble*, void> glUniform1dv;

        /// <summary>void glUniform2d(GLint location, GLdouble x, GLdouble y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLdouble, GLdouble, void> glUniform2d;

        /// <summary>void glUniform2dv(GLint location, GLsizei count, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLdouble*, void> glUniform2dv;

        /// <summary>void glUniform3d(GLint location, GLdouble x, GLdouble y, GLdouble z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLdouble, GLdouble, GLdouble, void> glUniform3d;

        /// <summary>void glUniform3dv(GLint location, GLsizei count, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLdouble*, void> glUniform3dv;

        /// <summary>void glUniform4d(GLint location, GLdouble x, GLdouble y, GLdouble z, GLdouble w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLdouble, GLdouble, GLdouble, GLdouble, void> glUniform4d;

        /// <summary>void glUniform4dv(GLint location, GLsizei count, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLdouble*, void> glUniform4dv;

        /// <summary>void glUniformMatrix2dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix2dv;

        /// <summary>void glUniformMatrix2x3dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix2x3dv;

        /// <summary>void glUniformMatrix2x4dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix2x4dv;

        /// <summary>void glUniformMatrix3dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix3dv;

        /// <summary>void glUniformMatrix3x2dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix3x2dv;

        /// <summary>void glUniformMatrix3x4dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix3x4dv;

        /// <summary>void glUniformMatrix4dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix4dv;

        /// <summary>void glUniformMatrix4x2dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix4x2dv;

        /// <summary>void glUniformMatrix4x3dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLdouble*, void> glUniformMatrix4x3dv;

        /// <summary>void glUniformSubroutinesuiv(GLenum shadertype, GLsizei count, GLuint* indices);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, GLsizei, GLuint*, void> glUniformSubroutinesuiv;
    }
}
