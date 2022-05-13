#if GL_ARB_sample_locations

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<void> glEvaluateDepthValuesARB;
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLuint, GLsizei, GLfloat*, void> glFramebufferSampleLocationsfvARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, GLuint, GLsizei, GLfloat*, void> glNamedFramebufferSampleLocationsfvARB;
    }
}

#endif