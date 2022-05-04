#if (GL_NV_gpu_multicast && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMulticastBarrierNV();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glMulticastBarrierNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMulticastBlitFramebufferNV(GLuint srcGpu, GLuint dstGpu, GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLint, GLint, GLint, GLint, GLint, GLint, GLint, GLint, ClearBufferMask, GLenum, void> glMulticastBlitFramebufferNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMulticastBufferSubDataNV(GLbitfield gpuMask, GLuint buffer, GLintptr offset, GLsizeiptr size, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbitfield, buffer, GLintptr, GLsizeiptr, void*, void> glMulticastBufferSubDataNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMulticastCopyBufferSubDataNV(GLuint readGpu, GLbitfield writeGpuMask, GLuint readBuffer, GLuint writeBuffer, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLbitfield, buffer, buffer, GLintptr, GLintptr, GLsizeiptr, void> glMulticastCopyBufferSubDataNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMulticastCopyImageSubDataNV(GLuint srcGpu, GLbitfield dstGpuMask, GLuint srcName, GLenum srcTarget, GLint srcLevel, GLint srcX, GLint srcY, GLint srcZ, GLuint dstName, GLenum dstTarget, GLint dstLevel, GLint dstX, GLint dstY, GLint dstZ, GLsizei srcWidth, GLsizei srcHeight, GLsizei srcDepth);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLbitfield, GLuint, GLenum, GLint, GLint, GLint, GLint, GLuint, GLenum, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, void> glMulticastCopyImageSubDataNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMulticastFramebufferSampleLocationsfvNV(GLuint gpu, GLuint framebuffer, GLuint start, GLsizei count, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, framebuffer, GLuint, GLsizei, GLfloat*, void> glMulticastFramebufferSampleLocationsfvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMulticastGetQueryObjecti64vNV(GLuint gpu, GLuint id, GLenum pname, GLint64* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLenum, GLint64*, void> glMulticastGetQueryObjecti64vNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMulticastGetQueryObjectivNV(GLuint gpu, GLuint id, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLenum, GLint*, void> glMulticastGetQueryObjectivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMulticastGetQueryObjectui64vNV(GLuint gpu, GLuint id, GLenum pname, GLuint64* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLenum, GLuint64*, void> glMulticastGetQueryObjectui64vNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMulticastGetQueryObjectuivNV(GLuint gpu, GLuint id, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLenum, GLuint*, void> glMulticastGetQueryObjectuivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMulticastWaitSyncNV(GLuint signalGpu, GLbitfield waitGpuMask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLbitfield, void> glMulticastWaitSyncNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glRenderGpuMaskNV(GLbitfield mask);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbitfield, void> glRenderGpuMaskNV;
#endif
    }
}
#endif