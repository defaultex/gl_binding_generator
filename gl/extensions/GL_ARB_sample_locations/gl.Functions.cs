#if GL_ARB_sample_locations

public partial class gl { 
    public partial class Functions { 

        /// <summary>void glEvaluateDepthValuesARB();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glEvaluateDepthValuesARB;

        /// <summary>void glFramebufferSampleLocationsfvARB(GLenum target, GLuint start, GLsizei count, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLuint, GLsizei, GLfloat*, void> glFramebufferSampleLocationsfvARB;

        /// <summary>void glNamedFramebufferSampleLocationsfvARB(GLuint framebuffer, GLuint start, GLsizei count, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, GLuint, GLsizei, GLfloat*, void> glNamedFramebufferSampleLocationsfvARB;
    }
}

#endif