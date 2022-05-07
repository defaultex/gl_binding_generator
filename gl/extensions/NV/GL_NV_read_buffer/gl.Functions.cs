#if (GL_NV_read_buffer && !gles2)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glReadBufferNV(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, void> glReadBufferNV;
    }
}
#endif