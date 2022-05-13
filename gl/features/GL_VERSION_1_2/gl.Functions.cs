public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLint, GLint, GLint, GLsizei, GLsizei, void> glCopyTexSubImage3D;
        public static unsafe delegate* unmanaged[Cdecl]<PrimitiveType, GLuint, GLuint, GLsizei, DrawElementsType, void*, void> glDrawRangeElements;
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, InternalFormat, GLsizei, GLsizei, GLsizei, GLint, PixelFormat, PixelType, void*, void> glTexImage3D;
        public static unsafe delegate* unmanaged[Cdecl]<TextureTarget, GLint, GLint, GLint, GLint, GLsizei, GLsizei, GLsizei, PixelFormat, PixelType, void*, void> glTexSubImage3D;
    }
}
