#if (GL_OES_viewport_array && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDepthRangeArrayfvOES(GLuint first, GLsizei count, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLfloat*, void> glDepthRangeArrayfvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDepthRangeIndexedfOES(GLuint index, GLfloat n, GLfloat f);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, void> glDepthRangeIndexedfOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDisableiOES(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glDisableiOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEnableiOES(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glEnableiOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetFloati_vOES(GLenum target, GLuint index, GLfloat* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLfloat*, void> glGetFloati_vOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsEnablediOES(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, GLboolean> glIsEnablediOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glScissorArrayvOES(GLuint first, GLsizei count, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLint*, void> glScissorArrayvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glScissorIndexedOES(GLuint index, GLint left, GLint bottom, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, GLint, GLsizei, GLsizei, void> glScissorIndexedOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glScissorIndexedvOES(GLuint index, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glScissorIndexedvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glViewportArrayvOES(GLuint first, GLsizei count, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLfloat*, void> glViewportArrayvOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glViewportIndexedfOES(GLuint index, GLfloat x, GLfloat y, GLfloat w, GLfloat h);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, GLfloat, void> glViewportIndexedfOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glViewportIndexedfvOES(GLuint index, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glViewportIndexedfvOES;
#endif
    }
}
#endif