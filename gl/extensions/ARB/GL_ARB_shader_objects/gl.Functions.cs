#if (GL_ARB_shader_objects && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glAttachObjectARB(GLhandleARB containerObj, GLhandleARB obj);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, GLhandleARB, void> glAttachObjectARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCompileShaderARB(GLhandleARB shaderObj);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, void> glCompileShaderARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLhandleARB glCreateProgramObjectARB();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB> glCreateProgramObjectARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLhandleARB glCreateShaderObjectARB(GLenum shaderType);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ShaderType, GLhandleARB> glCreateShaderObjectARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeleteObjectARB(GLhandleARB obj);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, void> glDeleteObjectARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDetachObjectARB(GLhandleARB containerObj, GLhandleARB attachedObj);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, GLhandleARB, void> glDetachObjectARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetActiveUniformARB(GLhandleARB programObj, GLuint index, GLsizei maxLength, GLsizei* length, GLint* size, GLenum* type, GLcharARB* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, GLuint, GLsizei, GLsizei*, GLint*, UniformType*, GLcharARB*, void> glGetActiveUniformARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetAttachedObjectsARB(GLhandleARB containerObj, GLsizei maxCount, GLsizei* count, GLhandleARB* obj);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, GLsizei, GLsizei*, GLhandleARB*, void> glGetAttachedObjectsARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLhandleARB glGetHandleARB(GLenum pname);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLhandleARB> glGetHandleARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetInfoLogARB(GLhandleARB obj, GLsizei maxLength, GLsizei* length, GLcharARB* infoLog);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, GLsizei, GLsizei*, GLcharARB*, void> glGetInfoLogARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetObjectParameterfvARB(GLhandleARB obj, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, GLenum, GLfloat*, void> glGetObjectParameterfvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetObjectParameterivARB(GLhandleARB obj, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, GLenum, GLint*, void> glGetObjectParameterivARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetShaderSourceARB(GLhandleARB obj, GLsizei maxLength, GLsizei* length, GLcharARB* source);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, GLsizei, GLsizei*, GLcharARB*, void> glGetShaderSourceARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetUniformfvARB(GLhandleARB programObj, GLint location, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, GLint, GLfloat*, void> glGetUniformfvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetUniformivARB(GLhandleARB programObj, GLint location, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, GLint, GLint*, void> glGetUniformivARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLint glGetUniformLocationARB(GLhandleARB programObj, GLcharARB* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, GLcharARB*, GLint> glGetUniformLocationARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glLinkProgramARB(GLhandleARB programObj);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, void> glLinkProgramARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glShaderSourceARB(GLhandleARB shaderObj, GLsizei count, GLcharARB** string, GLint* length);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, GLsizei, GLcharARB**, GLint*, void> glShaderSourceARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform1fARB(GLint location, GLfloat v0);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, void> glUniform1fARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform1fvARB(GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLfloat*, void> glUniform1fvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform1iARB(GLint location, GLint v0);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, void> glUniform1iARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform1ivARB(GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint*, void> glUniform1ivARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform2fARB(GLint location, GLfloat v0, GLfloat v1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, GLfloat, void> glUniform2fARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform2fvARB(GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLfloat*, void> glUniform2fvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform2iARB(GLint location, GLint v0, GLint v1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, void> glUniform2iARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform2ivARB(GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint*, void> glUniform2ivARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform3fARB(GLint location, GLfloat v0, GLfloat v1, GLfloat v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, GLfloat, GLfloat, void> glUniform3fARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform3fvARB(GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLfloat*, void> glUniform3fvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform3iARB(GLint location, GLint v0, GLint v1, GLint v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, void> glUniform3iARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform3ivARB(GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint*, void> glUniform3ivARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform4fARB(GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLfloat, GLfloat, GLfloat, GLfloat, void> glUniform4fARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform4fvARB(GLint location, GLsizei count, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLfloat*, void> glUniform4fvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform4iARB(GLint location, GLint v0, GLint v1, GLint v2, GLint v3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, GLint, GLint, void> glUniform4iARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform4ivARB(GLint location, GLsizei count, GLint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLint*, void> glUniform4ivARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniformMatrix2fvARB(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix2fvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniformMatrix3fvARB(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix3fvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniformMatrix4fvARB(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix4fvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUseProgramObjectARB(GLhandleARB programObj);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, void> glUseProgramObjectARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glValidateProgramARB(GLhandleARB programObj);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, void> glValidateProgramARB;
#endif
    }
}
#endif