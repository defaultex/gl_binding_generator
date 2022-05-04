#if (GL_SGIS_fog_function && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFogFuncSGIS(GLsizei n, GLfloat* points);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLfloat*, void> glFogFuncSGIS;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetFogFuncSGIS(GLfloat* points);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glGetFogFuncSGIS;
#endif
    }
}
#endif