#if (GL_SGIS_sharpen_texture && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glGetSharpenTexFuncSGIS(GLenum target, GLfloat* points)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLfloat*, void> glGetSharpenTexFuncSGIS;

        /// <summary>void glSharpenTexFuncSGIS(GLenum target, GLsizei n, const GLfloat* points)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, GLfloat*, void> glSharpenTexFuncSGIS;
    }
}
#endif