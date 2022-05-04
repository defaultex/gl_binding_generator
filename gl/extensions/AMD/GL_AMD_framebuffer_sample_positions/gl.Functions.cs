#if (GL_AMD_framebuffer_sample_positions && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFramebufferSamplePositionsfvAMD(GLenum target, GLuint numsamples, GLuint pixelindex, GLfloat* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLuint, GLuint, GLfloat*, void> glFramebufferSamplePositionsfvAMD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetFramebufferParameterfvAMD(GLenum target, GLenum pname, GLuint numsamples, GLuint pixelindex, GLsizei size, GLfloat* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachmentParameterName, GLuint, GLuint, GLsizei, GLfloat*, void> glGetFramebufferParameterfvAMD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glGetNamedFramebufferParameterfvAMD(GLuint framebuffer, GLenum pname, GLuint numsamples, GLuint pixelindex, GLsizei size, GLfloat* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, GLenum, GLuint, GLuint, GLsizei, GLfloat*, void> glGetNamedFramebufferParameterfvAMD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedFramebufferSamplePositionsfvAMD(GLuint framebuffer, GLuint numsamples, GLuint pixelindex, GLfloat* values);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, GLuint, GLuint, GLfloat*, void> glNamedFramebufferSamplePositionsfvAMD;
#endif
    }
}
#endif