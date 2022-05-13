public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLuint, GLuint, GLchar*, void> glBindFragDataLocationIndexed;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLsampler, void> glBindSampler;
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLsampler*, void> glDeleteSamplers;
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLsampler*, void> glGenSamplers;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLchar*, GLint> glGetFragDataIndex;
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, QueryObjectParameterName, GLint64*, void> glGetQueryObjecti64v;
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, QueryObjectParameterName, GLuint64*, void> glGetQueryObjectui64v;
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterF, GLfloat*, void> glGetSamplerParameterfv;
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLint*, void> glGetSamplerParameterIiv;
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLuint*, void> glGetSamplerParameterIuiv;
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLint*, void> glGetSamplerParameteriv;
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, GLboolean> glIsSampler;
        public static unsafe delegate* unmanaged[Cdecl]<GLquery, QueryCounterTarget, void> glQueryCounter;
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterF, GLfloat, void> glSamplerParameterf;
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterF, GLfloat*, void> glSamplerParameterfv;
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLint, void> glSamplerParameteri;
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLint*, void> glSamplerParameterIiv;
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLuint*, void> glSamplerParameterIuiv;
        public static unsafe delegate* unmanaged[Cdecl]<GLsampler, SamplerParameterI, GLint*, void> glSamplerParameteriv;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint, void> glVertexAttribDivisor;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint, void> glVertexAttribP1ui;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint*, void> glVertexAttribP1uiv;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint, void> glVertexAttribP2ui;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint*, void> glVertexAttribP2uiv;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint, void> glVertexAttribP3ui;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint*, void> glVertexAttribP3uiv;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint, void> glVertexAttribP4ui;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribPointerType, GLboolean, GLuint*, void> glVertexAttribP4uiv;
    }
}
