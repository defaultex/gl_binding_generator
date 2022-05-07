#if (GL_EXT_semaphore && (!gl || !gles2))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glDeleteSemaphoresEXT(GLsizei n, GLuint* semaphores);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glDeleteSemaphoresEXT;

        /// <summary>void glGenSemaphoresEXT(GLsizei n, GLuint* semaphores);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glGenSemaphoresEXT;

        /// <summary>void glGetSemaphoreParameterui64vEXT(GLuint semaphore, GLenum pname, GLuint64* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, SemaphoreParameterName, GLuint64*, void> glGetSemaphoreParameterui64vEXT;

        /// <summary>GLboolean glIsSemaphoreEXT(GLuint semaphore);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean> glIsSemaphoreEXT;

        /// <summary>void glSemaphoreParameterui64vEXT(GLuint semaphore, GLenum pname, GLuint64* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, SemaphoreParameterName, GLuint64*, void> glSemaphoreParameterui64vEXT;

        /// <summary>void glSignalSemaphoreEXT(GLuint semaphore, GLuint numBufferBarriers, GLuint* buffers, GLuint numTextureBarriers, GLuint* textures, GLenum* dstLayouts);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLbuffer*, GLuint, GLtexture*, TextureLayout*, void> glSignalSemaphoreEXT;

        /// <summary>void glWaitSemaphoreEXT(GLuint semaphore, GLuint numBufferBarriers, GLuint* buffers, GLuint numTextureBarriers, GLuint* textures, GLenum* srcLayouts);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLbuffer*, GLuint, GLtexture*, TextureLayout*, void> glWaitSemaphoreEXT;
    }
}
#endif