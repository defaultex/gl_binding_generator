#if (GL_OES_draw_buffers_indexed && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBlendEquationiOES(GLuint buf, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendEquationModeEXT, void> glBlendEquationiOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBlendEquationSeparateiOES(GLuint buf, GLenum modeRGB, GLenum modeAlpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendEquationModeEXT, BlendEquationModeEXT, void> glBlendEquationSeparateiOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBlendFunciOES(GLuint buf, GLenum src, GLenum dst);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendingFactor, BlendingFactor, void> glBlendFunciOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBlendFuncSeparateiOES(GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void> glBlendFuncSeparateiOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColorMaskiOES(GLuint index, GLboolean r, GLboolean g, GLboolean b, GLboolean a);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean, GLboolean, GLboolean, GLboolean, void> glColorMaskiOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDisableiOES(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glDisableiOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEnableiOES(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glEnableiOES;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsEnablediOES(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, GLboolean> glIsEnablediOES;
#endif
    }
}
#endif