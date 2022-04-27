#if (GL_OES_query_matrix && (GL_API || GLES1_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>GLbitfield glQueryMatrixxOES(GLfixed* mantissa, GLint* exponent)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLfixed*, GLint*, GLbitfield> glQueryMatrixxOES;
    }
}
#endif