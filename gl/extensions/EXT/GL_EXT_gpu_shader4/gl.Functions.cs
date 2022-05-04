#if (GL_EXT_gpu_shader4 && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBindFragDataLocationEXT(GLuint program, GLuint color, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLuint, GLchar*, void> glBindFragDataLocationEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLint glGetFragDataLocationEXT(GLuint program, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLchar*, GLint> glGetFragDataLocationEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetUniformuivEXT(GLuint program, GLint location, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLuint*, void> glGetUniformuivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetVertexAttribIivEXT(GLuint index, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribEnum, GLint*, void> glGetVertexAttribIivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetVertexAttribIuivEXT(GLuint index, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribEnum, GLuint*, void> glGetVertexAttribIuivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform1uiEXT(GLint location, GLuint v0);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint, void> glUniform1uiEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform1uivEXT(GLint location, GLsizei count, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint*, void> glUniform1uivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform2uiEXT(GLint location, GLuint v0, GLuint v1);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint, GLuint, void> glUniform2uiEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform2uivEXT(GLint location, GLsizei count, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint*, void> glUniform2uivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform3uiEXT(GLint location, GLuint v0, GLuint v1, GLuint v2);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint, GLuint, GLuint, void> glUniform3uiEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform3uivEXT(GLint location, GLsizei count, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint*, void> glUniform3uivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform4uiEXT(GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint, GLuint, GLuint, GLuint, void> glUniform4uiEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniform4uivEXT(GLint location, GLsizei count, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint*, void> glUniform4uivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribI1iEXT(GLuint index, GLint x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, void> glVertexAttribI1iEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribI1ivEXT(GLuint index, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glVertexAttribI1ivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribI1uiEXT(GLuint index, GLuint x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glVertexAttribI1uiEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribI1uivEXT(GLuint index, GLuint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glVertexAttribI1uivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribI2iEXT(GLuint index, GLint x, GLint y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, GLint, void> glVertexAttribI2iEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribI2ivEXT(GLuint index, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glVertexAttribI2ivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribI2uiEXT(GLuint index, GLuint x, GLuint y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, void> glVertexAttribI2uiEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribI2uivEXT(GLuint index, GLuint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glVertexAttribI2uivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribI3iEXT(GLuint index, GLint x, GLint y, GLint z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, GLint, GLint, void> glVertexAttribI3iEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribI3ivEXT(GLuint index, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glVertexAttribI3ivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribI3uiEXT(GLuint index, GLuint x, GLuint y, GLuint z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, GLuint, void> glVertexAttribI3uiEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribI3uivEXT(GLuint index, GLuint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glVertexAttribI3uivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribI4bvEXT(GLuint index, GLbyte* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLbyte*, void> glVertexAttribI4bvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribI4iEXT(GLuint index, GLint x, GLint y, GLint z, GLint w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, GLint, GLint, GLint, void> glVertexAttribI4iEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribI4ivEXT(GLuint index, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glVertexAttribI4ivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribI4svEXT(GLuint index, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVertexAttribI4svEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribI4ubvEXT(GLuint index, GLubyte* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLubyte*, void> glVertexAttribI4ubvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribI4uiEXT(GLuint index, GLuint x, GLuint y, GLuint z, GLuint w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, GLuint, GLuint, void> glVertexAttribI4uiEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribI4uivEXT(GLuint index, GLuint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glVertexAttribI4uivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribI4usvEXT(GLuint index, GLushort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLushort*, void> glVertexAttribI4usvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribIPointerEXT(GLuint index, GLint size, GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribIType, GLsizei, void*, void> glVertexAttribIPointerEXT;
#endif
    }
}
#endif