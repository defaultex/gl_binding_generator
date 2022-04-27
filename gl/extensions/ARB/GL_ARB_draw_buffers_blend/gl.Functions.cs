#if (GL_ARB_draw_buffers_blend && (GL_API || GLCORE_API))
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBlendEquationSeparateiARB(GLuint buf, GLenum modeRGB, GLenum modeAlpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendEquationModeEXT, BlendEquationModeEXT, void> glBlendEquationSeparateiARB;

        /// <summary>void glBlendEquationiARB(GLuint buf, GLenum mode)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendEquationModeEXT, void> glBlendEquationiARB;

        /// <summary>void glBlendFuncSeparateiARB(GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void> glBlendFuncSeparateiARB;

        /// <summary>void glBlendFunciARB(GLuint buf, GLenum src, GLenum dst)</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendingFactor, BlendingFactor, void> glBlendFunciARB;
    }
}
#endif