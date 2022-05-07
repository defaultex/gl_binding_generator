#if (GL_SGIS_texture_filter4 && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glGetTexFilterFuncSGIS(GLenum target, GLenum filter, GLfloat* weights);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureFilterSGIS, GLfloat*, void> glGetTexFilterFuncSGIS;

        /// <summary>void glTexFilterFuncSGIS(GLenum target, GLenum filter, GLsizei n, GLfloat* weights);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureFilterSGIS, GLsizei, GLfloat*, void> glTexFilterFuncSGIS;
    }
}
#endif