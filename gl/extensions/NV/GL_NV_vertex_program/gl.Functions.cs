#if (GL_NV_vertex_program && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glAreProgramsResidentNV(GLsizei n, GLuint* programs, GLboolean* residences);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, program*, GLboolean*, GLboolean> glAreProgramsResidentNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBindProgramNV(GLenum target, GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexAttribEnumNV, program, void> glBindProgramNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeleteProgramsNV(GLsizei n, GLuint* programs);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, program*, void> glDeleteProgramsNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glExecuteProgramNV(GLenum target, GLuint id, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexAttribEnumNV, GLuint, GLfloat*, void> glExecuteProgramNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGenProgramsNV(GLsizei n, GLuint* programs);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, program*, void> glGenProgramsNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetProgramivNV(GLuint id, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, VertexAttribEnumNV, GLint*, void> glGetProgramivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetProgramParameterdvNV(GLenum target, GLuint index, GLenum pname, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexAttribEnumNV, GLuint, VertexAttribEnumNV, GLdouble*, void> glGetProgramParameterdvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetProgramParameterfvNV(GLenum target, GLuint index, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexAttribEnumNV, GLuint, VertexAttribEnumNV, GLfloat*, void> glGetProgramParameterfvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetProgramStringNV(GLuint id, GLenum pname, GLubyte* program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, VertexAttribEnumNV, GLubyte*, void> glGetProgramStringNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetTrackMatrixivNV(GLenum target, GLuint address, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexAttribEnumNV, GLuint, VertexAttribEnumNV, GLint*, void> glGetTrackMatrixivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetVertexAttribdvNV(GLuint index, GLenum pname, GLdouble* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribEnumNV, GLdouble*, void> glGetVertexAttribdvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetVertexAttribfvNV(GLuint index, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribEnumNV, GLfloat*, void> glGetVertexAttribfvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetVertexAttribivNV(GLuint index, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribEnumNV, GLint*, void> glGetVertexAttribivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetVertexAttribPointervNV(GLuint index, GLenum pname, void** pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribEnumNV, void**, void> glGetVertexAttribPointervNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsProgramNV(GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLboolean> glIsProgramNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glLoadProgramNV(GLenum target, GLuint id, GLsizei len, GLubyte* program);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexAttribEnumNV, GLuint, GLsizei, GLubyte*, void> glLoadProgramNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramParameter4dNV(GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexAttribEnumNV, GLuint, GLdouble, GLdouble, GLdouble, GLdouble, void> glProgramParameter4dNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramParameter4dvNV(GLenum target, GLuint index, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexAttribEnumNV, GLuint, GLdouble*, void> glProgramParameter4dvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramParameter4fNV(GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexAttribEnumNV, GLuint, GLfloat, GLfloat, GLfloat, GLfloat, void> glProgramParameter4fNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramParameter4fvNV(GLenum target, GLuint index, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexAttribEnumNV, GLuint, GLfloat*, void> glProgramParameter4fvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramParameters4dvNV(GLenum target, GLuint index, GLsizei count, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexAttribEnumNV, GLuint, GLsizei, GLdouble*, void> glProgramParameters4dvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramParameters4fvNV(GLenum target, GLuint index, GLsizei count, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexAttribEnumNV, GLuint, GLsizei, GLfloat*, void> glProgramParameters4fvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glRequestResidentProgramsNV(GLsizei n, GLuint* programs);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, program*, void> glRequestResidentProgramsNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTrackMatrixNV(GLenum target, GLuint address, GLenum matrix, GLenum transform);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexAttribEnumNV, GLuint, VertexAttribEnumNV, VertexAttribEnumNV, void> glTrackMatrixNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib1dNV(GLuint index, GLdouble x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, void> glVertexAttrib1dNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib1dvNV(GLuint index, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttrib1dvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib1fNV(GLuint index, GLfloat x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, void> glVertexAttrib1fNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib1fvNV(GLuint index, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib1fvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib1sNV(GLuint index, GLshort x);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort, void> glVertexAttrib1sNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib1svNV(GLuint index, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVertexAttrib1svNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib2dNV(GLuint index, GLdouble x, GLdouble y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, void> glVertexAttrib2dNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib2dvNV(GLuint index, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttrib2dvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib2fNV(GLuint index, GLfloat x, GLfloat y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, void> glVertexAttrib2fNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib2fvNV(GLuint index, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib2fvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib2sNV(GLuint index, GLshort x, GLshort y);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort, GLshort, void> glVertexAttrib2sNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib2svNV(GLuint index, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVertexAttrib2svNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib3dNV(GLuint index, GLdouble x, GLdouble y, GLdouble z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, GLdouble, void> glVertexAttrib3dNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib3dvNV(GLuint index, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttrib3dvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib3fNV(GLuint index, GLfloat x, GLfloat y, GLfloat z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, void> glVertexAttrib3fNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib3fvNV(GLuint index, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib3fvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib3sNV(GLuint index, GLshort x, GLshort y, GLshort z);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort, GLshort, GLshort, void> glVertexAttrib3sNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib3svNV(GLuint index, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVertexAttrib3svNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib4dNV(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble, GLdouble, GLdouble, GLdouble, void> glVertexAttrib4dNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib4dvNV(GLuint index, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLdouble*, void> glVertexAttrib4dvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib4fNV(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, GLfloat, void> glVertexAttrib4fNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib4fvNV(GLuint index, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glVertexAttrib4fvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib4sNV(GLuint index, GLshort x, GLshort y, GLshort z, GLshort w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort, GLshort, GLshort, GLshort, void> glVertexAttrib4sNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib4svNV(GLuint index, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLshort*, void> glVertexAttrib4svNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib4ubNV(GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLubyte, GLubyte, GLubyte, GLubyte, void> glVertexAttrib4ubNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttrib4ubvNV(GLuint index, GLubyte* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLubyte*, void> glVertexAttrib4ubvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribPointerNV(GLuint index, GLint fsize, GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, VertexAttribEnumNV, GLsizei, void*, void> glVertexAttribPointerNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribs1dvNV(GLuint index, GLsizei count, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLdouble*, void> glVertexAttribs1dvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribs1fvNV(GLuint index, GLsizei count, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLfloat*, void> glVertexAttribs1fvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribs1svNV(GLuint index, GLsizei count, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLshort*, void> glVertexAttribs1svNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribs2dvNV(GLuint index, GLsizei count, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLdouble*, void> glVertexAttribs2dvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribs2fvNV(GLuint index, GLsizei count, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLfloat*, void> glVertexAttribs2fvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribs2svNV(GLuint index, GLsizei count, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLshort*, void> glVertexAttribs2svNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribs3dvNV(GLuint index, GLsizei count, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLdouble*, void> glVertexAttribs3dvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribs3fvNV(GLuint index, GLsizei count, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLfloat*, void> glVertexAttribs3fvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribs3svNV(GLuint index, GLsizei count, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLshort*, void> glVertexAttribs3svNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribs4dvNV(GLuint index, GLsizei count, GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLdouble*, void> glVertexAttribs4dvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribs4fvNV(GLuint index, GLsizei count, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLfloat*, void> glVertexAttribs4fvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribs4svNV(GLuint index, GLsizei count, GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLshort*, void> glVertexAttribs4svNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glVertexAttribs4ubvNV(GLuint index, GLsizei count, GLubyte* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLubyte*, void> glVertexAttribs4ubvNV;
#endif
    }
}
#endif