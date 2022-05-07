#if (GL_VERSION_2_0 && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glAttachShader(GLuint program, GLuint shader);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLshader, void> glAttachShader;

        /// <summary>void glBindAttribLocation(GLuint program, GLuint index, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLchar*, void> glBindAttribLocation;

        /// <summary>void glBlendEquationSeparate(GLenum modeRGB, GLenum modeAlpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendEquationModeEXT, BlendEquationModeEXT, void> glBlendEquationSeparate;

        /// <summary>void glCompileShader(GLuint shader);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshader, void> glCompileShader;

        /// <summary>GLuint glCreateProgram();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram> glCreateProgram;

        /// <summary>GLuint glCreateShader(GLenum type);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, GLshader> glCreateShader;

        /// <summary>void glDeleteProgram(GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, void> glDeleteProgram;

        /// <summary>void glDeleteShader(GLuint shader);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshader, void> glDeleteShader;

        /// <summary>void glDetachShader(GLuint program, GLuint shader);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLshader, void> glDetachShader;

        /// <summary>void glDisableVertexAttribArray(GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glDisableVertexAttribArray;

        /// <summary>void glDrawBuffers(GLsizei n, GLenum* bufs);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, DrawBufferMode*, void> glDrawBuffers;

        /// <summary>void glEnableVertexAttribArray(GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glEnableVertexAttribArray;

        /// <summary>void glGetActiveAttrib(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLint* size, GLenum* type, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLsizei, GLsizei*, GLint*, AttributeType*, GLchar*, void> glGetActiveAttrib;

        /// <summary>void glGetActiveUniform(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLint* size, GLenum* type, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLsizei, GLsizei*, GLint*, UniformType*, GLchar*, void> glGetActiveUniform;

        /// <summary>void glGetAttachedShaders(GLuint program, GLsizei maxCount, GLsizei* count, GLuint* shaders);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLsizei, GLsizei*, GLshader*, void> glGetAttachedShaders;

        /// <summary>GLint glGetAttribLocation(GLuint program, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLchar*, GLint> glGetAttribLocation;

        /// <summary>void glGetProgramInfoLog(GLuint program, GLsizei bufSize, GLsizei* length, GLchar* infoLog);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLsizei, GLsizei*, GLchar*, void> glGetProgramInfoLog;

        /// <summary>void glGetProgramiv(GLuint program, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, ProgramPropertyARB, GLint*, void> glGetProgramiv;

        /// <summary>void glGetShaderInfoLog(GLuint shader, GLsizei bufSize, GLsizei* length, GLchar* infoLog);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshader, GLsizei, GLsizei*, GLchar*, void> glGetShaderInfoLog;

        /// <summary>void glGetShaderiv(GLuint shader, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshader, ShaderParameterName, GLint*, void> glGetShaderiv;

        /// <summary>void glGetShaderSource(GLuint shader, GLsizei bufSize, GLsizei* length, GLchar* source);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshader, GLsizei, GLsizei*, GLchar*, void> glGetShaderSource;

        /// <summary>void glGetUniformfv(GLuint program, GLint location, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLfloat*, void> glGetUniformfv;

        /// <summary>void glGetUniformiv(GLuint program, GLint location, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLint*, void> glGetUniformiv;

        /// <summary>GLint glGetUniformLocation(GLuint program, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLchar*, GLint> glGetUniformLocation;

        /// <summary>void glGetVertexAttribdv(GLuint index, GLenum pname, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPropertyARB, GLdouble*, void> glGetVertexAttribdv;

        /// <summary>void glGetVertexAttribfv(GLuint index, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPropertyARB, GLfloat*, void> glGetVertexAttribfv;

        /// <summary>void glGetVertexAttribiv(GLuint index, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPropertyARB, GLint*, void> glGetVertexAttribiv;

        /// <summary>void glGetVertexAttribPointerv(GLuint index, GLenum pname, void** pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerPropertyARB, void**, void> glGetVertexAttribPointerv;

        /// <summary>GLboolean glIsProgram(GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLboolean> glIsProgram;

        /// <summary>GLboolean glIsShader(GLuint shader);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshader, GLboolean> glIsShader;

        /// <summary>void glLinkProgram(GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, void> glLinkProgram;

        /// <summary>void glShaderSource(GLuint shader, GLsizei count, GLchar** string, GLint* length);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshader, GLsizei, GLchar**, GLint*, void> glShaderSource;

        /// <summary>void glStencilFuncSeparate(GLenum face, GLenum func, GLint ref, GLuint mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFaceDirection, StencilFunction, GLint, GLuint, void> glStencilFuncSeparate;

        /// <summary>void glStencilMaskSeparate(GLenum face, GLuint mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFaceDirection, GLuint, void> glStencilMaskSeparate;

        /// <summary>void glStencilOpSeparate(GLenum face, GLenum sfail, GLenum dpfail, GLenum dppass);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<StencilFaceDirection, StencilOp, StencilOp, StencilOp, void> glStencilOpSeparate;

        /// <summary>void glUniform1f(GLint location, GLfloat v0);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, void> glUniform1f;

        /// <summary>void glUniform1fv(GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLfloat*, void> glUniform1fv;

        /// <summary>void glUniform1i(GLint location, GLint v0);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, void> glUniform1i;

        /// <summary>void glUniform1iv(GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint*, void> glUniform1iv;

        /// <summary>void glUniform2f(GLint location, GLfloat v0, GLfloat v1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, GLfloat, void> glUniform2f;

        /// <summary>void glUniform2fv(GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLfloat*, void> glUniform2fv;

        /// <summary>void glUniform2i(GLint location, GLint v0, GLint v1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, void> glUniform2i;

        /// <summary>void glUniform2iv(GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint*, void> glUniform2iv;

        /// <summary>void glUniform3f(GLint location, GLfloat v0, GLfloat v1, GLfloat v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, GLfloat, GLfloat, void> glUniform3f;

        /// <summary>void glUniform3fv(GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLfloat*, void> glUniform3fv;

        /// <summary>void glUniform3i(GLint location, GLint v0, GLint v1, GLint v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, void> glUniform3i;

        /// <summary>void glUniform3iv(GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint*, void> glUniform3iv;

        /// <summary>void glUniform4f(GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, GLfloat, GLfloat, GLfloat, void> glUniform4f;

        /// <summary>void glUniform4fv(GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLfloat*, void> glUniform4fv;

        /// <summary>void glUniform4i(GLint location, GLint v0, GLint v1, GLint v2, GLint v3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, GLint, void> glUniform4i;

        /// <summary>void glUniform4iv(GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint*, void> glUniform4iv;

        /// <summary>void glUniformMatrix2fv(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix2fv;

        /// <summary>void glUniformMatrix3fv(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix3fv;

        /// <summary>void glUniformMatrix4fv(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix4fv;

        /// <summary>void glUseProgram(GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, void> glUseProgram;

        /// <summary>void glValidateProgram(GLuint program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, void> glValidateProgram;

        /// <summary>void glVertexAttrib1d(GLuint index, GLdouble x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, void> glVertexAttrib1d;

        /// <summary>void glVertexAttrib1dv(GLuint index, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttrib1dv;

        /// <summary>void glVertexAttrib1f(GLuint index, GLfloat x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, void> glVertexAttrib1f;

        /// <summary>void glVertexAttrib1fv(GLuint index, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib1fv;

        /// <summary>void glVertexAttrib1s(GLuint index, GLshort x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort, void> glVertexAttrib1s;

        /// <summary>void glVertexAttrib1sv(GLuint index, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVertexAttrib1sv;

        /// <summary>void glVertexAttrib2d(GLuint index, GLdouble x, GLdouble y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, void> glVertexAttrib2d;

        /// <summary>void glVertexAttrib2dv(GLuint index, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttrib2dv;

        /// <summary>void glVertexAttrib2f(GLuint index, GLfloat x, GLfloat y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, void> glVertexAttrib2f;

        /// <summary>void glVertexAttrib2fv(GLuint index, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib2fv;

        /// <summary>void glVertexAttrib2s(GLuint index, GLshort x, GLshort y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort, GLshort, void> glVertexAttrib2s;

        /// <summary>void glVertexAttrib2sv(GLuint index, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVertexAttrib2sv;

        /// <summary>void glVertexAttrib3d(GLuint index, GLdouble x, GLdouble y, GLdouble z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, GLdouble, void> glVertexAttrib3d;

        /// <summary>void glVertexAttrib3dv(GLuint index, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttrib3dv;

        /// <summary>void glVertexAttrib3f(GLuint index, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, void> glVertexAttrib3f;

        /// <summary>void glVertexAttrib3fv(GLuint index, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib3fv;

        /// <summary>void glVertexAttrib3s(GLuint index, GLshort x, GLshort y, GLshort z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort, GLshort, GLshort, void> glVertexAttrib3s;

        /// <summary>void glVertexAttrib3sv(GLuint index, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVertexAttrib3sv;

        /// <summary>void glVertexAttrib4bv(GLuint index, GLbyte* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLbyte*, void> glVertexAttrib4bv;

        /// <summary>void glVertexAttrib4d(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, GLdouble, GLdouble, void> glVertexAttrib4d;

        /// <summary>void glVertexAttrib4dv(GLuint index, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttrib4dv;

        /// <summary>void glVertexAttrib4f(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, GLfloat, void> glVertexAttrib4f;

        /// <summary>void glVertexAttrib4fv(GLuint index, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib4fv;

        /// <summary>void glVertexAttrib4iv(GLuint index, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glVertexAttrib4iv;

        /// <summary>void glVertexAttrib4Nbv(GLuint index, GLbyte* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLbyte*, void> glVertexAttrib4Nbv;

        /// <summary>void glVertexAttrib4Niv(GLuint index, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glVertexAttrib4Niv;

        /// <summary>void glVertexAttrib4Nsv(GLuint index, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVertexAttrib4Nsv;

        /// <summary>void glVertexAttrib4Nub(GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLubyte, GLubyte, GLubyte, GLubyte, void> glVertexAttrib4Nub;

        /// <summary>void glVertexAttrib4Nubv(GLuint index, GLubyte* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLubyte*, void> glVertexAttrib4Nubv;

        /// <summary>void glVertexAttrib4Nuiv(GLuint index, GLuint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glVertexAttrib4Nuiv;

        /// <summary>void glVertexAttrib4Nusv(GLuint index, GLushort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLushort*, void> glVertexAttrib4Nusv;

        /// <summary>void glVertexAttrib4s(GLuint index, GLshort x, GLshort y, GLshort z, GLshort w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort, GLshort, GLshort, GLshort, void> glVertexAttrib4s;

        /// <summary>void glVertexAttrib4sv(GLuint index, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVertexAttrib4sv;

        /// <summary>void glVertexAttrib4ubv(GLuint index, GLubyte* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLubyte*, void> glVertexAttrib4ubv;

        /// <summary>void glVertexAttrib4uiv(GLuint index, GLuint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glVertexAttrib4uiv;

        /// <summary>void glVertexAttrib4usv(GLuint index, GLushort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLushort*, void> glVertexAttrib4usv;

        /// <summary>void glVertexAttribPointer(GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribPointerType, GLboolean, GLsizei, void*, void> glVertexAttribPointer;
    }
}
#endif