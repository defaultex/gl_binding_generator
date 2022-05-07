#if (GL_VERSION_3_3 && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBindFragDataLocationIndexed(GLuint program, GLuint colorNumber, GLuint index, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLuint, GLchar*, void> glBindFragDataLocationIndexed;

        /// <summary>void glBindSampler(GLuint unit, GLuint sampler);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsampler, void> glBindSampler;

        /// <summary>void glColorP3ui(GLenum type, GLuint color);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorPointerType, GLuint, void> glColorP3ui;

        /// <summary>void glColorP3uiv(GLenum type, GLuint* color);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorPointerType, GLuint*, void> glColorP3uiv;

        /// <summary>void glColorP4ui(GLenum type, GLuint color);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorPointerType, GLuint, void> glColorP4ui;

        /// <summary>void glColorP4uiv(GLenum type, GLuint* color);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorPointerType, GLuint*, void> glColorP4uiv;

        /// <summary>void glDeleteSamplers(GLsizei count, GLuint* samplers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLsampler*, void> glDeleteSamplers;

        /// <summary>void glGenSamplers(GLsizei count, GLuint* samplers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLsampler*, void> glGenSamplers;

        /// <summary>GLint glGetFragDataIndex(GLuint program, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLchar*, GLint> glGetFragDataIndex;

        /// <summary>void glGetQueryObjecti64v(GLuint id, GLenum pname, GLint64* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, QueryObjectParameterName, GLint64*, void> glGetQueryObjecti64v;

        /// <summary>void glGetQueryObjectui64v(GLuint id, GLenum pname, GLuint64* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, QueryObjectParameterName, GLuint64*, void> glGetQueryObjectui64v;

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

        /// <summary>void glMultiTexCoordP1ui(GLenum texture, GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TexCoordPointerType, GLuint, void> glMultiTexCoordP1ui;

        /// <summary>void glMultiTexCoordP1uiv(GLenum texture, GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TexCoordPointerType, GLuint*, void> glMultiTexCoordP1uiv;

        /// <summary>void glMultiTexCoordP2ui(GLenum texture, GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TexCoordPointerType, GLuint, void> glMultiTexCoordP2ui;

        /// <summary>void glMultiTexCoordP2uiv(GLenum texture, GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TexCoordPointerType, GLuint*, void> glMultiTexCoordP2uiv;

        /// <summary>void glMultiTexCoordP3ui(GLenum texture, GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TexCoordPointerType, GLuint, void> glMultiTexCoordP3ui;

        /// <summary>void glMultiTexCoordP3uiv(GLenum texture, GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TexCoordPointerType, GLuint*, void> glMultiTexCoordP3uiv;

        /// <summary>void glMultiTexCoordP4ui(GLenum texture, GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TexCoordPointerType, GLuint, void> glMultiTexCoordP4ui;

        /// <summary>void glMultiTexCoordP4uiv(GLenum texture, GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TexCoordPointerType, GLuint*, void> glMultiTexCoordP4uiv;

        /// <summary>void glNormalP3ui(GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<NormalPointerType, GLuint, void> glNormalP3ui;

        /// <summary>void glNormalP3uiv(GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<NormalPointerType, GLuint*, void> glNormalP3uiv;

        /// <summary>void glQueryCounter(GLuint id, GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, QueryCounterTarget, void> glQueryCounter;

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

        /// <summary>void glSecondaryColorP3ui(GLenum type, GLuint color);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorPointerType, GLuint, void> glSecondaryColorP3ui;

        /// <summary>void glSecondaryColorP3uiv(GLenum type, GLuint* color);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorPointerType, GLuint*, void> glSecondaryColorP3uiv;

        /// <summary>void glTexCoordP1ui(GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexCoordPointerType, GLuint, void> glTexCoordP1ui;

        /// <summary>void glTexCoordP1uiv(GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexCoordPointerType, GLuint*, void> glTexCoordP1uiv;

        /// <summary>void glTexCoordP2ui(GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexCoordPointerType, GLuint, void> glTexCoordP2ui;

        /// <summary>void glTexCoordP2uiv(GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexCoordPointerType, GLuint*, void> glTexCoordP2uiv;

        /// <summary>void glTexCoordP3ui(GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexCoordPointerType, GLuint, void> glTexCoordP3ui;

        /// <summary>void glTexCoordP3uiv(GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexCoordPointerType, GLuint*, void> glTexCoordP3uiv;

        /// <summary>void glTexCoordP4ui(GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexCoordPointerType, GLuint, void> glTexCoordP4ui;

        /// <summary>void glTexCoordP4uiv(GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexCoordPointerType, GLuint*, void> glTexCoordP4uiv;

        /// <summary>void glVertexAttribDivisor(GLuint index, GLuint divisor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glVertexAttribDivisor;

        /// <summary>void glVertexAttribP1ui(GLuint index, GLenum type, GLboolean normalized, GLuint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint, void> glVertexAttribP1ui;

        /// <summary>void glVertexAttribP1uiv(GLuint index, GLenum type, GLboolean normalized, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint*, void> glVertexAttribP1uiv;

        /// <summary>void glVertexAttribP2ui(GLuint index, GLenum type, GLboolean normalized, GLuint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint, void> glVertexAttribP2ui;

        /// <summary>void glVertexAttribP2uiv(GLuint index, GLenum type, GLboolean normalized, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint*, void> glVertexAttribP2uiv;

        /// <summary>void glVertexAttribP3ui(GLuint index, GLenum type, GLboolean normalized, GLuint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint, void> glVertexAttribP3ui;

        /// <summary>void glVertexAttribP3uiv(GLuint index, GLenum type, GLboolean normalized, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint*, void> glVertexAttribP3uiv;

        /// <summary>void glVertexAttribP4ui(GLuint index, GLenum type, GLboolean normalized, GLuint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint, void> glVertexAttribP4ui;

        /// <summary>void glVertexAttribP4uiv(GLuint index, GLenum type, GLboolean normalized, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint*, void> glVertexAttribP4uiv;

        /// <summary>void glVertexP2ui(GLenum type, GLuint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexPointerType, GLuint, void> glVertexP2ui;

        /// <summary>void glVertexP2uiv(GLenum type, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexPointerType, GLuint*, void> glVertexP2uiv;

        /// <summary>void glVertexP3ui(GLenum type, GLuint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexPointerType, GLuint, void> glVertexP3ui;

        /// <summary>void glVertexP3uiv(GLenum type, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexPointerType, GLuint*, void> glVertexP3uiv;

        /// <summary>void glVertexP4ui(GLenum type, GLuint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexPointerType, GLuint, void> glVertexP4ui;

        /// <summary>void glVertexP4uiv(GLenum type, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexPointerType, GLuint*, void> glVertexP4uiv;
    }
}
#endif