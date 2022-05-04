#if (GL_SGIS_texture_filter4 && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetTexFilterFuncSGIS(GLenum target, GLenum filter, GLfloat* weights);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureFilterSGIS, GLfloat*, void> glGetTexFilterFuncSGIS;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glTexFilterFuncSGIS(GLenum target, GLenum filter, GLsizei n, GLfloat* weights);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, TextureFilterSGIS, GLsizei, GLfloat*, void> glTexFilterFuncSGIS;
#endif
    }
}
#endif