#if GL_ARB_bindless_texture

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, GLboolean, GLint, PixelFormat, GLuint64> glGetImageHandleARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLuint64> glGetTextureHandleARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLsampler, GLuint64> glGetTextureSamplerHandleARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, VertexAttribEnum, GLuint64EXT*, void> glGetVertexAttribLui64vARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, GLboolean> glIsImageHandleResidentARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, GLboolean> glIsTextureHandleResidentARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, void> glMakeImageHandleNonResidentARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, GLenum, void> glMakeImageHandleResidentARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, void> glMakeTextureHandleNonResidentARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, void> glMakeTextureHandleResidentARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint64, void> glProgramUniformHandleui64ARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint64*, void> glProgramUniformHandleui64vARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint64, void> glUniformHandleui64ARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint64*, void> glUniformHandleui64vARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint64EXT, void> glVertexAttribL1ui64ARB;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLuint64EXT*, void> glVertexAttribL1ui64vARB;
    }
}

#endif