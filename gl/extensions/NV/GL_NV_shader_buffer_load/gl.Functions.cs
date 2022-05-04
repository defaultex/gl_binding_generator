#if (GL_NV_shader_buffer_load && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetBufferParameterui64vNV(GLenum target, GLenum pname, GLuint64EXT* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLenum, GLuint64EXT*, void> glGetBufferParameterui64vNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetIntegerui64vNV(GLenum value, GLuint64EXT* result);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLuint64EXT*, void> glGetIntegerui64vNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetNamedBufferParameterui64vNV(GLuint buffer, GLenum pname, GLuint64EXT* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, BufferPNameARB, GLuint64EXT*, void> glGetNamedBufferParameterui64vNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetUniformui64vNV(GLuint program, GLint location, GLuint64EXT* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLuint64EXT*, void> glGetUniformui64vNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsBufferResidentNV(GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLboolean> glIsBufferResidentNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsNamedBufferResidentNV(GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, GLboolean> glIsNamedBufferResidentNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMakeBufferNonResidentNV(GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, void> glMakeBufferNonResidentNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMakeBufferResidentNV(GLenum target, GLenum access);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLenum, void> glMakeBufferResidentNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMakeNamedBufferNonResidentNV(GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, void> glMakeNamedBufferNonResidentNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glMakeNamedBufferResidentNV(GLuint buffer, GLenum access);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<buffer, GLenum, void> glMakeNamedBufferResidentNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformui64NV(GLuint program, GLint location, GLuint64EXT value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLuint64EXT, void> glProgramUniformui64NV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramUniformui64vNV(GLuint program, GLint location, GLsizei count, GLuint64EXT* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLint, GLsizei, GLuint64EXT*, void> glProgramUniformui64vNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniformui64NV(GLint location, GLuint64EXT value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint64EXT, void> glUniformui64NV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glUniformui64vNV(GLint location, GLsizei count, GLuint64EXT* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint64EXT*, void> glUniformui64vNV;
#endif
    }
}
#endif