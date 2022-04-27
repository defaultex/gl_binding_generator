#if (GL_NV_shader_buffer_load && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glGetBufferParameterui64vNV(GLenum target, GLenum pname, GLuint64EXT* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLenum, GLuint64EXT*, void> glGetBufferParameterui64vNV;

        /// <summary>void glGetIntegerui64vNV(GLenum value, GLuint64EXT* result)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint64EXT*, void> glGetIntegerui64vNV;

        /// <summary>void glGetNamedBufferParameterui64vNV(GLuint buffer, GLenum pname, GLuint64EXT* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, BufferPNameARB, GLuint64EXT*, void> glGetNamedBufferParameterui64vNV;

        /// <summary>void glGetUniformui64vNV(GLuint program, GLint location, GLuint64EXT* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint64EXT*, void> glGetUniformui64vNV;

        /// <summary>GLboolean glIsBufferResidentNV(GLenum target)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLboolean> glIsBufferResidentNV;

        /// <summary>GLboolean glIsNamedBufferResidentNV(GLuint buffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLboolean> glIsNamedBufferResidentNV;

        /// <summary>void glMakeBufferNonResidentNV(GLenum target)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, void> glMakeBufferNonResidentNV;

        /// <summary>void glMakeBufferResidentNV(GLenum target, GLenum access)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLenum, void> glMakeBufferResidentNV;

        /// <summary>void glMakeNamedBufferNonResidentNV(GLuint buffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, void> glMakeNamedBufferNonResidentNV;

        /// <summary>void glMakeNamedBufferResidentNV(GLuint buffer, GLenum access)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLbuffer, GLenum, void> glMakeNamedBufferResidentNV;

        /// <summary>void glProgramUniformui64NV(GLuint program, GLint location, GLuint64EXT value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint64EXT, void> glProgramUniformui64NV;

        /// <summary>void glProgramUniformui64vNV(GLuint program, GLint location, GLsizei count, const GLuint64EXT* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint64EXT*, void> glProgramUniformui64vNV;

        /// <summary>void glUniformui64NV(GLint location, GLuint64EXT value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint64EXT, void> glUniformui64NV;

        /// <summary>void glUniformui64vNV(GLint location, GLsizei count, const GLuint64EXT* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint64EXT*, void> glUniformui64vNV;
    }
}
#endif