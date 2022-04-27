#if (GL_EXT_EGL_image_storage && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glEGLImageTargetTexStorageEXT(GLenum target, GLeglImageOES image, const GLint*  attrib_list)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLeglImageOES, GLint*, void> glEGLImageTargetTexStorageEXT;

        /// <summary>void glEGLImageTargetTextureStorageEXT(GLuint texture, GLeglImageOES image, const GLint*  attrib_list)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLtexture, GLeglImageOES, GLint*, void> glEGLImageTargetTextureStorageEXT;
    }
}
#endif