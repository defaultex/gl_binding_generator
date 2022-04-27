#if (GL_VERSION_3_3 && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBindFragDataLocationIndexed(GLuint program, GLuint colorNumber, GLuint index, const GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLuint, GLchar*, void> glBindFragDataLocationIndexed;

#if !GL_ES_VERSION_3_0

        /// <summary>void glBindSampler(GLuint unit, GLuint sampler)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsampler, void> glBindSampler;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glDeleteSamplers(GLsizei count, const GLuint* samplers)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLsampler*, void> glDeleteSamplers;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glGenSamplers(GLsizei count, GLuint* samplers)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLsampler*, void> glGenSamplers;

#endif

        /// <summary>GLint glGetFragDataIndex(GLuint program, const GLchar* name)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLchar*, GLint> glGetFragDataIndex;

        /// <summary>void glGetQueryObjecti64v(GLuint id, GLenum pname, GLint64* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, QueryObjectParameterName, GLint64*, void> glGetQueryObjecti64v;

        /// <summary>void glGetQueryObjectui64v(GLuint id, GLenum pname, GLuint64* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, QueryObjectParameterName, GLuint64*, void> glGetQueryObjectui64v;

#if !GL_ES_VERSION_3_2

        /// <summary>void glGetSamplerParameterIiv(GLuint sampler, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLint*, void> glGetSamplerParameterIiv;

#endif

#if !GL_ES_VERSION_3_2

        /// <summary>void glGetSamplerParameterIuiv(GLuint sampler, GLenum pname, GLuint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLuint*, void> glGetSamplerParameterIuiv;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glGetSamplerParameterfv(GLuint sampler, GLenum pname, GLfloat* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterF, GLfloat*, void> glGetSamplerParameterfv;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glGetSamplerParameteriv(GLuint sampler, GLenum pname, GLint* params)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLint*, void> glGetSamplerParameteriv;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>GLboolean glIsSampler(GLuint sampler)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, GLboolean> glIsSampler;

#endif

        /// <summary>void glQueryCounter(GLuint id, GLenum target)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, QueryCounterTarget, void> glQueryCounter;

#if !GL_ES_VERSION_3_2

        /// <summary>void glSamplerParameterIiv(GLuint sampler, GLenum pname, const GLint* param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLint*, void> glSamplerParameterIiv;

#endif

#if !GL_ES_VERSION_3_2

        /// <summary>void glSamplerParameterIuiv(GLuint sampler, GLenum pname, const GLuint* param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLuint*, void> glSamplerParameterIuiv;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glSamplerParameterf(GLuint sampler, GLenum pname, GLfloat param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterF, GLfloat, void> glSamplerParameterf;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glSamplerParameterfv(GLuint sampler, GLenum pname, const GLfloat* param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterF, GLfloat*, void> glSamplerParameterfv;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glSamplerParameteri(GLuint sampler, GLenum pname, GLint param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLint, void> glSamplerParameteri;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glSamplerParameteriv(GLuint sampler, GLenum pname, const GLint* param)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLint*, void> glSamplerParameteriv;

#endif

#if !GL_ES_VERSION_3_0

        /// <summary>void glVertexAttribDivisor(GLuint index, GLuint divisor)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glVertexAttribDivisor;

#endif

        /// <summary>void glVertexAttribP1ui(GLuint index, GLenum type, GLboolean normalized, GLuint value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint, void> glVertexAttribP1ui;

        /// <summary>void glVertexAttribP1uiv(GLuint index, GLenum type, GLboolean normalized, const GLuint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint*, void> glVertexAttribP1uiv;

        /// <summary>void glVertexAttribP2ui(GLuint index, GLenum type, GLboolean normalized, GLuint value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint, void> glVertexAttribP2ui;

        /// <summary>void glVertexAttribP2uiv(GLuint index, GLenum type, GLboolean normalized, const GLuint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint*, void> glVertexAttribP2uiv;

        /// <summary>void glVertexAttribP3ui(GLuint index, GLenum type, GLboolean normalized, GLuint value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint, void> glVertexAttribP3ui;

        /// <summary>void glVertexAttribP3uiv(GLuint index, GLenum type, GLboolean normalized, const GLuint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint*, void> glVertexAttribP3uiv;

        /// <summary>void glVertexAttribP4ui(GLuint index, GLenum type, GLboolean normalized, GLuint value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint, void> glVertexAttribP4ui;

        /// <summary>void glVertexAttribP4uiv(GLuint index, GLenum type, GLboolean normalized, const GLuint* value)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint*, void> glVertexAttribP4uiv;
    }
}
#endif