#if (GL_EXT_draw_transform_feedback && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glDrawTransformFeedbackEXT(GLenum mode, GLuint id)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLtransformfeedback, void> glDrawTransformFeedbackEXT;

        /// <summary>void glDrawTransformFeedbackInstancedEXT(GLenum mode, GLuint id, GLsizei instancecount)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLtransformfeedback, GLsizei, void> glDrawTransformFeedbackInstancedEXT;
    }
}
#endif