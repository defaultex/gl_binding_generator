#if (GL_EXT_memory_object_win32 && (GL_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glImportMemoryWin32HandleEXT(GLuint memory, GLuint64 size, GLenum handleType, void* handle)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint64, ExternalHandleType, void*, void> glImportMemoryWin32HandleEXT;

        /// <summary>void glImportMemoryWin32NameEXT(GLuint memory, GLuint64 size, GLenum handleType, const void* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint64, ExternalHandleType, void*, void> glImportMemoryWin32NameEXT;
    }
}
#endif