#if (GL_NV_draw_buffers && !gles2)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glDrawBuffersNV(GLsizei n, GLenum* bufs);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLenum*, void> glDrawBuffersNV;
    }
}
#endif