#if (GL_OES_EGL_image && (!gles1 || !gles2))
public partial class gles1 { 
    public partial class Functions { 
        /// <summary>void glEGLImageTargetRenderbufferStorageOES(GLenum target, GLeglImageOES image);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLeglImageOES, void> glEGLImageTargetRenderbufferStorageOES;

        /// <summary>void glEGLImageTargetTexture2DOES(GLenum target, GLeglImageOES image);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLeglImageOES, void> glEGLImageTargetTexture2DOES;
    }
}
#endif