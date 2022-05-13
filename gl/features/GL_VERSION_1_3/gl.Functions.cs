public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<TextureUnit, void> glActiveTexture;
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLint, GLsizei, void*, void> glCompressedTexImage1D;
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLint, GLsizei, void*, void> glCompressedTexImage2D;
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLsizei, GLint, GLsizei, void*, void> glCompressedTexImage3D;
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTexSubImage1D;
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLsizei, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTexSubImage2D;
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, InternalFormat, GLsizei, void*, void> glCompressedTexSubImage3D;
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, void*, void> glGetCompressedTexImage;
        public static unsafe delegate* unmanaged[Cdecl]<GLfloat, GLboolean, void> glSampleCoverage;
    }
}
