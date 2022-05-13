#if GL_EXT_EGL_image_storage

public partial class gl { 
    public partial class Functions { 
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLeglImageOES, GLint*, void> glEGLImageTargetTexStorageEXT;
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLeglImageOES, GLint*, void> glEGLImageTargetTextureStorageEXT;
    }
}

#endif