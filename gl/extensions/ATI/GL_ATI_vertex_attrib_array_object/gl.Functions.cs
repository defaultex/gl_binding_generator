#if (GL_ATI_vertex_attrib_array_object && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetVertexAttribArrayObjectfvATI(GLuint index, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ArrayObjectPNameATI, GLfloat*, void> glGetVertexAttribArrayObjectfvATI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetVertexAttribArrayObjectivATI(GLuint index, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ArrayObjectPNameATI, GLint*, void> glGetVertexAttribArrayObjectivATI;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribArrayObjectATI(GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, GLuint buffer, GLuint offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribPointerType, GLboolean, GLsizei, buffer, GLuint, void> glVertexAttribArrayObjectATI;
#endif
    }
}
#endif