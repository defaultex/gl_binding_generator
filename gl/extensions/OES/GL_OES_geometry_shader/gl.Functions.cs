#if (GL_OES_geometry_shader && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFramebufferTextureOES(GLenum target, GLenum attachment, GLuint texture, GLint level);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, texture, GLint, void> glFramebufferTextureOES;
#endif
    }
}
#endif