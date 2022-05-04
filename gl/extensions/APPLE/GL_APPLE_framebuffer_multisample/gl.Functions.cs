#if (GL_APPLE_framebuffer_multisample && (GLES1_API || GLES2_API))
public partial class gles1 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glRenderbufferStorageMultisampleAPPLE(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<RenderbufferTarget, GLsizei, InternalFormat, GLsizei, GLsizei, void> glRenderbufferStorageMultisampleAPPLE;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glResolveMultisampleFramebufferAPPLE();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glResolveMultisampleFramebufferAPPLE;
#endif
    }
}
#endif