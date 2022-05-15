public partial class gl { 
    public partial class Functions { 

        /// <summary>void glCopyBufferSubData(GLenum readTarget, GLenum writeTarget, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTarget, BufferTarget, GLintptr, GLintptr, GLsizeiptr, void> glCopyBufferSubData;

        /// <summary>void glDrawArraysInstanced(GLenum mode, GLint first, GLsizei count, GLsizei instancecount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint, GLsizei, GLsizei, void> glDrawArraysInstanced;

        /// <summary>void glDrawElementsInstanced(GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei instancecount);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, ElementType, void*, GLsizei, void> glDrawElementsInstanced;

        /// <summary>void glGetActiveUniformBlockiv(GLuint program, GLuint uniformBlockIndex, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, UniformBlockParameter, GLint*, void> glGetActiveUniformBlockiv;

        /// <summary>void glGetActiveUniformBlockName(GLuint program, GLuint uniformBlockIndex, GLsizei bufSize, GLsizei* length, GLchar* uniformBlockName);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetActiveUniformBlockName;

        /// <summary>void glGetActiveUniformName(GLuint program, GLuint uniformIndex, GLsizei bufSize, GLsizei* length, GLchar* uniformName);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLsizei, GLsizei*, GLchar*, void> glGetActiveUniformName;

        /// <summary>void glGetActiveUniformsiv(GLuint program, GLsizei uniformCount, GLuint* uniformIndices, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLsizei, GLuint*, UniformParameter, GLint*, void> glGetActiveUniformsiv;

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
