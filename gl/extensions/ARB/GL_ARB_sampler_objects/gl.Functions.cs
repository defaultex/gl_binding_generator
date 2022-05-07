#if (GL_ARB_sampler_objects && (!gl || !glcore))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBindSampler(GLuint unit, GLuint sampler);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsampler, void> glBindSampler;

        /// <summary>void glDeleteSamplers(GLsizei count, GLuint* samplers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLsampler*, void> glDeleteSamplers;

        /// <summary>void glGenSamplers(GLsizei count, GLuint* samplers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLsampler*, void> glGenSamplers;

        /// <summary>void glGetSamplerParameterfv(GLuint sampler, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterF, GLfloat*, void> glGetSamplerParameterfv;

        /// <summary>void glGetSamplerParameterIiv(GLuint sampler, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLint*, void> glGetSamplerParameterIiv;

        /// <summary>void glGetSamplerParameterIuiv(GLuint sampler, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLuint*, void> glGetSamplerParameterIuiv;

        /// <summary>void glGetSamplerParameteriv(GLuint sampler, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLint*, void> glGetSamplerParameteriv;

        /// <summary>GLboolean glIsSampler(GLuint sampler);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, GLboolean> glIsSampler;

        /// <summary>void glSamplerParameterf(GLuint sampler, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterF, GLfloat, void> glSamplerParameterf;

        /// <summary>void glSamplerParameterfv(GLuint sampler, GLenum pname, GLfloat* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterF, GLfloat*, void> glSamplerParameterfv;

        /// <summary>void glSamplerParameteri(GLuint sampler, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLint, void> glSamplerParameteri;

        /// <summary>void glSamplerParameterIiv(GLuint sampler, GLenum pname, GLint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLint*, void> glSamplerParameterIiv;

        /// <summary>void glSamplerParameterIuiv(GLuint sampler, GLenum pname, GLuint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLuint*, void> glSamplerParameterIuiv;

        /// <summary>void glSamplerParameteriv(GLuint sampler, GLenum pname, GLint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLint*, void> glSamplerParameteriv;
    }
}
#endif