#if (GL_NV_evaluators && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEvalMapsNV(GLenum target, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EvalTargetNV, EvalMapsModeNV, void> glEvalMapsNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetMapAttribParameterfvNV(GLenum target, GLuint index, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EvalTargetNV, GLuint, MapAttribParameterNV, GLfloat*, void> glGetMapAttribParameterfvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetMapAttribParameterivNV(GLenum target, GLuint index, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EvalTargetNV, GLuint, MapAttribParameterNV, GLint*, void> glGetMapAttribParameterivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetMapControlPointsNV(GLenum target, GLuint index, GLenum type, GLsizei ustride, GLsizei vstride, GLboolean packed, void* points);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EvalTargetNV, GLuint, MapTypeNV, GLsizei, GLsizei, GLboolean, void*, void> glGetMapControlPointsNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetMapParameterfvNV(GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EvalTargetNV, MapParameterNV, GLfloat*, void> glGetMapParameterfvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetMapParameterivNV(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EvalTargetNV, MapParameterNV, GLint*, void> glGetMapParameterivNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMapControlPointsNV(GLenum target, GLuint index, GLenum type, GLsizei ustride, GLsizei vstride, GLint uorder, GLint vorder, GLboolean packed, void* points);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EvalTargetNV, GLuint, MapTypeNV, GLsizei, GLsizei, GLint, GLint, GLboolean, void*, void> glMapControlPointsNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMapParameterfvNV(GLenum target, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EvalTargetNV, MapParameterNV, GLfloat*, void> glMapParameterfvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMapParameterivNV(GLenum target, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EvalTargetNV, MapParameterNV, GLint*, void> glMapParameterivNV;
#endif
    }
}
#endif