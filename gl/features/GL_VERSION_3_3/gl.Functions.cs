public partial class gl { 
    public partial class Functions { 

        /// <summary>void glBindFragDataLocationIndexed(GLuint program, GLuint colorNumber, GLuint index, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLuint, GLchar*, void> glBindFragDataLocationIndexed;

        /// <summary>void glBindSampler(GLuint unit, GLuint sampler);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsampler, void> glBindSampler;

        /// <summary>void glDeleteSamplers(GLsizei count, GLuint* samplers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLsampler*, void> glDeleteSamplers;

        /// <summary>void glGenSamplers(GLsizei count, GLuint* samplers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLsampler*, void> glGenSamplers;

        /// <summary>GLint glGetFragDataIndex(GLuint program, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLchar*, GLint> glGetFragDataIndex;

        /// <summary>void glGetQueryObjecti64v(GLuint id, GLenum pname, GLint64* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, QueryObjectParameter, GLint64*, void> glGetQueryObjecti64v;

        /// <summary>void glGetQueryObjectui64v(GLuint id, GLenum pname, GLuint64* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, QueryObjectParameter, GLuint64*, void> glGetQueryObjectui64v;

        /// <summary>void glGetSamplerParameterfv(GLuint sampler, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameter, GLfloat*, void> glGetSamplerParameterfv;

        /// <summary>void glGetSamplerParameterIiv(GLuint sampler, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameter, GLint*, void> glGetSamplerParameterIiv;

        /// <summary>void glGetSamplerParameterIuiv(GLuint sampler, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameter, GLuint*, void> glGetSamplerParameterIuiv;

        /// <summary>void glGetSamplerParameteriv(GLuint sampler, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameter, GLint*, void> glGetSamplerParameteriv;

        /// <summary>GLboolean glIsSampler(GLuint sampler);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, GLboolean> glIsSampler;

        /// <summary>void glQueryCounter(GLuint id, GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, QueryCounterTarget, void> glQueryCounter;

        /// <summary>void glSamplerParameterf(GLuint sampler, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameter, GLfloat, void> glSamplerParameterf;

        /// <summary>void glSamplerParameterfv(GLuint sampler, GLenum pname, GLfloat* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameter, GLfloat*, void> glSamplerParameterfv;

        /// <summary>void glSamplerParameteri(GLuint sampler, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameter, GLint, void> glSamplerParameteri;

        /// <summary>void glSamplerParameterIiv(GLuint sampler, GLenum pname, GLint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameter, GLint*, void> glSamplerParameterIiv;

        /// <summary>void glSamplerParameterIuiv(GLuint sampler, GLenum pname, GLuint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameter, GLuint*, void> glSamplerParameterIuiv;

        /// <summary>void glSamplerParameteriv(GLuint sampler, GLenum pname, GLint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameter, GLint*, void> glSamplerParameteriv;

        /// <summary>void glVertexAttribDivisor(GLuint index, GLuint divisor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glVertexAttribDivisor;

        /// <summary>void glVertexAttribP1ui(GLuint index, GLenum type, GLboolean normalized, GLuint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribType, GLboolean, GLuint, void> glVertexAttribP1ui;

        /// <summary>void glVertexAttribP1uiv(GLuint index, GLenum type, GLboolean normalized, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribType, GLboolean, GLuint*, void> glVertexAttribP1uiv;

        /// <summary>void glVertexAttribP2ui(GLuint index, GLenum type, GLboolean normalized, GLuint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribType, GLboolean, GLuint, void> glVertexAttribP2ui;

        /// <summary>void glVertexAttribP2uiv(GLuint index, GLenum type, GLboolean normalized, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribType, GLboolean, GLuint*, void> glVertexAttribP2uiv;

        /// <summary>void glVertexAttribP3ui(GLuint index, GLenum type, GLboolean normalized, GLuint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribType, GLboolean, GLuint, void> glVertexAttribP3ui;

        /// <summary>void glVertexAttribP3uiv(GLuint index, GLenum type, GLboolean normalized, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribType, GLboolean, GLuint*, void> glVertexAttribP3uiv;

        /// <summary>void glVertexAttribP4ui(GLuint index, GLenum type, GLboolean normalized, GLuint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribType, GLboolean, GLuint, void> glVertexAttribP4ui;

        /// <summary>void glVertexAttribP4uiv(GLuint index, GLenum type, GLboolean normalized, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribType, GLboolean, GLuint*, void> glVertexAttribP4uiv;
    }
}
