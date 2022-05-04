#if (GL_EXT_memory_object && (GL_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBufferStorageMemEXT(GLenum target, GLsizeiptr size, GLuint memory, GLuint64 offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLsizeiptr, GLuint, GLuint64, void> glBufferStorageMemEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glCreateMemoryObjectsEXT(GLsizei n, GLuint* memoryObjects);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glCreateMemoryObjectsEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeleteMemoryObjectsEXT(GLsizei n, GLuint* memoryObjects);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glDeleteMemoryObjectsEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetMemoryObjectParameterivEXT(GLuint memoryObject, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, MemoryObjectParameterName, GLint*, void> glGetMemoryObjectParameterivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetUnsignedBytei_vEXT(GLenum target, GLuint index, GLubyte* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLubyte*, void> glGetUnsignedBytei_vEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetUnsignedBytevEXT(GLenum pname, GLubyte* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLubyte*, void> glGetUnsignedBytevEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsMemoryObjectEXT(GLuint memoryObject);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean> glIsMemoryObjectEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMemoryObjectParameterivEXT(GLuint memoryObject, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, MemoryObjectParameterName, GLint*, void> glMemoryObjectParameterivEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedBufferStorageMemEXT(GLuint buffer, GLsizeiptr size, GLuint memory, GLuint64 offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, GLsizeiptr, GLuint, GLuint64, void> glNamedBufferStorageMemEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexStorageMem1DEXT(GLenum target, GLsizei levels, GLenum internalFormat, GLsizei width, GLuint memory, GLuint64 offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLuint, GLuint64, void> glTexStorageMem1DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexStorageMem2DEXT(GLenum target, GLsizei levels, GLenum internalFormat, GLsizei width, GLsizei height, GLuint memory, GLuint64 offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLuint, GLuint64, void> glTexStorageMem2DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexStorageMem2DMultisampleEXT(GLenum target, GLsizei samples, GLenum internalFormat, GLsizei width, GLsizei height, GLboolean fixedSampleLocations, GLuint memory, GLuint64 offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLboolean, GLuint, GLuint64, void> glTexStorageMem2DMultisampleEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexStorageMem3DEXT(GLenum target, GLsizei levels, GLenum internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLuint memory, GLuint64 offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLsizei, GLuint, GLuint64, void> glTexStorageMem3DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexStorageMem3DMultisampleEXT(GLenum target, GLsizei samples, GLenum internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedSampleLocations, GLuint memory, GLuint64 offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLsizei, GLboolean, GLuint, GLuint64, void> glTexStorageMem3DMultisampleEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureStorageMem1DEXT(GLuint texture, GLsizei levels, GLenum internalFormat, GLsizei width, GLuint memory, GLuint64 offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLsizei, SizedInternalFormat, GLsizei, GLuint, GLuint64, void> glTextureStorageMem1DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureStorageMem2DEXT(GLuint texture, GLsizei levels, GLenum internalFormat, GLsizei width, GLsizei height, GLuint memory, GLuint64 offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLuint, GLuint64, void> glTextureStorageMem2DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureStorageMem2DMultisampleEXT(GLuint texture, GLsizei samples, GLenum internalFormat, GLsizei width, GLsizei height, GLboolean fixedSampleLocations, GLuint memory, GLuint64 offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLboolean, GLuint, GLuint64, void> glTextureStorageMem2DMultisampleEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureStorageMem3DEXT(GLuint texture, GLsizei levels, GLenum internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLuint memory, GLuint64 offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLsizei, GLuint, GLuint64, void> glTextureStorageMem3DEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTextureStorageMem3DMultisampleEXT(GLuint texture, GLsizei samples, GLenum internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedSampleLocations, GLuint memory, GLuint64 offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLsizei, GLboolean, GLuint, GLuint64, void> glTextureStorageMem3DMultisampleEXT;
#endif
    }
}
#endif