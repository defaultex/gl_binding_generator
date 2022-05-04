#if (GL_VERSION_4_4 && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBindBuffersBase(GLenum target, GLuint first, GLsizei count, GLuint* buffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, GLsizei, buffer*, void> glBindBuffersBase;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBindBuffersRange(GLenum target, GLuint first, GLsizei count, GLuint* buffers, GLintptr* offsets, GLsizeiptr* sizes);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, GLsizei, buffer*, GLintptr*, GLsizeiptr*, void> glBindBuffersRange;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBindImageTextures(GLuint first, GLsizei count, GLuint* textures);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, texture*, void> glBindImageTextures;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBindSamplers(GLuint first, GLsizei count, GLuint* samplers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, sampler*, void> glBindSamplers;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBindTextures(GLuint first, GLsizei count, GLuint* textures);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, texture*, void> glBindTextures;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBindVertexBuffers(GLuint first, GLsizei count, GLuint* buffers, GLintptr* offsets, GLsizei* strides);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, buffer*, GLintptr*, GLsizei*, void> glBindVertexBuffers;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBufferStorage(GLenum target, GLsizeiptr size, void* data, GLbitfield flags);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferStorageTarget, GLsizeiptr, void*, BufferStorageMask, void> glBufferStorage;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glClearTexImage(GLuint texture, GLint level, GLenum format, GLenum type, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLint, PixelFormat, PixelType, void*, void> glClearTexImage;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glClearTexSubImage(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glClearTexSubImage;
#endif
    }
}
#endif