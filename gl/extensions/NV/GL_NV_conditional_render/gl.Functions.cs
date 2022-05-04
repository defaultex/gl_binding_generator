#if (GL_NV_conditional_render && (GL_API || GLCORE_API || GLES2_API))
public partial class gl { 
    public partial class Functions { 
#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glBeginConditionalRenderNV(GLuint id, GLenum mode);</summary>
        public static unsafe delegate* unmanaged[Cdecl]<GLuint, ConditionalRenderMode, void> glBeginConditionalRenderNV;
#endif

#if (!GL_EXT_texture_shadow_lod)
        /// <summary>void glEndConditionalRenderNV();</summary>
        public static unsafe delegate* unmanaged[Cdecl]<void> glEndConditionalRenderNV;
#endif
    }
}
#endif