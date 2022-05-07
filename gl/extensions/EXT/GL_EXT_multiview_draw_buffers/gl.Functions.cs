#if (GL_EXT_multiview_draw_buffers && !gles2)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glDrawBuffersIndexedEXT(GLint n, GLenum* location, GLint* indices);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLenum*, GLint*, void> glDrawBuffersIndexedEXT;

        /// <summary>void glGetIntegeri_vEXT(GLenum target, GLuint index, GLint* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLint*, void> glGetIntegeri_vEXT;

        /// <summary>void glReadBufferIndexedEXT(GLenum src, GLint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ReadBufferMode, GLint, void> glReadBufferIndexedEXT;
    }
}
#endif