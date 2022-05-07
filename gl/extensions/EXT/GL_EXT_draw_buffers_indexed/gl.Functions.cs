#if (GL_EXT_draw_buffers_indexed && !gles2)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glBlendEquationiEXT(GLuint buf, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendEquationModeEXT, void> glBlendEquationiEXT;

        /// <summary>void glBlendEquationSeparateiEXT(GLuint buf, GLenum modeRGB, GLenum modeAlpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendEquationModeEXT, BlendEquationModeEXT, void> glBlendEquationSeparateiEXT;

        /// <summary>void glBlendFunciEXT(GLuint buf, GLenum src, GLenum dst);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendingFactor, BlendingFactor, void> glBlendFunciEXT;

        /// <summary>void glBlendFuncSeparateiEXT(GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void> glBlendFuncSeparateiEXT;

        /// <summary>void glColorMaskiEXT(GLuint index, GLboolean r, GLboolean g, GLboolean b, GLboolean a);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean, GLboolean, GLboolean, GLboolean, void> glColorMaskiEXT;

        /// <summary>void glDisableiEXT(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glDisableiEXT;

        /// <summary>void glEnableiEXT(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glEnableiEXT;

        /// <summary>GLboolean glIsEnablediEXT(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, GLboolean> glIsEnablediEXT;
    }
}
#endif