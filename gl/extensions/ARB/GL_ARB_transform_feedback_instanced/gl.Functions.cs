#if (GL_ARB_transform_feedback_instanced && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glDrawTransformFeedbackInstanced(GLenum mode, GLuint id, GLsizei instancecount)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLtransformfeedback, GLsizei, void> glDrawTransformFeedbackInstanced;

        /// <summary>void glDrawTransformFeedbackStreamInstanced(GLenum mode, GLuint id, GLuint stream, GLsizei instancecount)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLtransformfeedback, GLuint, GLsizei, void> glDrawTransformFeedbackStreamInstanced;
    }
}
#endif