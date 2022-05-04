#if (GL_NV_geometry_program4 && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFramebufferTextureEXT(GLenum target, GLenum attachment, GLuint texture, GLint level);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, texture, GLint, void> glFramebufferTextureEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFramebufferTextureFaceEXT(GLenum target, GLenum attachment, GLuint texture, GLint level, GLenum face);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, texture, GLint, TextureTarget, void> glFramebufferTextureFaceEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFramebufferTextureLayerEXT(GLenum target, GLenum attachment, GLuint texture, GLint level, GLint layer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, texture, GLint, GLint, void> glFramebufferTextureLayerEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramVertexLimitNV(GLenum target, GLint limit);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLint, void> glProgramVertexLimitNV;
#endif
    }
}
#endif