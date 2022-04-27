#if (GL_NV_geometry_program4 && GL_API)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glFramebufferTextureEXT(GLenum target, GLenum attachment, GLuint texture, GLint level)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, GLtexture, GLint, void> glFramebufferTextureEXT;

        /// <summary>void glFramebufferTextureFaceEXT(GLenum target, GLenum attachment, GLuint texture, GLint level, GLenum face)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, GLtexture, GLint, TextureTarget, void> glFramebufferTextureFaceEXT;

        /// <summary>void glFramebufferTextureLayerEXT(GLenum target, GLenum attachment, GLuint texture, GLint level, GLint layer)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, GLtexture, GLint, GLint, void> glFramebufferTextureLayerEXT;

        /// <summary>void glProgramVertexLimitNV(GLenum target, GLint limit)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLint, void> glProgramVertexLimitNV;
    }
}
#endif