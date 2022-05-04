#if (GL_EXT_semaphore && (GL_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDeleteSemaphoresEXT(GLsizei n, GLuint* semaphores);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glDeleteSemaphoresEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGenSemaphoresEXT(GLsizei n, GLuint* semaphores);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, void> glGenSemaphoresEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetSemaphoreParameterui64vEXT(GLuint semaphore, GLenum pname, GLuint64* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, SemaphoreParameterName, GLuint64*, void> glGetSemaphoreParameterui64vEXT;
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
        /// <summary>GLboolean glIsSemaphoreEXT(GLuint semaphore);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean> glIsSemaphoreEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSemaphoreParameterui64vEXT(GLuint semaphore, GLenum pname, GLuint64* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, SemaphoreParameterName, GLuint64*, void> glSemaphoreParameterui64vEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSignalSemaphoreEXT(GLuint semaphore, GLuint numBufferBarriers, GLuint* buffers, GLuint numTextureBarriers, GLuint* textures, GLenum* dstLayouts);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, buffer*, GLuint, texture*, TextureLayout*, void> glSignalSemaphoreEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glWaitSemaphoreEXT(GLuint semaphore, GLuint numBufferBarriers, GLuint* buffers, GLuint numTextureBarriers, GLuint* textures, GLenum* srcLayouts);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, buffer*, GLuint, texture*, TextureLayout*, void> glWaitSemaphoreEXT;
#endif
    }
}
#endif