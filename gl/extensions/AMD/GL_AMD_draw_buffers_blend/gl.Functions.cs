#if (GL_AMD_draw_buffers_blend && !gl)
public partial class gl { 
    public partial class Functions { 
        /// <summary>void glBlendEquationIndexedAMD(GLuint buf, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendEquationModeEXT, void> glBlendEquationIndexedAMD;

        /// <summary>void glBlendEquationSeparateIndexedAMD(GLuint buf, GLenum modeRGB, GLenum modeAlpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendEquationModeEXT, BlendEquationModeEXT, void> glBlendEquationSeparateIndexedAMD;

        /// <summary>void glBlendFuncIndexedAMD(GLuint buf, GLenum src, GLenum dst);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, GLenum, void> glBlendFuncIndexedAMD;

        /// <summary>void glBlendFuncSeparateIndexedAMD(GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void> glBlendFuncSeparateIndexedAMD;
    }
}
#endif