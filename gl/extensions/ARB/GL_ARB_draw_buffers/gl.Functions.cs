#if (GL_ARB_draw_buffers && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glDrawBuffersARB(GLsizei n, GLenum* bufs);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, DrawBufferMode*, void> glDrawBuffersARB;
    }
}
#endif