#if (GL_SGIS_detail_texture && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDetailTexFuncSGIS(GLenum target, GLsizei n, GLfloat* points);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLsizei, GLfloat*, void> glDetailTexFuncSGIS;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetDetailTexFuncSGIS(GLenum target, GLfloat* points);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLfloat*, void> glGetDetailTexFuncSGIS;
#endif
    }
}
#endif