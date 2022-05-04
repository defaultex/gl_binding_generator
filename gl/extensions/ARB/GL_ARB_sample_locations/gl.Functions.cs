#if (GL_ARB_sample_locations && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEvaluateDepthValuesARB();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glEvaluateDepthValuesARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFramebufferSampleLocationsfvARB(GLenum target, GLuint start, GLsizei count, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLuint, GLsizei, GLfloat*, void> glFramebufferSampleLocationsfvARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedFramebufferSampleLocationsfvARB(GLuint framebuffer, GLuint start, GLsizei count, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, GLuint, GLsizei, GLfloat*, void> glNamedFramebufferSampleLocationsfvARB;
#endif
    }
}
#endif