#if (GL_SGIS_fog_function && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glFogFuncSGIS(GLsizei n, GLfloat* points);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLfloat*, void> glFogFuncSGIS;

        /// <summary>void glGetFogFuncSGIS(GLfloat* points);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glGetFogFuncSGIS;
    }
}
#endif