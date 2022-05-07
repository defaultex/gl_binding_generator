#if (GL_NV_geometry_program4 && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glFramebufferTextureFaceEXT(GLenum target, GLenum attachment, GLuint texture, GLint level, GLenum face);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, GLtexture, GLint, TextureTarget, void> glFramebufferTextureFaceEXT;

        /// <summary>void glProgramVertexLimitNV(GLenum target, GLint limit);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<ProgramTarget, GLint, void> glProgramVertexLimitNV;
    }
}
#endif