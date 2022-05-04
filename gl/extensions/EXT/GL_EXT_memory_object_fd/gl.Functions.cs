#if (GL_EXT_memory_object_fd && (GL_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glImportMemoryFdEXT(GLuint memory, GLuint64 size, GLenum handleType, GLint fd);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint64, ExternalHandleType, GLint, void> glImportMemoryFdEXT;
#endif
    }
}
#endif