#if (GL_ATI_draw_buffers && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glDrawBuffersATI(GLsizei n, GLenum* bufs);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, DrawBufferMode*, void> glDrawBuffersATI;
    }
}
#endif