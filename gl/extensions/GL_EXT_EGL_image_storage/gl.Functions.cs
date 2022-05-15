#if GL_EXT_EGL_image_storage

public partial class gl { 
    public partial class Functions { 

        /// <summary>void glEGLImageTargetTexStorageEXT(GLenum target, GLeglImageOES image, GLint* attrib_list);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLeglImageOES, GLint*, void> glEGLImageTargetTexStorageEXT;

        /// <summary>void glEGLImageTargetTextureStorageEXT(GLuint texture, GLeglImageOES image, GLint* attrib_list);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLeglImageOES, GLint*, void> glEGLImageTargetTextureStorageEXT;
    }
}

#endif