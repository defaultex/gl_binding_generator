public partial class gl { 
    public partial class Functions { 

        /// <summary>void glBlendColor(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, GLfloat, GLfloat, void> glBlendColor;

        /// <summary>void glBlendEquation(GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendEquationMode, void> glBlendEquation;

        /// <summary>void glBlendFuncSeparate(GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void> glBlendFuncSeparate;

        /// <summary>void glMultiDrawArrays(GLenum mode, GLint* first, GLsizei* count, GLsizei drawcount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint*, GLsizei*, GLsizei, void> glMultiDrawArrays;

        /// <summary>void glMultiDrawElements(GLenum mode, GLsizei* count, GLenum type, void** indices, GLsizei drawcount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei*, ElementType, void**, GLsizei, void> glMultiDrawElements;

        /// <summary>void glPointParameterf(GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameter, GLfloat, void> glPointParameterf;

        /// <summary>void glPointParameterfv(GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameter, GLfloat*, void> glPointParameterfv;

        /// <summary>void glPointParameteri(GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameter, GLint, void> glPointParameteri;

        /// <summary>void glPointParameteriv(GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PointParameter, GLint*, void> glPointParameteriv;
    }
}
