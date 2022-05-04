#if (GL_EXT_vertex_attrib_64bit && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetVertexAttribLdvEXT(GLuint index, GLenum pname, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribEnum, GLdouble*, void> glGetVertexAttribLdvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribL1dEXT(GLuint index, GLdouble x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, void> glVertexAttribL1dEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribL1dvEXT(GLuint index, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttribL1dvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribL2dEXT(GLuint index, GLdouble x, GLdouble y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, void> glVertexAttribL2dEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribL2dvEXT(GLuint index, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttribL2dvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribL3dEXT(GLuint index, GLdouble x, GLdouble y, GLdouble z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, GLdouble, void> glVertexAttribL3dEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribL3dvEXT(GLuint index, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttribL3dvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribL4dEXT(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, GLdouble, GLdouble, void> glVertexAttribL4dEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribL4dvEXT(GLuint index, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttribL4dvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribLPointerEXT(GLuint index, GLint size, GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribLType, GLsizei, void*, void> glVertexAttribLPointerEXT;
#endif
    }
}
#endif