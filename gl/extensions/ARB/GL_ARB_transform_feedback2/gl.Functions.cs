#if (GL_ARB_transform_feedback2 && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBindTransformFeedback(GLenum target, GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<BindTransformFeedbackTarget, GLtransformfeedback, void> glBindTransformFeedback;

        /// <summary>void glDeleteTransformFeedbacks(GLsizei n, GLuint* ids);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLtransformfeedback*, void> glDeleteTransformFeedbacks;

        /// <summary>void glDrawTransformFeedback(GLenum mode, GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLtransformfeedback, void> glDrawTransformFeedback;

        /// <summary>void glGenTransformFeedbacks(GLsizei n, GLuint* ids);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLtransformfeedback*, void> glGenTransformFeedbacks;

        /// <summary>GLboolean glIsTransformFeedback(GLuint id);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtransformfeedback, GLboolean> glIsTransformFeedback;

        /// <summary>void glPauseTransformFeedback();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glPauseTransformFeedback;

        /// <summary>void glResumeTransformFeedback();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glResumeTransformFeedback;
    }
}
#endif