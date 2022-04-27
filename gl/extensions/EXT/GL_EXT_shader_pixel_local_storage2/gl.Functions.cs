#if (GL_EXT_shader_pixel_local_storage2 && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glClearPixelLocalStorageuiEXT(GLsizei offset, GLsizei n, const GLuint* values)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLsizei, GLuint*, void> glClearPixelLocalStorageuiEXT;

        /// <summary>void glFramebufferPixelLocalStorageSizeEXT(GLuint target, GLsizei size)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, void> glFramebufferPixelLocalStorageSizeEXT;

        /// <summary>GLsizei glGetFramebufferPixelLocalStorageSizeEXT(GLuint target)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLsizei> glGetFramebufferPixelLocalStorageSizeEXT;
    }
}
#endif