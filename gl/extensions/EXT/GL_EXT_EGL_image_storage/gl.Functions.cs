#if (GL_EXT_EGL_image_storage && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEGLImageTargetTexStorageEXT(GLenum target, GLeglImageOES image, GLint* attrib_list);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLenum, GLeglImageOES, GLint*, void> glEGLImageTargetTexStorageEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEGLImageTargetTextureStorageEXT(GLuint texture, GLeglImageOES image, GLint* attrib_list);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<texture, GLeglImageOES, GLint*, void> glEGLImageTargetTextureStorageEXT;
#endif
    }
}
#endif