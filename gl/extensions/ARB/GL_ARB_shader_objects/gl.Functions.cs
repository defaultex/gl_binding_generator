#if (GL_ARB_shader_objects && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glAttachObjectARB(GLhandleARB containerObj, GLhandleARB obj);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, GLhandleARB, void> glAttachObjectARB;

        /// <summary>void glCompileShaderARB(GLhandleARB shaderObj);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, void> glCompileShaderARB;

        /// <summary>GLhandleARB glCreateProgramObjectARB();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB> glCreateProgramObjectARB;

        /// <summary>GLhandleARB glCreateShaderObjectARB(GLenum shaderType);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, GLhandleARB> glCreateShaderObjectARB;

        /// <summary>void glDeleteObjectARB(GLhandleARB obj);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, void> glDeleteObjectARB;

        /// <summary>void glDetachObjectARB(GLhandleARB containerObj, GLhandleARB attachedObj);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, GLhandleARB, void> glDetachObjectARB;

        /// <summary>void glGetActiveUniformARB(GLhandleARB programObj, GLuint index, GLsizei maxLength, GLsizei* length, GLint* size, GLenum* type, GLcharARB* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, GLuint, GLsizei, GLsizei*, GLint*, UniformType*, GLcharARB*, void> glGetActiveUniformARB;

        /// <summary>void glGetAttachedObjectsARB(GLhandleARB containerObj, GLsizei maxCount, GLsizei* count, GLhandleARB* obj);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, GLsizei, GLsizei*, GLhandleARB*, void> glGetAttachedObjectsARB;

        /// <summary>GLhandleARB glGetHandleARB(GLenum pname);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLhandleARB> glGetHandleARB;

        /// <summary>void glGetInfoLogARB(GLhandleARB obj, GLsizei maxLength, GLsizei* length, GLcharARB* infoLog);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, GLsizei, GLsizei*, GLcharARB*, void> glGetInfoLogARB;

        /// <summary>void glGetObjectParameterfvARB(GLhandleARB obj, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, GLenum, GLfloat*, void> glGetObjectParameterfvARB;

        /// <summary>void glGetObjectParameterivARB(GLhandleARB obj, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, GLenum, GLint*, void> glGetObjectParameterivARB;

        /// <summary>void glGetShaderSourceARB(GLhandleARB obj, GLsizei maxLength, GLsizei* length, GLcharARB* source);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, GLsizei, GLsizei*, GLcharARB*, void> glGetShaderSourceARB;

        /// <summary>void glGetUniformfvARB(GLhandleARB programObj, GLint location, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, GLint, GLfloat*, void> glGetUniformfvARB;

        /// <summary>void glGetUniformivARB(GLhandleARB programObj, GLint location, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, GLint, GLint*, void> glGetUniformivARB;

        /// <summary>GLint glGetUniformLocationARB(GLhandleARB programObj, GLcharARB* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, GLcharARB*, GLint> glGetUniformLocationARB;

        /// <summary>void glLinkProgramARB(GLhandleARB programObj);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, void> glLinkProgramARB;

        /// <summary>void glShaderSourceARB(GLhandleARB shaderObj, GLsizei count, GLcharARB** string, GLint* length);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, GLsizei, GLcharARB**, GLint*, void> glShaderSourceARB;

        /// <summary>void glUniform1fARB(GLint location, GLfloat v0);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, void> glUniform1fARB;

        /// <summary>void glUniform1fvARB(GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLfloat*, void> glUniform1fvARB;

        /// <summary>void glUniform1iARB(GLint location, GLint v0);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, void> glUniform1iARB;

        /// <summary>void glUniform1ivARB(GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint*, void> glUniform1ivARB;

        /// <summary>void glUniform2fARB(GLint location, GLfloat v0, GLfloat v1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, GLfloat, void> glUniform2fARB;

        /// <summary>void glUniform2fvARB(GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLfloat*, void> glUniform2fvARB;

        /// <summary>void glUniform2iARB(GLint location, GLint v0, GLint v1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, void> glUniform2iARB;

        /// <summary>void glUniform2ivARB(GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint*, void> glUniform2ivARB;

        /// <summary>void glUniform3fARB(GLint location, GLfloat v0, GLfloat v1, GLfloat v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, GLfloat, GLfloat, void> glUniform3fARB;

        /// <summary>void glUniform3fvARB(GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLfloat*, void> glUniform3fvARB;

        /// <summary>void glUniform3iARB(GLint location, GLint v0, GLint v1, GLint v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, void> glUniform3iARB;

        /// <summary>void glUniform3ivARB(GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint*, void> glUniform3ivARB;

        /// <summary>void glUniform4fARB(GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, GLfloat, GLfloat, GLfloat, void> glUniform4fARB;

        /// <summary>void glUniform4fvARB(GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLfloat*, void> glUniform4fvARB;

        /// <summary>void glUniform4iARB(GLint location, GLint v0, GLint v1, GLint v2, GLint v3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, GLint, void> glUniform4iARB;

        /// <summary>void glUniform4ivARB(GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint*, void> glUniform4ivARB;

        /// <summary>void glUniformMatrix2fvARB(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix2fvARB;

        /// <summary>void glUniformMatrix3fvARB(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix3fvARB;

        /// <summary>void glUniformMatrix4fvARB(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix4fvARB;

        /// <summary>void glUseProgramObjectARB(GLhandleARB programObj);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, void> glUseProgramObjectARB;

        /// <summary>void glValidateProgramARB(GLhandleARB programObj);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, void> glValidateProgramARB;
    }
}
#endif