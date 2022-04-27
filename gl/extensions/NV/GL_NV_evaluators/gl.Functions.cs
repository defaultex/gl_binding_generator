#if (GL_NV_evaluators && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glEvalMapsNV(GLenum target, GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EvalTargetNV, EvalMapsModeNV, void> glEvalMapsNV;

        /// <summary>void glGetMapAttribParameterfvNV(GLenum target, GLuint index, GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EvalTargetNV, GLuint, MapAttribParameterNV, GLfloat*, void> glGetMapAttribParameterfvNV;

        /// <summary>void glGetMapAttribParameterivNV(GLenum target, GLuint index, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EvalTargetNV, GLuint, MapAttribParameterNV, GLint*, void> glGetMapAttribParameterivNV;

        /// <summary>void glGetMapControlPointsNV(GLenum target, GLuint index, GLenum type, GLsizei ustride, GLsizei vstride, GLboolean packed, void* points)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EvalTargetNV, GLuint, MapTypeNV, GLsizei, GLsizei, GLboolean, void*, void> glGetMapControlPointsNV;

        /// <summary>void glGetMapParameterfvNV(GLenum target, GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EvalTargetNV, MapParameterNV, GLfloat*, void> glGetMapParameterfvNV;

        /// <summary>void glGetMapParameterivNV(GLenum target, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EvalTargetNV, MapParameterNV, GLint*, void> glGetMapParameterivNV;

        /// <summary>void glMapControlPointsNV(GLenum target, GLuint index, GLenum type, GLsizei ustride, GLsizei vstride, GLint uorder, GLint vorder, GLboolean packed, const void* points)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EvalTargetNV, GLuint, MapTypeNV, GLsizei, GLsizei, GLint, GLint, GLboolean, void*, void> glMapControlPointsNV;

        /// <summary>void glMapParameterfvNV(GLenum target, GLenum pname, const GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EvalTargetNV, MapParameterNV, GLfloat*, void> glMapParameterfvNV;

        /// <summary>void glMapParameterivNV(GLenum target, GLenum pname, const GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EvalTargetNV, MapParameterNV, GLint*, void> glMapParameterivNV;
    }
}
#endif