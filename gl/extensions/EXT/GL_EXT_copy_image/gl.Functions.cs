#if (GL_EXT_copy_image && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glCopyImageSubDataEXT(GLuint srcName, GLenum srcTarget, GLint srcLevel, GLint srcX, GLint srcY, GLint srcZ, GLuint dstName, GLenum dstTarget, GLint dstLevel, GLint dstX, GLint dstY, GLint dstZ, GLsizei srcWidth, GLsizei srcHeight, GLsizei srcDepth)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, CopyBufferSubDataTarget, GLint, GLint, GLint, GLint, GLuint, CopyBufferSubDataTarget, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, void> glCopyImageSubDataEXT;
    }
}
#endif