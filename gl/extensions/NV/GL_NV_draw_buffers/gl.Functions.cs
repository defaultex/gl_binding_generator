#if (GL_NV_draw_buffers && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDrawBuffersNV(GLsizei n, GLenum* bufs);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLenum*, void> glDrawBuffersNV;
#endif
    }
}
#endif