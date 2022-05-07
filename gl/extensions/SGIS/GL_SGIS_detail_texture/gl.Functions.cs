#if (GL_SGIS_detail_texture && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glDetailTexFuncSGIS(GLenum target, GLsizei n, GLfloat* points);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, GLfloat*, void> glDetailTexFuncSGIS;

        /// <summary>void glGetDetailTexFuncSGIS(GLenum target, GLfloat* points);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLfloat*, void> glGetDetailTexFuncSGIS;
    }
}
#endif