#if (GL_EXT_semaphore_win32 && (GL_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glImportSemaphoreWin32HandleEXT(GLuint semaphore, GLenum handleType, void* handle);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ExternalHandleType, void*, void> glImportSemaphoreWin32HandleEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glImportSemaphoreWin32NameEXT(GLuint semaphore, GLenum handleType, void* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ExternalHandleType, void*, void> glImportSemaphoreWin32NameEXT;
#endif
    }
}
#endif