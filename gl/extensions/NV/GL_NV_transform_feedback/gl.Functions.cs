#if (GL_NV_transform_feedback && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glActiveVaryingNV(GLuint program, const GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLchar*, void> glActiveVaryingNV;

        /// <summary>void glBeginTransformFeedbackNV(GLenum primitiveMode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void> glBeginTransformFeedbackNV;

        /// <summary>void glBindBufferBaseNV(GLenum target, GLuint index, GLuint buffer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, GLbuffer, void> glBindBufferBaseNV;

        /// <summary>void glBindBufferOffsetNV(GLenum target, GLuint index, GLuint buffer, GLintptr offset)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, GLbuffer, GLintptr, void> glBindBufferOffsetNV;

        /// <summary>void glBindBufferRangeNV(GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, GLbuffer, GLintptr, GLsizeiptr, void> glBindBufferRangeNV;

        /// <summary>void glEndTransformFeedbackNV()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glEndTransformFeedbackNV;

        /// <summary>void glGetActiveVaryingNV(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLsizei* size, GLenum* type, GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLsizei, GLsizei*, GLsizei*, GLenum*, GLchar*, void> glGetActiveVaryingNV;

        /// <summary>void glGetTransformFeedbackVaryingNV(GLuint program, GLuint index, GLint* location)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLint*, void> glGetTransformFeedbackVaryingNV;

        /// <summary>GLint glGetVaryingLocationNV(GLuint program, const GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLchar*, GLint> glGetVaryingLocationNV;

        /// <summary>void glTransformFeedbackAttribsNV(GLsizei count, const GLint* attribs, GLenum bufferMode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLint*, GLenum, void> glTransformFeedbackAttribsNV;

        /// <summary>void glTransformFeedbackStreamAttribsNV(GLsizei count, const GLint* attribs, GLsizei nbuffers, const GLint* bufstreams, GLenum bufferMode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLint*, GLsizei, GLint*, GLenum, void> glTransformFeedbackStreamAttribsNV;

        /// <summary>void glTransformFeedbackVaryingsNV(GLuint program, GLsizei count, const GLint* locations, GLenum bufferMode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLsizei, GLint*, GLenum, void> glTransformFeedbackVaryingsNV;
    }
}
#endif