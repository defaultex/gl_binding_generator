#if (GL_EXT_robustness && (GLES1_API || GLES2_API))
public partial class gles1 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLenum glGetGraphicsResetStatusEXT();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GraphicsResetStatus> glGetGraphicsResetStatusEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetnUniformfvEXT(GLuint program, GLint location, GLsizei bufSize, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLfloat*, void> glGetnUniformfvEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetnUniformivEXT(GLuint program, GLint location, GLsizei bufSize, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLint*, void> glGetnUniformivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glReadnPixelsEXT(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLsizei bufSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, GLsizei, void*, void> glReadnPixelsEXT;
#endif
    }
}
#endif