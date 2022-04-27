#if (GL_EXT_fog_coord && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glFogCoordPointerEXT(GLenum type, GLsizei stride, const void* pointer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FogPointerTypeEXT, GLsizei, void*, void> glFogCoordPointerEXT;

        /// <summary>void glFogCoorddEXT(GLdouble coord)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, void> glFogCoorddEXT;

        /// <summary>void glFogCoorddvEXT(const GLdouble* coord)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glFogCoorddvEXT;

        /// <summary>void glFogCoordfEXT(GLfloat coord)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, void> glFogCoordfEXT;

        /// <summary>void glFogCoordfvEXT(const GLfloat* coord)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glFogCoordfvEXT;
    }
}
#endif