#if (GL_EXT_shader_pixel_local_storage2 && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glClearPixelLocalStorageuiEXT(GLsizei offset, GLsizei n, GLuint* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLsizei, GLuint*, void> glClearPixelLocalStorageuiEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFramebufferPixelLocalStorageSizeEXT(GLuint target, GLsizei size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, void> glFramebufferPixelLocalStorageSizeEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLsizei glGetFramebufferPixelLocalStorageSizeEXT(GLuint target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLsizei> glGetFramebufferPixelLocalStorageSizeEXT;
#endif
    }
}
#endif