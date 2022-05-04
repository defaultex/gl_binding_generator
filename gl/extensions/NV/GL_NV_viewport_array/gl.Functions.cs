#if (GL_NV_viewport_array && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDepthRangeArrayfvNV(GLuint first, GLsizei count, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLfloat*, void> glDepthRangeArrayfvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDepthRangeIndexedfNV(GLuint index, GLfloat n, GLfloat f);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, void> glDepthRangeIndexedfNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDisableiNV(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glDisableiNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEnableiNV(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glEnableiNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetFloati_vNV(GLenum target, GLuint index, GLfloat* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLfloat*, void> glGetFloati_vNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsEnablediNV(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, GLboolean> glIsEnablediNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glScissorArrayvNV(GLuint first, GLsizei count, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLint*, void> glScissorArrayvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glScissorIndexedNV(GLuint index, GLint left, GLint bottom, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint, GLint, GLsizei, GLsizei, void> glScissorIndexedNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glScissorIndexedvNV(GLuint index, GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLint*, void> glScissorIndexedvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glViewportArrayvNV(GLuint first, GLsizei count, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLfloat*, void> glViewportArrayvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glViewportIndexedfNV(GLuint index, GLfloat x, GLfloat y, GLfloat w, GLfloat h);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat, GLfloat, GLfloat, GLfloat, void> glViewportIndexedfNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glViewportIndexedfvNV(GLuint index, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLfloat*, void> glViewportIndexedfvNV;
#endif
    }
}
#endif