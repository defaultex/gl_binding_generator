#if (GL_ARB_transform_feedback3 && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBeginQueryIndexed(GLenum target, GLuint index, GLuint id)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, GLuint, GLquery, void> glBeginQueryIndexed;

        /// <summary>void glDrawTransformFeedbackStream(GLenum mode, GLuint id, GLuint stream)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLtransformfeedback, GLuint, void> glDrawTransformFeedbackStream;

        /// <summary>void glEndQueryIndexed(GLenum target, GLuint index)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, GLuint, void> glEndQueryIndexed;

        /// <summary>void glGetQueryIndexediv(GLenum target, GLuint index, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<QueryTarget, GLuint, QueryParameterName, GLint*, void> glGetQueryIndexediv;
    }
}
#endif