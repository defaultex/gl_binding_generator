#if (GL_ARB_sampler_objects && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glBindSampler(GLuint unit, GLuint sampler);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, sampler, void> glBindSampler;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glDeleteSamplers(GLsizei count, GLuint* samplers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, sampler*, void> glDeleteSamplers;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGenSamplers(GLsizei count, GLuint* samplers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, sampler*, void> glGenSamplers;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetSamplerParameterfv(GLuint sampler, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterF, GLfloat*, void> glGetSamplerParameterfv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetSamplerParameterIiv(GLuint sampler, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterI, GLint*, void> glGetSamplerParameterIiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetSamplerParameterIuiv(GLuint sampler, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterI, GLuint*, void> glGetSamplerParameterIuiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glGetSamplerParameteriv(GLuint sampler, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterI, GLint*, void> glGetSamplerParameteriv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>GLboolean glIsSampler(GLuint sampler);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, GLboolean> glIsSampler;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glSamplerParameterf(GLuint sampler, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterF, GLfloat, void> glSamplerParameterf;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glSamplerParameterfv(GLuint sampler, GLenum pname, GLfloat* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterF, GLfloat*, void> glSamplerParameterfv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glSamplerParameteri(GLuint sampler, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterI, GLint, void> glSamplerParameteri;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glSamplerParameterIiv(GLuint sampler, GLenum pname, GLint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterI, GLint*, void> glSamplerParameterIiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glSamplerParameterIuiv(GLuint sampler, GLenum pname, GLuint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterI, GLuint*, void> glSamplerParameterIuiv;
#endif

#if (!GL_EXT_texture_shadow_lod && !GL_SC_VERSION_2_0)
        /// <summary>void glSamplerParameteriv(GLuint sampler, GLenum pname, GLint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterI, GLint*, void> glSamplerParameteriv;
#endif
    }
}
#endif