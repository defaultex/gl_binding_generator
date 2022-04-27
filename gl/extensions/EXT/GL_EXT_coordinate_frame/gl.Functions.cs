#if (GL_EXT_coordinate_frame && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBinormal3bEXT(GLbyte bx, GLbyte by, GLbyte bz)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte, GLbyte, GLbyte, void> glBinormal3bEXT;

        /// <summary>void glBinormal3bvEXT(const GLbyte* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte*, void> glBinormal3bvEXT;

        /// <summary>void glBinormal3dEXT(GLdouble bx, GLdouble by, GLdouble bz)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, void> glBinormal3dEXT;

        /// <summary>void glBinormal3dvEXT(const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glBinormal3dvEXT;

        /// <summary>void glBinormal3fEXT(GLfloat bx, GLfloat by, GLfloat bz)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glBinormal3fEXT;

        /// <summary>void glBinormal3fvEXT(const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glBinormal3fvEXT;

        /// <summary>void glBinormal3iEXT(GLint bx, GLint by, GLint bz)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, void> glBinormal3iEXT;

        /// <summary>void glBinormal3ivEXT(const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glBinormal3ivEXT;

        /// <summary>void glBinormal3sEXT(GLshort bx, GLshort by, GLshort bz)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, void> glBinormal3sEXT;

        /// <summary>void glBinormal3svEXT(const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glBinormal3svEXT;

        /// <summary>void glBinormalPointerEXT(GLenum type, GLsizei stride, const void* pointer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BinormalPointerTypeEXT, GLsizei, void*, void> glBinormalPointerEXT;

        /// <summary>void glTangent3bEXT(GLbyte tx, GLbyte ty, GLbyte tz)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte, GLbyte, GLbyte, void> glTangent3bEXT;

        /// <summary>void glTangent3bvEXT(const GLbyte* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbyte*, void> glTangent3bvEXT;

        /// <summary>void glTangent3dEXT(GLdouble tx, GLdouble ty, GLdouble tz)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble, GLdouble, GLdouble, void> glTangent3dEXT;

        /// <summary>void glTangent3dvEXT(const GLdouble* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLdouble*, void> glTangent3dvEXT;

        /// <summary>void glTangent3fEXT(GLfloat tx, GLfloat ty, GLfloat tz)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, void> glTangent3fEXT;

        /// <summary>void glTangent3fvEXT(const GLfloat* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat*, void> glTangent3fvEXT;

        /// <summary>void glTangent3iEXT(GLint tx, GLint ty, GLint tz)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLint, GLint, void> glTangent3iEXT;

        /// <summary>void glTangent3ivEXT(const GLint* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint*, void> glTangent3ivEXT;

        /// <summary>void glTangent3sEXT(GLshort tx, GLshort ty, GLshort tz)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort, GLshort, GLshort, void> glTangent3sEXT;

        /// <summary>void glTangent3svEXT(const GLshort* v)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLshort*, void> glTangent3svEXT;

        /// <summary>void glTangentPointerEXT(GLenum type, GLsizei stride, const void* pointer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TangentPointerTypeEXT, GLsizei, void*, void> glTangentPointerEXT;
    }
}
#endif