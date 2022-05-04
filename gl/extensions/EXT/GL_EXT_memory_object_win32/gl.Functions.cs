#if (GL_EXT_memory_object_win32 && (GL_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glImportMemoryWin32HandleEXT(GLuint memory, GLuint64 size, GLenum handleType, void* handle);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint64, ExternalHandleType, void*, void> glImportMemoryWin32HandleEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glImportMemoryWin32NameEXT(GLuint memory, GLuint64 size, GLenum handleType, void* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint64, ExternalHandleType, void*, void> glImportMemoryWin32NameEXT;
#endif
    }
}
#endif