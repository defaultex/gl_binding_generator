#if (GL_NV_copy_image && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glCopyImageSubDataNV(GLuint srcName, GLenum srcTarget, GLint srcLevel, GLint srcX, GLint srcY, GLint srcZ, GLuint dstName, GLenum dstTarget, GLint dstLevel, GLint dstX, GLint dstY, GLint dstZ, GLsizei width, GLsizei height, GLsizei depth);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, CopyBufferSubDataTarget, GLint, GLint, GLint, GLint, GLuint, CopyBufferSubDataTarget, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, void> glCopyImageSubDataNV;
    }
}
#endif