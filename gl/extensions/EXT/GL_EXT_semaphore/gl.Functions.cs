#if (GL_EXT_semaphore && (GL_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glDeleteSemaphoresEXT(GLsizei n, const GLuint* semaphores)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glDeleteSemaphoresEXT;

        /// <summary>void glGenSemaphoresEXT(GLsizei n, GLuint* semaphores)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glGenSemaphoresEXT;

        /// <summary>void glGetSemaphoreParameterui64vEXT(GLuint semaphore, GLenum pname, GLuint64* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, SemaphoreParameterName, GLuint64*, void> glGetSemaphoreParameterui64vEXT;

        /// <summary>void glGetUnsignedBytevEXT(GLenum pname, GLubyte* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLubyte*, void> glGetUnsignedBytevEXT;

        /// <summary>void glGetUnsignedBytei_vEXT(GLenum target, GLuint index, GLubyte* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint, GLubyte*, void> glGetUnsignedBytei_vEXT;

        /// <summary>GLboolean glIsSemaphoreEXT(GLuint semaphore)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean> glIsSemaphoreEXT;

        /// <summary>void glSemaphoreParameterui64vEXT(GLuint semaphore, GLenum pname, const GLuint64* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, SemaphoreParameterName, GLuint64*, void> glSemaphoreParameterui64vEXT;

        /// <summary>void glSignalSemaphoreEXT(GLuint semaphore, GLuint numBufferBarriers, const GLuint* buffers, GLuint numTextureBarriers, const GLuint* textures, const GLenum* dstLayouts)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLbuffer*, GLuint, GLtexture*, TextureLayout*, void> glSignalSemaphoreEXT;

        /// <summary>void glWaitSemaphoreEXT(GLuint semaphore, GLuint numBufferBarriers, const GLuint* buffers, GLuint numTextureBarriers, const GLuint* textures, const GLenum* srcLayouts)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLbuffer*, GLuint, GLtexture*, TextureLayout*, void> glWaitSemaphoreEXT;
    }
}
#endif