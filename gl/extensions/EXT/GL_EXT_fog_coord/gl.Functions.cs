#if (GL_EXT_fog_coord && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glFogCoorddEXT(GLdouble coord);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, void> glFogCoorddEXT;

        /// <summary>void glFogCoorddvEXT(GLdouble* coord);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glFogCoorddvEXT;

        /// <summary>void glFogCoordfEXT(GLfloat coord);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glFogCoordfEXT;

        /// <summary>void glFogCoordfvEXT(GLfloat* coord);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glFogCoordfvEXT;

        /// <summary>void glFogCoordPointerEXT(GLenum type, GLsizei stride, void* pointer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FogPointerTypeEXT, GLsizei, void*, void> glFogCoordPointerEXT;
    }
}
#endif