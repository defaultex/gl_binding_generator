public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLtexture, void> glBindTexture;
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLint, GLint, GLsizei, GLint, void> glCopyTexImage1D;
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLint, GLint, GLsizei, GLsizei, GLint, void> glCopyTexImage2D;
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLint, GLsizei, void> glCopyTexSubImage1D;
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei, void> glCopyTexSubImage2D;
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLtexture*, void> glDeleteTextures;
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLint, GLsizei, void> glDrawArrays;
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLsizei, DrawElementsType, void*, void> glDrawElements;
        public static unsafe delegate* unmanaged[Cdecl]<GLsizei, GLtexture*, void> glGenTextures;
        public static unsafe delegate* unmanaged[Cdecl]<GetPointervPName, void**, void> glGetPointerv;
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLboolean> glIsTexture;
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLfloat, void> glPolygonOffset;
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLsizei, PixelFormat, PixelType, void*, void> glTexSubImage1D;
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glTexSubImage2D;
    }
}
