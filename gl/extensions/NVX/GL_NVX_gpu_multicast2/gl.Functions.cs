#if (GL_NVX_gpu_multicast2 && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>GLuint glAsyncCopyBufferSubDataNVX(GLsizei waitSemaphoreCount, const GLuint* waitSemaphoreArray, const GLuint64* fenceValueArray, GLuint readGpu, GLbitfield writeGpuMask, GLuint readBuffer, GLuint writeBuffer, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size, GLsizei signalSemaphoreCount, const GLuint* signalSemaphoreArray, const GLuint64* signalValueArray)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, GLuint64*, GLuint, GLbitfield, GLbuffer, GLbuffer, GLintptr, GLintptr, GLsizeiptr, GLsizei, GLuint*, GLuint64*, GLuint> glAsyncCopyBufferSubDataNVX;

        /// <summary>GLuint glAsyncCopyImageSubDataNVX(GLsizei waitSemaphoreCount, const GLuint* waitSemaphoreArray, const GLuint64* waitValueArray, GLuint srcGpu, GLbitfield dstGpuMask, GLuint srcName, GLenum srcTarget, GLint srcLevel, GLint srcX, GLint srcY, GLint srcZ, GLuint dstName, GLenum dstTarget, GLint dstLevel, GLint dstX, GLint dstY, GLint dstZ, GLsizei srcWidth, GLsizei srcHeight, GLsizei srcDepth, GLsizei signalSemaphoreCount, const GLuint* signalSemaphoreArray, const GLuint64* signalValueArray)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLuint*, GLuint64*, GLuint, GLbitfield, GLuint, GLenum, GLint, GLint, GLint, GLint, GLuint, GLenum, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, GLsizei, GLuint*, GLuint64*, GLuint> glAsyncCopyImageSubDataNVX;

        /// <summary>void glMulticastScissorArrayvNVX(GLuint gpu, GLuint first, GLsizei count, const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLsizei, GLint*, void> glMulticastScissorArrayvNVX;

        /// <summary>void glMulticastViewportArrayvNVX(GLuint gpu, GLuint first, GLsizei count, const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLsizei, GLfloat*, void> glMulticastViewportArrayvNVX;

        /// <summary>void glMulticastViewportPositionWScaleNVX(GLuint gpu, GLuint index, GLfloat xcoeff, GLfloat ycoeff)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, GLfloat, GLfloat, void> glMulticastViewportPositionWScaleNVX;

        /// <summary>void glUploadGpuMaskNVX(GLbitfield mask)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbitfield, void> glUploadGpuMaskNVX;
    }
}
#endif