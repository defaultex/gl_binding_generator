#if (GL_ARB_vertex_shader && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBindAttribLocationARB(GLhandleARB programObj, GLuint index, GLcharARB* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, GLuint, GLcharARB*, void> glBindAttribLocationARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDisableVertexAttribArrayARB(GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glDisableVertexAttribArrayARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEnableVertexAttribArrayARB(GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glEnableVertexAttribArrayARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetActiveAttribARB(GLhandleARB programObj, GLuint index, GLsizei maxLength, GLsizei* length, GLint* size, GLenum* type, GLcharARB* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, GLuint, GLsizei, GLsizei*, GLint*, AttributeType*, GLcharARB*, void> glGetActiveAttribARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLint glGetAttribLocationARB(GLhandleARB programObj, GLcharARB* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLhandleARB, GLcharARB*, GLint> glGetAttribLocationARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetVertexAttribdvARB(GLuint index, GLenum pname, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPropertyARB, GLdouble*, void> glGetVertexAttribdvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetVertexAttribfvARB(GLuint index, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPropertyARB, GLfloat*, void> glGetVertexAttribfvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetVertexAttribivARB(GLuint index, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPropertyARB, GLint*, void> glGetVertexAttribivARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetVertexAttribPointervARB(GLuint index, GLenum pname, void** pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerPropertyARB, void**, void> glGetVertexAttribPointervARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib1dARB(GLuint index, GLdouble x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, void> glVertexAttrib1dARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib1dvARB(GLuint index, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttrib1dvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib1fARB(GLuint index, GLfloat x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, void> glVertexAttrib1fARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib1fvARB(GLuint index, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib1fvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib1sARB(GLuint index, GLshort x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort, void> glVertexAttrib1sARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib1svARB(GLuint index, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVertexAttrib1svARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib2dARB(GLuint index, GLdouble x, GLdouble y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, void> glVertexAttrib2dARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib2dvARB(GLuint index, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttrib2dvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib2fARB(GLuint index, GLfloat x, GLfloat y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, void> glVertexAttrib2fARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib2fvARB(GLuint index, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib2fvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib2sARB(GLuint index, GLshort x, GLshort y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort, GLshort, void> glVertexAttrib2sARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib2svARB(GLuint index, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVertexAttrib2svARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib3dARB(GLuint index, GLdouble x, GLdouble y, GLdouble z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, GLdouble, void> glVertexAttrib3dARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib3dvARB(GLuint index, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttrib3dvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib3fARB(GLuint index, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, void> glVertexAttrib3fARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib3fvARB(GLuint index, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib3fvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib3sARB(GLuint index, GLshort x, GLshort y, GLshort z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort, GLshort, GLshort, void> glVertexAttrib3sARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib3svARB(GLuint index, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVertexAttrib3svARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib4bvARB(GLuint index, GLbyte* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLbyte*, void> glVertexAttrib4bvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib4dARB(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, GLdouble, GLdouble, void> glVertexAttrib4dARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib4dvARB(GLuint index, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttrib4dvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib4fARB(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, GLfloat, void> glVertexAttrib4fARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib4fvARB(GLuint index, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib4fvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib4ivARB(GLuint index, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glVertexAttrib4ivARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib4NbvARB(GLuint index, GLbyte* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLbyte*, void> glVertexAttrib4NbvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib4NivARB(GLuint index, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glVertexAttrib4NivARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib4NsvARB(GLuint index, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVertexAttrib4NsvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib4NubARB(GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLubyte, GLubyte, GLubyte, GLubyte, void> glVertexAttrib4NubARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib4NubvARB(GLuint index, GLubyte* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLubyte*, void> glVertexAttrib4NubvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib4NuivARB(GLuint index, GLuint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glVertexAttrib4NuivARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib4NusvARB(GLuint index, GLushort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLushort*, void> glVertexAttrib4NusvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib4sARB(GLuint index, GLshort x, GLshort y, GLshort z, GLshort w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort, GLshort, GLshort, GLshort, void> glVertexAttrib4sARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib4svARB(GLuint index, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVertexAttrib4svARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib4ubvARB(GLuint index, GLubyte* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLubyte*, void> glVertexAttrib4ubvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib4uivARB(GLuint index, GLuint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint*, void> glVertexAttrib4uivARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib4usvARB(GLuint index, GLushort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLushort*, void> glVertexAttrib4usvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribPointerARB(GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribPointerType, GLboolean, GLsizei, void*, void> glVertexAttribPointerARB;
#endif
    }
}
#endif