#if (GL_AMD_draw_buffers_blend && GL_API)
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBlendEquationIndexedAMD(GLuint buf, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendEquationModeEXT, void> glBlendEquationIndexedAMD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBlendEquationSeparateIndexedAMD(GLuint buf, GLenum modeRGB, GLenum modeAlpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendEquationModeEXT, BlendEquationModeEXT, void> glBlendEquationSeparateIndexedAMD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBlendFuncIndexedAMD(GLuint buf, GLenum src, GLenum dst);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, GLenum, GLenum, void> glBlendFuncIndexedAMD;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBlendFuncSeparateIndexedAMD(GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void> glBlendFuncSeparateIndexedAMD;
#endif
    }
}
#endif