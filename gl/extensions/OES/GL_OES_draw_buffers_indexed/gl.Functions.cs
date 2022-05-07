#if (GL_OES_draw_buffers_indexed && !gles2)
public partial class gles2 { 
    public partial class Functions { 
        /// <summary>void glBlendEquationiOES(GLuint buf, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendEquationModeEXT, void> glBlendEquationiOES;

        /// <summary>void glBlendEquationSeparateiOES(GLuint buf, GLenum modeRGB, GLenum modeAlpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendEquationModeEXT, BlendEquationModeEXT, void> glBlendEquationSeparateiOES;

        /// <summary>void glBlendFunciOES(GLuint buf, GLenum src, GLenum dst);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendingFactor, BlendingFactor, void> glBlendFunciOES;

        /// <summary>void glBlendFuncSeparateiOES(GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void> glBlendFuncSeparateiOES;

        /// <summary>void glColorMaskiOES(GLuint index, GLboolean r, GLboolean g, GLboolean b, GLboolean a);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLboolean, GLboolean, GLboolean, GLboolean, void> glColorMaskiOES;

        /// <summary>void glDisableiOES(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glDisableiOES;

        /// <summary>void glEnableiOES(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, void> glEnableiOES;

        /// <summary>GLboolean glIsEnablediOES(GLenum target, GLuint index);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<EnableCap, GLuint, GLboolean> glIsEnablediOES;
    }
}
#endif