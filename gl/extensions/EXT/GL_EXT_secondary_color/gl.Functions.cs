#if (GL_EXT_secondary_color && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSecondaryColor3bEXT(GLbyte red, GLbyte green, GLbyte blue);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte, GLbyte, GLbyte, void> glSecondaryColor3bEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSecondaryColor3bvEXT(GLbyte* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte*, void> glSecondaryColor3bvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSecondaryColor3dEXT(GLdouble red, GLdouble green, GLdouble blue);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, void> glSecondaryColor3dEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSecondaryColor3dvEXT(GLdouble* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glSecondaryColor3dvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSecondaryColor3fEXT(GLfloat red, GLfloat green, GLfloat blue);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glSecondaryColor3fEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSecondaryColor3fvEXT(GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glSecondaryColor3fvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSecondaryColor3iEXT(GLint red, GLint green, GLint blue);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, void> glSecondaryColor3iEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSecondaryColor3ivEXT(GLint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glSecondaryColor3ivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSecondaryColor3sEXT(GLshort red, GLshort green, GLshort blue);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, void> glSecondaryColor3sEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSecondaryColor3svEXT(GLshort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glSecondaryColor3svEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSecondaryColor3ubEXT(GLubyte red, GLubyte green, GLubyte blue);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte, GLubyte, GLubyte, void> glSecondaryColor3ubEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSecondaryColor3ubvEXT(GLubyte* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLubyte*, void> glSecondaryColor3ubvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSecondaryColor3uiEXT(GLuint red, GLuint green, GLuint blue);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLuint, void> glSecondaryColor3uiEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSecondaryColor3uivEXT(GLuint* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint*, void> glSecondaryColor3uivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSecondaryColor3usEXT(GLushort red, GLushort green, GLushort blue);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLushort, GLushort, GLushort, void> glSecondaryColor3usEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSecondaryColor3usvEXT(GLushort* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLushort*, void> glSecondaryColor3usvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSecondaryColorPointerEXT(GLint size, GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, ColorPointerType, GLsizei, void*, void> glSecondaryColorPointerEXT;
#endif
    }
}
#endif