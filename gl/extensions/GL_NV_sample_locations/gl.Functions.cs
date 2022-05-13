#if GL_NV_sample_locations

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLuint, GLsizei, GLfloat*, void> glFramebufferSampleLocationsfvNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, GLuint, GLsizei, GLfloat*, void> glNamedFramebufferSampleLocationsfvNV;
        public static unsafe delegate* unmanaged[Cdecl]<void> glResolveDepthValuesNV;
    }
}

#endif