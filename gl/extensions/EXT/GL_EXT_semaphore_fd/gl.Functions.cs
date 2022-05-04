#if (GL_EXT_semaphore_fd && (GL_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glImportSemaphoreFdEXT(GLuint semaphore, GLenum handleType, GLint fd);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ExternalHandleType, GLint, void> glImportSemaphoreFdEXT;
#endif
    }
}
#endif