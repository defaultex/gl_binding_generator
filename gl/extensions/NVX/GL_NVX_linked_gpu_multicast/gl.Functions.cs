#if (GL_NVX_linked_gpu_multicast && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glLGPUCopyImageSubDataNVX(GLuint sourceGpu, GLbitfield destinationGpuMask, GLuint srcName, GLenum srcTarget, GLint srcLevel, GLint srcX, GLint srxY, GLint srcZ, GLuint dstName, GLenum dstTarget, GLint dstLevel, GLint dstX, GLint dstY, GLint dstZ, GLsizei width, GLsizei height, GLsizei depth);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLbitfield, GLuint, GLenum, GLint, GLint, GLint, GLint, GLuint, GLenum, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, void> glLGPUCopyImageSubDataNVX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glLGPUInterlockNVX();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glLGPUInterlockNVX;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glLGPUNamedBufferSubDataNVX(GLbitfield gpuMask, GLuint buffer, GLintptr offset, GLsizeiptr size, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbitfield, buffer, GLintptr, GLsizeiptr, void*, void> glLGPUNamedBufferSubDataNVX;
#endif
    }
}
#endif