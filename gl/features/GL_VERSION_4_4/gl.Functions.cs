public partial class gl { 
    public partial class Functions { 

        /// <summary>void glBindBuffersBase(GLenum target, GLuint first, GLsizei count, GLuint* buffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTarget, GLuint, GLsizei, GLbuffer*, void> glBindBuffersBase;

        /// <summary>void glBindBuffersRange(GLenum target, GLuint first, GLsizei count, GLuint* buffers, GLintptr* offsets, GLsizeiptr* sizes);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTarget, GLuint, GLsizei, GLbuffer*, GLintptr*, GLsizeiptr*, void> glBindBuffersRange;

        /// <summary>void glBindImageTextures(GLuint first, GLsizei count, GLuint* textures);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLtexture*, void> glBindImageTextures;

        /// <summary>void glBindSamplers(GLuint first, GLsizei count, GLuint* samplers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLsampler*, void> glBindSamplers;

        /// <summary>void glBindTextures(GLuint first, GLsizei count, GLuint* textures);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLtexture*, void> glBindTextures;

        /// <summary>void glBindVertexBuffers(GLuint first, GLsizei count, GLuint* buffers, GLintptr* offsets, GLsizei* strides);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLbuffer*, GLintptr*, GLsizei*, void> glBindVertexBuffers;

        /// <summary>void glBufferStorage(GLenum target, GLsizeiptr size, void* data, GLbitfield flags);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTarget, GLsizeiptr, void*, BufferStorageMask, void> glBufferStorage;

        /// <summary>void glClearTexImage(GLuint texture, GLint level, GLenum format, GLenum type, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, PixelFormat, PixelType, void*, void> glClearTexImage;

        /// <summary>void glClearTexSubImage(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glClearTexSubImage;
    }
}
