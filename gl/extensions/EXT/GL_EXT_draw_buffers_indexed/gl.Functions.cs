#if (GL_EXT_draw_buffers_indexed && GLES2_API)
public partial class gles2 { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBlendEquationiEXT(GLuint buf, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendEquationModeEXT, void> glBlendEquationiEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBlendEquationSeparateiEXT(GLuint buf, GLenum modeRGB, GLenum modeAlpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendEquationModeEXT, BlendEquationModeEXT, void> glBlendEquationSeparateiEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBlendFunciEXT(GLuint buf, GLenum src, GLenum dst);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendingFactor, BlendingFactor, void> glBlendFunciEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBlendFuncSeparateiEXT(GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void> glBlendFuncSeparateiEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glColorMaskiEXT(GLuint index, GLboolean r, GLboolean g, GLboolean b, GLboolean a);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean, GLboolean, GLboolean, GLboolean, void> glColorMaskiEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glDisableiEXT(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glDisableiEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEnableiEXT(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glEnableiEXT;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>GLboolean glIsEnablediEXT(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, GLboolean> glIsEnablediEXT;
#endif
    }
}
#endif