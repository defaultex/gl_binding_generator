#if (GL_ARB_geometry_shader4 && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFramebufferTextureARB(GLenum target, GLenum attachment, GLuint texture, GLint level);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, texture, GLint, void> glFramebufferTextureARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFramebufferTextureFaceARB(GLenum target, GLenum attachment, GLuint texture, GLint level, GLenum face);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, texture, GLint, TextureTarget, void> glFramebufferTextureFaceARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glFramebufferTextureLayerARB(GLenum target, GLenum attachment, GLuint texture, GLint level, GLint layer);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<FramebufferTarget, FramebufferAttachment, texture, GLint, GLint, void> glFramebufferTextureLayerARB;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glProgramParameteriARB(GLuint program, GLenum pname, GLint value);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<program, ProgramParameterPName, GLint, void> glProgramParameteriARB;
#endif
    }
}
#endif