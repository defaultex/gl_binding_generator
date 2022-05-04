#if (GL_EXT_multiview_draw_buffers && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDrawBuffersIndexedEXT(GLint n, GLenum* location, GLint* indices);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLenum*, GLint*, void> glDrawBuffersIndexedEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetIntegeri_vEXT(GLenum target, GLuint index, GLint* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLint*, void> glGetIntegeri_vEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glReadBufferIndexedEXT(GLenum src, GLint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ReadBufferMode, GLint, void> glReadBufferIndexedEXT;
#endif
    }
}
#endif