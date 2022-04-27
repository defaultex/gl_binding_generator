#if (GL_EXT_geometry_shader && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glFramebufferTextureEXT(GLenum target, GLenum attachment, GLuint texture, GLint level)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, GLtexture, GLint, void> glFramebufferTextureEXT;
    }
}
#endif