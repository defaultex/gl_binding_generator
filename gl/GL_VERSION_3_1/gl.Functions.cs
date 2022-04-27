#if (GL_VERSION_3_1 && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_ES_VERSION_3_0 && !GL_VERSION_3_0)

        /// <summary>void glBindBufferBase(GLenum target, GLuint index, GLuint buffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, GLbuffer, void> glBindBufferBase;

#endif

#if (!GL_ES_VERSION_3_0 && !GL_VERSION_3_0)

        /// <summary>void glBindBufferRange(GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, GLbuffer, GLintptr, GLsizeiptr, void> glBindBufferRange;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glCopyBufferSubData(GLenum readTarget, GLenum writeTarget, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CopyBufferSubDataTarget, CopyBufferSubDataTarget, GLintptr, GLintptr, GLsizeiptr, void> glCopyBufferSubData;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glDrawArraysInstanced(GLenum mode, GLint first, GLsizei count, GLsizei instancecount)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint, GLsizei, GLsizei, void> glDrawArraysInstanced;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glDrawElementsInstanced(GLenum mode, GLsizei count, GLenum type, const void* indices, GLsizei instancecount)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, GLsizei, void> glDrawElementsInstanced;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glGetActiveUniformBlockName(GLuint program, GLuint uniformBlockIndex, GLsizei bufSize, GLsizei* length, GLchar* uniformBlockName)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetActiveUniformBlockName;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glGetActiveUniformBlockiv(GLuint program, GLuint uniformBlockIndex, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, UniformBlockPName, GLint*, void> glGetActiveUniformBlockiv;

#endif

        /// <summary>void glGetActiveUniformName(GLuint program, GLuint uniformIndex, GLsizei bufSize, GLsizei* length, GLchar* uniformName)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetActiveUniformName;

#if !GL_ES_VERSION_3_0

        /// <summary>void glGetActiveUniformsiv(GLuint program, GLsizei uniformCount, const GLuint* uniformIndices, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLsizei, GLuint*, UniformPName, GLint*, void> glGetActiveUniformsiv;

#endif

#if (!GL_ES_VERSION_3_0 && !GL_VERSION_3_0)

        /// <summary>void glGetIntegeri_v(GLenum target, GLuint index, GLint* data)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLint*, void> glGetIntegeri_v;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>GLuint glGetUniformBlockIndex(GLuint program, const GLchar* uniformBlockName)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLchar*, GLuint> glGetUniformBlockIndex;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glGetUniformIndices(GLuint program, GLsizei uniformCount, const GLchar*const* uniformNames, GLuint* uniformIndices)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLsizei, GLchar**, GLuint*, void> glGetUniformIndices;

#endif

        /// <summary>void glPrimitiveRestartIndex(GLuint index)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glPrimitiveRestartIndex;

#if !GL_ES_VERSION_3_2

        /// <summary>void glTexBuffer(GLenum target, GLenum internalformat, GLuint buffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, SizedInternalFormat, GLbuffer, void> glTexBuffer;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glUniformBlockBinding(GLuint program, GLuint uniformBlockIndex, GLuint uniformBlockBinding)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLuint, void> glUniformBlockBinding;

#endif
    }
}
#endif