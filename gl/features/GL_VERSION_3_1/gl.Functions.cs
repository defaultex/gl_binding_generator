#if (GL_VERSION_3_1 && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBindBufferBase(GLenum target, GLuint index, GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, GLbuffer, void> glBindBufferBase;

        /// <summary>void glBindBufferRange(GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, GLbuffer, GLintptr, GLsizeiptr, void> glBindBufferRange;

        /// <summary>void glCopyBufferSubData(GLenum readTarget, GLenum writeTarget, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<CopyBufferSubDataTarget, CopyBufferSubDataTarget, GLintptr, GLintptr, GLsizeiptr, void> glCopyBufferSubData;

        /// <summary>void glDrawArraysInstanced(GLenum mode, GLint first, GLsizei count, GLsizei instancecount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint, GLsizei, GLsizei, void> glDrawArraysInstanced;

        /// <summary>void glDrawElementsInstanced(GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei instancecount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, GLsizei, void> glDrawElementsInstanced;

        /// <summary>void glGetActiveUniformBlockiv(GLuint program, GLuint uniformBlockIndex, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, UniformBlockPName, GLint*, void> glGetActiveUniformBlockiv;

        /// <summary>void glGetActiveUniformBlockName(GLuint program, GLuint uniformBlockIndex, GLsizei bufSize, GLsizei* length, GLchar* uniformBlockName);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetActiveUniformBlockName;

        /// <summary>void glGetActiveUniformName(GLuint program, GLuint uniformIndex, GLsizei bufSize, GLsizei* length, GLchar* uniformName);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetActiveUniformName;

        /// <summary>void glGetActiveUniformsiv(GLuint program, GLsizei uniformCount, GLuint* uniformIndices, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLsizei, GLuint*, UniformPName, GLint*, void> glGetActiveUniformsiv;

        /// <summary>void glGetIntegeri_v(GLenum target, GLuint index, GLint* data);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GetPName, GLuint, GLint*, void> glGetIntegeri_v;

        /// <summary>GLuint glGetUniformBlockIndex(GLuint program, GLchar* uniformBlockName);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLchar*, GLuint> glGetUniformBlockIndex;

        /// <summary>void glGetUniformIndices(GLuint program, GLsizei uniformCount, GLchar** uniformNames, GLuint* uniformIndices);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLsizei, GLchar**, GLuint*, void> glGetUniformIndices;

        /// <summary>void glPrimitiveRestartIndex(GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, void> glPrimitiveRestartIndex;

        /// <summary>void glTexBuffer(GLenum target, GLenum internalformat, GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, SizedInternalFormat, GLbuffer, void> glTexBuffer;

        /// <summary>void glUniformBlockBinding(GLuint program, GLuint uniformBlockIndex, GLuint uniformBlockBinding);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLuint, void> glUniformBlockBinding;
    }
}
#endif