#if (GL_EXT_texture_array && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glFramebufferTextureLayerEXT(GLenum target, GLenum attachment, GLuint texture, GLint level, GLint layer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, GLtexture, GLint, GLint, void> glFramebufferTextureLayerEXT;
    }
}
#endif