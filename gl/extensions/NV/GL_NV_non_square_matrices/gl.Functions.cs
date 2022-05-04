#if (GL_NV_non_square_matrices && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniformMatrix2x3fvNV(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix2x3fvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniformMatrix2x4fvNV(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix2x4fvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniformMatrix3x2fvNV(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix3x2fvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniformMatrix3x4fvNV(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix3x4fvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniformMatrix4x2fvNV(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix4x2fvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniformMatrix4x3fvNV(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLboolean, GLfloat*, void> glUniformMatrix4x3fvNV;
#endif
    }
}
#endif