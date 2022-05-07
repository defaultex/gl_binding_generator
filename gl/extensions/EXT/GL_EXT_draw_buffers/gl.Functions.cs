#if (GL_EXT_draw_buffers && !gles2)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glDrawBuffersEXT(GLsizei n, GLenum* bufs);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLenum*, void> glDrawBuffersEXT;
    }
}
#endif