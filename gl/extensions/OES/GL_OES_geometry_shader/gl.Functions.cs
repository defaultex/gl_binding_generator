#if (GL_OES_geometry_shader && !gles2)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glFramebufferTextureOES(GLenum target, GLenum attachment, GLuint texture, GLint level);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, GLtexture, GLint, void> glFramebufferTextureOES;
    }
}
#endif