#if (GL_OES_copy_image && !gles2)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glCopyImageSubDataOES(GLuint srcName, GLenum srcTarget, GLint srcLevel, GLint srcX, GLint srcY, GLint srcZ, GLuint dstName, GLenum dstTarget, GLint dstLevel, GLint dstX, GLint dstY, GLint dstZ, GLsizei srcWidth, GLsizei srcHeight, GLsizei srcDepth);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, CopyBufferSubDataTarget, GLint, GLint, GLint, GLint, GLuint, CopyBufferSubDataTarget, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, void> glCopyImageSubDataOES;
    }
}
#endif