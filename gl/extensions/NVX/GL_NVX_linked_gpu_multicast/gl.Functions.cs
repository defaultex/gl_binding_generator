#if (GL_NVX_linked_gpu_multicast && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glLGPUCopyImageSubDataNVX(GLuint sourceGpu, GLbitfield destinationGpuMask, GLuint srcName, GLenum srcTarget, GLint srcLevel, GLint srcX, GLint srxY, GLint srcZ, GLuint dstName, GLenum dstTarget, GLint dstLevel, GLint dstX, GLint dstY, GLint dstZ, GLsizei width, GLsizei height, GLsizei depth);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLbitfield, GLuint, GLenum, GLint, GLint, GLint, GLint, GLuint, GLenum, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, void> glLGPUCopyImageSubDataNVX;

        /// <summary>void glLGPUInterlockNVX();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glLGPUInterlockNVX;

        /// <summary>void glLGPUNamedBufferSubDataNVX(GLbitfield gpuMask, GLuint buffer, GLintptr offset, GLsizeiptr size, void* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbitfield, GLbuffer, GLintptr, GLsizeiptr, void*, void> glLGPUNamedBufferSubDataNVX;
    }
}
#endif