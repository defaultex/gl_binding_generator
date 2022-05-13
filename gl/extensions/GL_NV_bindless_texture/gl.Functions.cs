#if GL_NV_bindless_texture

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLint, GLboolean, GLint, PixelFormat, GLuint64> glGetImageHandleNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLuint64> glGetTextureHandleNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLsampler, GLuint64> glGetTextureSamplerHandleNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, GLboolean> glIsImageHandleResidentNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, GLboolean> glIsTextureHandleResidentNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, void> glMakeImageHandleNonResidentNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, GLenum, void> glMakeImageHandleResidentNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, void> glMakeTextureHandleNonResidentNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLuint64, void> glMakeTextureHandleResidentNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLuint64, void> glProgramUniformHandleui64NV;
        public static unsafe delegate* unmanaged[Cdecl]<GLprogram, GLint, GLsizei, GLuint64*, void> glProgramUniformHandleui64vNV;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLuint64, void> glUniformHandleui64NV;
        public static unsafe delegate* unmanaged[Cdecl]<GLint, GLsizei, GLuint64*, void> glUniformHandleui64vNV;
    }
}

#endif