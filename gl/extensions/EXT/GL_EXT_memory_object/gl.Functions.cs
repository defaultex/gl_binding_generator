#if (GL_EXT_memory_object && (!gl || !gles2))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBufferStorageMemEXT(GLenum target, GLsizeiptr size, GLuint memory, GLuint64 offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLsizeiptr, GLuint, GLuint64, void> glBufferStorageMemEXT;

        /// <summary>void glCreateMemoryObjectsEXT(GLsizei n, GLuint* memoryObjects);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glCreateMemoryObjectsEXT;

        /// <summary>void glDeleteMemoryObjectsEXT(GLsizei n, GLuint* memoryObjects);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glDeleteMemoryObjectsEXT;

        /// <summary>void glGetMemoryObjectParameterivEXT(GLuint memoryObject, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, MemoryObjectParameterName, GLint*, void> glGetMemoryObjectParameterivEXT;

        /// <summary>void glGetUnsignedBytei_vEXT(GLenum target, GLuint index, GLubyte* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLubyte*, void> glGetUnsignedBytei_vEXT;

        /// <summary>void glGetUnsignedBytevEXT(GLenum pname, GLubyte* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLubyte*, void> glGetUnsignedBytevEXT;

        /// <summary>GLboolean glIsMemoryObjectEXT(GLuint memoryObject);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean> glIsMemoryObjectEXT;

        /// <summary>void glMemoryObjectParameterivEXT(GLuint memoryObject, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, MemoryObjectParameterName, GLint*, void> glMemoryObjectParameterivEXT;

        /// <summary>void glNamedBufferStorageMemEXT(GLuint buffer, GLsizeiptr size, GLuint memory, GLuint64 offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLsizeiptr, GLuint, GLuint64, void> glNamedBufferStorageMemEXT;

        /// <summary>void glTexStorageMem1DEXT(GLenum target, GLsizei levels, GLenum internalFormat, GLsizei width, GLuint memory, GLuint64 offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLuint, GLuint64, void> glTexStorageMem1DEXT;

        /// <summary>void glTexStorageMem2DEXT(GLenum target, GLsizei levels, GLenum internalFormat, GLsizei width, GLsizei height, GLuint memory, GLuint64 offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLuint, GLuint64, void> glTexStorageMem2DEXT;

        /// <summary>void glTexStorageMem2DMultisampleEXT(GLenum target, GLsizei samples, GLenum internalFormat, GLsizei width, GLsizei height, GLboolean fixedSampleLocations, GLuint memory, GLuint64 offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLboolean, GLuint, GLuint64, void> glTexStorageMem2DMultisampleEXT;

        /// <summary>void glTexStorageMem3DEXT(GLenum target, GLsizei levels, GLenum internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLuint memory, GLuint64 offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLsizei, GLuint, GLuint64, void> glTexStorageMem3DEXT;

        /// <summary>void glTexStorageMem3DMultisampleEXT(GLenum target, GLsizei samples, GLenum internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedSampleLocations, GLuint memory, GLuint64 offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLsizei, GLboolean, GLuint, GLuint64, void> glTexStorageMem3DMultisampleEXT;

        /// <summary>void glTextureStorageMem1DEXT(GLuint texture, GLsizei levels, GLenum internalFormat, GLsizei width, GLuint memory, GLuint64 offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLsizei, SizedInternalFormat, GLsizei, GLuint, GLuint64, void> glTextureStorageMem1DEXT;

        /// <summary>void glTextureStorageMem2DEXT(GLuint texture, GLsizei levels, GLenum internalFormat, GLsizei width, GLsizei height, GLuint memory, GLuint64 offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLuint, GLuint64, void> glTextureStorageMem2DEXT;

        /// <summary>void glTextureStorageMem2DMultisampleEXT(GLuint texture, GLsizei samples, GLenum internalFormat, GLsizei width, GLsizei height, GLboolean fixedSampleLocations, GLuint memory, GLuint64 offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLboolean, GLuint, GLuint64, void> glTextureStorageMem2DMultisampleEXT;

        /// <summary>void glTextureStorageMem3DEXT(GLuint texture, GLsizei levels, GLenum internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLuint memory, GLuint64 offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLsizei, GLuint, GLuint64, void> glTextureStorageMem3DEXT;

        /// <summary>void glTextureStorageMem3DMultisampleEXT(GLuint texture, GLsizei samples, GLenum internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedSampleLocations, GLuint memory, GLuint64 offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLsizei, SizedInternalFormat, GLsizei, GLsizei, GLsizei, GLboolean, GLuint, GLuint64, void> glTextureStorageMem3DMultisampleEXT;
    }
}
#endif