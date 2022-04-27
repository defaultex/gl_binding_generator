#if (GL_AMD_framebuffer_sample_positions && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glFramebufferSamplePositionsfvAMD(GLenum target, GLuint numsamples, GLuint pixelindex, const GLfloat* values)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLuint, GLuint, GLfloat*, void> glFramebufferSamplePositionsfvAMD;

        /// <summary>void glGetFramebufferParameterfvAMD(GLenum target, GLenum pname, GLuint numsamples, GLuint pixelindex, GLsizei size, GLfloat* values)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachmentParameterName, GLuint, GLuint, GLsizei, GLfloat*, void> glGetFramebufferParameterfvAMD;

        /// <summary>void glGetNamedFramebufferParameterfvAMD(GLuint framebuffer, GLenum pname, GLuint numsamples, GLuint pixelindex, GLsizei size, GLfloat* values)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, GLenum, GLuint, GLuint, GLsizei, GLfloat*, void> glGetNamedFramebufferParameterfvAMD;

        /// <summary>void glNamedFramebufferSamplePositionsfvAMD(GLuint framebuffer, GLuint numsamples, GLuint pixelindex, const GLfloat* values)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLframebuffer, GLuint, GLuint, GLfloat*, void> glNamedFramebufferSamplePositionsfvAMD;
    }
}
#endif