#if (GL_ARB_multi_bind && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBindBuffersBase(GLenum target, GLuint first, GLsizei count, GLuint* buffers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, GLsizei, GLbuffer*, void> glBindBuffersBase;

        /// <summary>void glBindBuffersRange(GLenum target, GLuint first, GLsizei count, GLuint* buffers, GLintptr* offsets, GLsizeiptr* sizes);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, GLsizei, GLbuffer*, GLintptr*, GLsizeiptr*, void> glBindBuffersRange;

        /// <summary>void glBindImageTextures(GLuint first, GLsizei count, GLuint* textures);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLtexture*, void> glBindImageTextures;

        /// <summary>void glBindSamplers(GLuint first, GLsizei count, GLuint* samplers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLsampler*, void> glBindSamplers;

        /// <summary>void glBindTextures(GLuint first, GLsizei count, GLuint* textures);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLtexture*, void> glBindTextures;

        /// <summary>void glBindVertexBuffers(GLuint first, GLsizei count, GLuint* buffers, GLintptr* offsets, GLsizei* strides);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsizei, GLbuffer*, GLintptr*, GLsizei*, void> glBindVertexBuffers;
    }
}
#endif