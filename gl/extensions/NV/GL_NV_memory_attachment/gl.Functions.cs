#if (GL_NV_memory_attachment && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBufferAttachMemoryNV(GLenum target, GLuint memory, GLuint64 offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, GLuint64, void> glBufferAttachMemoryNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetMemoryObjectDetachedResourcesuivNV(GLuint memory, GLenum pname, GLint first, GLsizei count, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, GLint, GLsizei, GLuint*, void> glGetMemoryObjectDetachedResourcesuivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedBufferAttachMemoryNV(GLuint buffer, GLuint memory, GLuint64 offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, GLuint, GLuint64, void> glNamedBufferAttachMemoryNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glResetMemoryObjectParameterNV(GLuint memory, GLenum pname);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, void> glResetMemoryObjectParameterNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexAttachMemoryNV(GLenum target, GLuint memory, GLuint64 offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLuint, GLuint64, void> glTexAttachMemoryNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureAttachMemoryNV(GLuint texture, GLuint memory, GLuint64 offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLuint, GLuint64, void> glTextureAttachMemoryNV;
#endif
    }
}
#endif