#if (GL_NV_transform_feedback2 && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBindTransformFeedbackNV(GLenum target, GLuint id)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BufferTargetARB, GLtransformfeedback, void> glBindTransformFeedbackNV;

        /// <summary>void glDeleteTransformFeedbacksNV(GLsizei n, const GLuint* ids)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLtransformfeedback*, void> glDeleteTransformFeedbacksNV;

        /// <summary>void glDrawTransformFeedbackNV(GLenum mode, GLuint id)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLtransformfeedback, void> glDrawTransformFeedbackNV;

        /// <summary>void glGenTransformFeedbacksNV(GLsizei n, GLuint* ids)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLtransformfeedback*, void> glGenTransformFeedbacksNV;

        /// <summary>GLboolean glIsTransformFeedbackNV(GLuint id)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtransformfeedback, GLboolean> glIsTransformFeedbackNV;

        /// <summary>void glPauseTransformFeedbackNV()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPauseTransformFeedbackNV;

        /// <summary>void glResumeTransformFeedbackNV()</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glResumeTransformFeedbackNV;
    }
}
#endif