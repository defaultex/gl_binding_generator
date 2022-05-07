#if (GL_EXT_transform_feedback && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBeginTransformFeedbackEXT(GLenum primitiveMode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, void> glBeginTransformFeedbackEXT;

        /// <summary>void glBindBufferBaseEXT(GLenum target, GLuint index, GLuint buffer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, GLbuffer, void> glBindBufferBaseEXT;

        /// <summary>void glBindBufferOffsetEXT(GLenum target, GLuint index, GLuint buffer, GLintptr offset);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, GLbuffer, GLintptr, void> glBindBufferOffsetEXT;

        /// <summary>void glBindBufferRangeEXT(GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLuint, GLbuffer, GLintptr, GLsizeiptr, void> glBindBufferRangeEXT;

        /// <summary>void glEndTransformFeedbackEXT();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glEndTransformFeedbackEXT;

        /// <summary>void glGetTransformFeedbackVaryingEXT(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLsizei* size, GLenum* type, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLsizei, GLsizei*, GLsizei*, AttributeType*, GLchar*, void> glGetTransformFeedbackVaryingEXT;

        /// <summary>void glTransformFeedbackVaryingsEXT(GLuint program, GLsizei count, GLchar** varyings, GLenum bufferMode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLsizei, GLchar**, GLenum, void> glTransformFeedbackVaryingsEXT;
    }
}
#endif