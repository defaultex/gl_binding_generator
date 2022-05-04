#if (GL_VERSION_3_3 && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBindFragDataLocationIndexed(GLuint program, GLuint colorNumber, GLuint index, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLuint, GLuint, GLchar*, void> glBindFragDataLocationIndexed;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glBindSampler(GLuint unit, GLuint sampler);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, sampler, void> glBindSampler;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColorP3ui(GLenum type, GLuint color);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorPointerType, GLuint, void> glColorP3ui;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColorP3uiv(GLenum type, GLuint* color);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorPointerType, GLuint*, void> glColorP3uiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColorP4ui(GLenum type, GLuint color);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorPointerType, GLuint, void> glColorP4ui;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glColorP4uiv(GLenum type, GLuint* color);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorPointerType, GLuint*, void> glColorP4uiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glDeleteSamplers(GLsizei count, GLuint* samplers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, sampler*, void> glDeleteSamplers;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGenSamplers(GLsizei count, GLuint* samplers);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, sampler*, void> glGenSamplers;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLint glGetFragDataIndex(GLuint program, GLchar* name);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, GLchar*, GLint> glGetFragDataIndex;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetQueryObjecti64v(GLuint id, GLenum pname, GLint64* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<query, QueryObjectParameterName, GLint64*, void> glGetQueryObjecti64v;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetQueryObjectui64v(GLuint id, GLenum pname, GLuint64* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<query, QueryObjectParameterName, GLuint64*, void> glGetQueryObjectui64v;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetSamplerParameterfv(GLuint sampler, GLenum pname, GLfloat* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterF, GLfloat*, void> glGetSamplerParameterfv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetSamplerParameterIiv(GLuint sampler, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterI, GLint*, void> glGetSamplerParameterIiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetSamplerParameterIuiv(GLuint sampler, GLenum pname, GLuint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterI, GLuint*, void> glGetSamplerParameterIuiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glGetSamplerParameteriv(GLuint sampler, GLenum pname, GLint* params);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterI, GLint*, void> glGetSamplerParameteriv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>GLboolean glIsSampler(GLuint sampler);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, GLboolean> glIsSampler;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoordP1ui(GLenum texture, GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TexCoordPointerType, GLuint, void> glMultiTexCoordP1ui;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoordP1uiv(GLenum texture, GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TexCoordPointerType, GLuint*, void> glMultiTexCoordP1uiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoordP2ui(GLenum texture, GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TexCoordPointerType, GLuint, void> glMultiTexCoordP2ui;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoordP2uiv(GLenum texture, GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TexCoordPointerType, GLuint*, void> glMultiTexCoordP2uiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoordP3ui(GLenum texture, GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TexCoordPointerType, GLuint, void> glMultiTexCoordP3ui;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoordP3uiv(GLenum texture, GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TexCoordPointerType, GLuint*, void> glMultiTexCoordP3uiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoordP4ui(GLenum texture, GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TexCoordPointerType, GLuint, void> glMultiTexCoordP4ui;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glMultiTexCoordP4uiv(GLenum texture, GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, TexCoordPointerType, GLuint*, void> glMultiTexCoordP4uiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glNormalP3ui(GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<NormalPointerType, GLuint, void> glNormalP3ui;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glNormalP3uiv(GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<NormalPointerType, GLuint*, void> glNormalP3uiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glQueryCounter(GLuint id, GLenum target);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<query, QueryCounterTarget, void> glQueryCounter;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glSamplerParameterf(GLuint sampler, GLenum pname, GLfloat param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterF, GLfloat, void> glSamplerParameterf;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glSamplerParameterfv(GLuint sampler, GLenum pname, GLfloat* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterF, GLfloat*, void> glSamplerParameterfv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glSamplerParameteri(GLuint sampler, GLenum pname, GLint param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterI, GLint, void> glSamplerParameteri;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glSamplerParameterIiv(GLuint sampler, GLenum pname, GLint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterI, GLint*, void> glSamplerParameterIiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glSamplerParameterIuiv(GLuint sampler, GLenum pname, GLuint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterI, GLuint*, void> glSamplerParameterIuiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glSamplerParameteriv(GLuint sampler, GLenum pname, GLint* param);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<sampler, SamplerParameterI, GLint*, void> glSamplerParameteriv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glSecondaryColorP3ui(GLenum type, GLuint color);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorPointerType, GLuint, void> glSecondaryColorP3ui;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glSecondaryColorP3uiv(GLenum type, GLuint* color);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ColorPointerType, GLuint*, void> glSecondaryColorP3uiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoordP1ui(GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexCoordPointerType, GLuint, void> glTexCoordP1ui;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoordP1uiv(GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexCoordPointerType, GLuint*, void> glTexCoordP1uiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoordP2ui(GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexCoordPointerType, GLuint, void> glTexCoordP2ui;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoordP2uiv(GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexCoordPointerType, GLuint*, void> glTexCoordP2uiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoordP3ui(GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexCoordPointerType, GLuint, void> glTexCoordP3ui;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoordP3uiv(GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexCoordPointerType, GLuint*, void> glTexCoordP3uiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoordP4ui(GLenum type, GLuint coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexCoordPointerType, GLuint, void> glTexCoordP4ui;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glTexCoordP4uiv(GLenum type, GLuint* coords);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<TexCoordPointerType, GLuint*, void> glTexCoordP4uiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribDivisor(GLuint index, GLuint divisor);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glVertexAttribDivisor;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribP1ui(GLuint index, GLenum type, GLboolean normalized, GLuint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint, void> glVertexAttribP1ui;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribP1uiv(GLuint index, GLenum type, GLboolean normalized, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint*, void> glVertexAttribP1uiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribP2ui(GLuint index, GLenum type, GLboolean normalized, GLuint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint, void> glVertexAttribP2ui;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribP2uiv(GLuint index, GLenum type, GLboolean normalized, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint*, void> glVertexAttribP2uiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribP3ui(GLuint index, GLenum type, GLboolean normalized, GLuint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint, void> glVertexAttribP3ui;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribP3uiv(GLuint index, GLenum type, GLboolean normalized, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint*, void> glVertexAttribP3uiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribP4ui(GLuint index, GLenum type, GLboolean normalized, GLuint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint, void> glVertexAttribP4ui;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexAttribP4uiv(GLuint index, GLenum type, GLboolean normalized, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint*, void> glVertexAttribP4uiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexP2ui(GLenum type, GLuint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexPointerType, GLuint, void> glVertexP2ui;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexP2uiv(GLenum type, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexPointerType, GLuint*, void> glVertexP2uiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexP3ui(GLenum type, GLuint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexPointerType, GLuint, void> glVertexP3ui;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexP3uiv(GLenum type, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexPointerType, GLuint*, void> glVertexP3uiv;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexP4ui(GLenum type, GLuint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexPointerType, GLuint, void> glVertexP4ui;
#endif

#if (!GL_SC_VERSION_2_0)
        /// <summary>void glVertexP4uiv(GLenum type, GLuint* value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<VertexPointerType, GLuint*, void> glVertexP4uiv;
#endif
    }
}
#endif