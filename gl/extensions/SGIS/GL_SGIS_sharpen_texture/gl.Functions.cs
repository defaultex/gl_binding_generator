#if (GL_SGIS_sharpen_texture && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetSharpenTexFuncSGIS(GLenum target, GLfloat* points);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLfloat*, void> glGetSharpenTexFuncSGIS;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glSharpenTexFuncSGIS(GLenum target, GLsizei n, GLfloat* points);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, GLfloat*, void> glSharpenTexFuncSGIS;
#endif
    }
}
#endif