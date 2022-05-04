#if (GL_VERSION_2_0 && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_SC_VERSION_2_0)
        /// <summary>void glAttachShader(GLuint program, GLuint shader);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, shader, void> glAttachShader;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBindAttribLocation(GLuint program, GLuint index, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLuint, GLchar*, void> glBindAttribLocation;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBlendEquationSeparate(GLenum modeRGB, GLenum modeAlpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendEquationModeEXT, BlendEquationModeEXT, void> glBlendEquationSeparate;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glCompileShader(GLuint shader);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<shader, void> glCompileShader;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLuint glCreateProgram();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program> glCreateProgram;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLuint glCreateShader(GLenum type);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, shader> glCreateShader;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDeleteProgram(GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, void> glDeleteProgram;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDeleteShader(GLuint shader);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<shader, void> glDeleteShader;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDetachShader(GLuint program, GLuint shader);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, shader, void> glDetachShader;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDisableVertexAttribArray(GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glDisableVertexAttribArray;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDrawBuffers(GLsizei n, GLenum* bufs);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, DrawBufferMode*, void> glDrawBuffers;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glEnableVertexAttribArray(GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glEnableVertexAttribArray;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetActiveAttrib(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLint* size, GLenum* type, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLuint, GLsizei, GLsizei*, GLint*, AttributeType*, GLchar*, void> glGetActiveAttrib;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetActiveUniform(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLint* size, GLenum* type, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLuint, GLsizei, GLsizei*, GLint*, UniformType*, GLchar*, void> glGetActiveUniform;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetAttachedShaders(GLuint program, GLsizei maxCount, GLsizei* count, GLuint* shaders);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLsizei, GLsizei*, shader*, void> glGetAttachedShaders;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLint glGetAttribLocation(GLuint program, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLchar*, GLint> glGetAttribLocation;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetProgramInfoLog(GLuint program, GLsizei bufSize, GLsizei* length, GLchar* infoLog);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLsizei, GLsizei*, GLchar*, void> glGetProgramInfoLog;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetProgramiv(GLuint program, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramPropertyARB, GLint*, void> glGetProgramiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetShaderInfoLog(GLuint shader, GLsizei bufSize, GLsizei* length, GLchar* infoLog);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<shader, GLsizei, GLsizei*, GLchar*, void> glGetShaderInfoLog;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetShaderiv(GLuint shader, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<shader, ShaderParameterName, GLint*, void> glGetShaderiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetShaderSource(GLuint shader, GLsizei bufSize, GLsizei* length, GLchar* source);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<shader, GLsizei, GLsizei*, GLchar*, void> glGetShaderSource;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetUniformfv(GLuint program, GLint location, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLfloat*, void> glGetUniformfv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetUniformiv(GLuint program, GLint location, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLint*, void> glGetUniformiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLint glGetUniformLocation(GLuint program, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLchar*, GLint> glGetUniformLocation;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetVertexAttribdv(GLuint index, GLenum pname, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPropertyARB, GLdouble*, void> glGetVertexAttribdv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetVertexAttribfv(GLuint index, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPropertyARB, GLfloat*, void> glGetVertexAttribfv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetVertexAttribiv(GLuint index, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPropertyARB, GLint*, void> glGetVertexAttribiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetVertexAttribPointerv(GLuint index, GLenum pname, void** pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerPropertyARB, void**, void> glGetVertexAttribPointerv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLboolean glIsProgram(GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLboolean> glIsProgram;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLboolean glIsShader(GLuint shader);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<shader, GLboolean> glIsShader;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glLinkProgram(GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, void> glLinkProgram;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glShaderSource(GLuint shader, GLsizei count, GLchar** string, GLint* length);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<shader, GLsizei, GLchar**, GLint*, void> glShaderSource;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glStencilFuncSeparate(GLenum face, GLenum func, GLint ref, GLuint mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFaceDirection, StencilFunction, GLint, GLuint, void> glStencilFuncSeparate;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glStencilMaskSeparate(GLenum face, GLuint mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFaceDirection, GLuint, void> glStencilMaskSeparate;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glStencilOpSeparate(GLenum face, GLenum sfail, GLenum dpfail, GLenum dppass);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFaceDirection, StencilOp, StencilOp, StencilOp, void> glStencilOpSeparate;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform1f(GLint location, GLfloat v0);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, void> glUniform1f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform1fv(GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLfloat*, void> glUniform1fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform1i(GLint location, GLint v0);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, void> glUniform1i;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform1iv(GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint*, void> glUniform1iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform2f(GLint location, GLfloat v0, GLfloat v1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, GLfloat, void> glUniform2f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform2fv(GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLfloat*, void> glUniform2fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform2i(GLint location, GLint v0, GLint v1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, void> glUniform2i;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform2iv(GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint*, void> glUniform2iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform3f(GLint location, GLfloat v0, GLfloat v1, GLfloat v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, GLfloat, GLfloat, void> glUniform3f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform3fv(GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLfloat*, void> glUniform3fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform3i(GLint location, GLint v0, GLint v1, GLint v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, void> glUniform3i;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform3iv(GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint*, void> glUniform3iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform4f(GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, GLfloat, GLfloat, GLfloat, void> glUniform4f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform4fv(GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLfloat*, void> glUniform4fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform4i(GLint location, GLint v0, GLint v1, GLint v2, GLint v3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, GLint, void> glUniform4i;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniform4iv(GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint*, void> glUniform4iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniformMatrix2fv(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix2fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniformMatrix3fv(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix3fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUniformMatrix4fv(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix4fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glUseProgram(GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, void> glUseProgram;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glValidateProgram(GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, void> glValidateProgram;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib1d(GLuint index, GLdouble x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, void> glVertexAttrib1d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib1dv(GLuint index, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttrib1dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib1f(GLuint index, GLfloat x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, void> glVertexAttrib1f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib1fv(GLuint index, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib1fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib1s(GLuint index, GLshort x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort, void> glVertexAttrib1s;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib1sv(GLuint index, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVertexAttrib1sv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib2d(GLuint index, GLdouble x, GLdouble y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, void> glVertexAttrib2d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib2dv(GLuint index, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttrib2dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib2f(GLuint index, GLfloat x, GLfloat y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, void> glVertexAttrib2f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib2fv(GLuint index, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib2fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib2s(GLuint index, GLshort x, GLshort y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort, GLshort, void> glVertexAttrib2s;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib2sv(GLuint index, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVertexAttrib2sv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib3d(GLuint index, GLdouble x, GLdouble y, GLdouble z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, GLdouble, void> glVertexAttrib3d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib3dv(GLuint index, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttrib3dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib3f(GLuint index, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, void> glVertexAttrib3f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib3fv(GLuint index, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib3fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib3s(GLuint index, GLshort x, GLshort y, GLshort z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort, GLshort, GLshort, void> glVertexAttrib3s;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib3sv(GLuint index, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVertexAttrib3sv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib4bv(GLuint index, GLbyte* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLbyte*, void> glVertexAttrib4bv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib4d(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, GLdouble, GLdouble, void> glVertexAttrib4d;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib4dv(GLuint index, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttrib4dv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib4f(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, GLfloat, void> glVertexAttrib4f;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib4fv(GLuint index, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib4fv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib4iv(GLuint index, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glVertexAttrib4iv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib4Nbv(GLuint index, GLbyte* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLbyte*, void> glVertexAttrib4Nbv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib4Niv(GLuint index, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glVertexAttrib4Niv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib4Nsv(GLuint index, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVertexAttrib4Nsv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib4Nub(GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLubyte, GLubyte, GLubyte, GLubyte, void> glVertexAttrib4Nub;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib4Nubv(GLuint index, GLubyte* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLubyte*, void> glVertexAttrib4Nubv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib4Nuiv(GLuint index, GLuint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glVertexAttrib4Nuiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib4Nusv(GLuint index, GLushort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLushort*, void> glVertexAttrib4Nusv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib4s(GLuint index, GLshort x, GLshort y, GLshort z, GLshort w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort, GLshort, GLshort, GLshort, void> glVertexAttrib4s;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib4sv(GLuint index, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVertexAttrib4sv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib4ubv(GLuint index, GLubyte* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLubyte*, void> glVertexAttrib4ubv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib4uiv(GLuint index, GLuint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glVertexAttrib4uiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttrib4usv(GLuint index, GLushort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLushort*, void> glVertexAttrib4usv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribPointer(GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribPointerType, GLboolean, GLsizei, void*, void> glVertexAttribPointer;
#endif
    }
}
#endif