#if (GL_NV_sample_locations && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFramebufferSampleLocationsfvNV(GLenum target, GLuint start, GLsizei count, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, GLuint, GLsizei, GLfloat*, void> glFramebufferSampleLocationsfvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glNamedFramebufferSampleLocationsfvNV(GLuint framebuffer, GLuint start, GLsizei count, GLfloat* v);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<framebuffer, GLuint, GLsizei, GLfloat*, void> glNamedFramebufferSampleLocationsfvNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glResolveDepthValuesNV();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glResolveDepthValuesNV;
#endif
    }
}
#endif