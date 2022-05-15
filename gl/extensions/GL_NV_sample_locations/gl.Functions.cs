#if GL_NV_sample_locations

public partial class gl { 
    public partial class Functions { 

        /// <summary>void glFramebufferSampleLocationsfvNV(GLenum target, GLuint start, GLsizei count, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLuint, GLsizei, GLfloat*, void> glFramebufferSampleLocationsfvNV;

        /// <summary>void glNamedFramebufferSampleLocationsfvNV(GLuint framebuffer, GLuint start, GLsizei count, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, GLuint, GLsizei, GLfloat*, void> glNamedFramebufferSampleLocationsfvNV;

        /// <summary>void glResolveDepthValuesNV();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glResolveDepthValuesNV;
    }
}

#endif