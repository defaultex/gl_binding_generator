#if (GL_ARB_uniform_buffer_object && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glBindBufferBase(GLenum target, GLuint index, GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, buffer, void> glBindBufferBase;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glBindBufferRange(GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, buffer, GLintptr, GLsizeiptr, void> glBindBufferRange;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetActiveUniformBlockiv(GLuint program, GLuint uniformBlockIndex, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLuint, UniformBlockPName, GLint*, void> glGetActiveUniformBlockiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetActiveUniformBlockName(GLuint program, GLuint uniformBlockIndex, GLsizei bufSize, GLsizei* length, GLchar* uniformBlockName);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetActiveUniformBlockName;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetActiveUniformName(GLuint program, GLuint uniformIndex, GLsizei bufSize, GLsizei* length, GLchar* uniformName);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetActiveUniformName;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetActiveUniformsiv(GLuint program, GLsizei uniformCount, GLuint* uniformIndices, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLsizei, GLuint*, UniformPName, GLint*, void> glGetActiveUniformsiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetIntegeri_v(GLenum target, GLuint index, GLint* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLint*, void> glGetIntegeri_v;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>GLuint glGetUniformBlockIndex(GLuint program, GLchar* uniformBlockName);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLchar*, GLuint> glGetUniformBlockIndex;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetUniformIndices(GLuint program, GLsizei uniformCount, GLchar** uniformNames, GLuint* uniformIndices);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLsizei, GLchar**, GLuint*, void> glGetUniformIndices;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glUniformBlockBinding(GLuint program, GLuint uniformBlockIndex, GLuint uniformBlockBinding);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLuint, GLuint, void> glUniformBlockBinding;
#endif
    }
}
#endif