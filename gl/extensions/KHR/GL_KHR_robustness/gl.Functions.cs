#if (GL_KHR_robustness && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>GLenum glGetGraphicsResetStatus();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GraphicsResetStatus> glGetGraphicsResetStatus;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLenum glGetGraphicsResetStatusKHR();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GraphicsResetStatus> glGetGraphicsResetStatusKHR;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetnUniformfv(GLuint program, GLint location, GLsizei bufSize, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLfloat*, void> glGetnUniformfv;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetnUniformfvKHR(GLuint program, GLint location, GLsizei bufSize, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLfloat*, void> glGetnUniformfvKHR;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetnUniformiv(GLuint program, GLint location, GLsizei bufSize, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLint*, void> glGetnUniformiv;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetnUniformivKHR(GLuint program, GLint location, GLsizei bufSize, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLint*, void> glGetnUniformivKHR;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetnUniformuiv(GLuint program, GLint location, GLsizei bufSize, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLuint*, void> glGetnUniformuiv;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetnUniformuivKHR(GLuint program, GLint location, GLsizei bufSize, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLuint*, void> glGetnUniformuivKHR;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glReadnPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLsizei bufSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, GLsizei, void*, void> glReadnPixels;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glReadnPixelsKHR(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLsizei bufSize, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, GLsizei, void*, void> glReadnPixelsKHR;
#endif
    }
}
#endif